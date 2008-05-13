#include "methodcall.h"
#include "qyoto.h"
#include "methodreturnvalue.h"

MethodCall::MethodCall(Smoke *smoke, Smoke::Index method, void * target, Smoke::Stack sp, int items) :
	_cur(-1), _smoke(smoke), _method(method), _target(target), _o(0), _sp(sp), _items(items), _called(false)
{
	if (!isConstructor() && !isStatic()) {
		_o = (smokeqyoto_object*) (*GetSmokeObject)(_target);
		if (_o != 0 && _o->ptr != 0) {
			if (	isDestructor() 
					&& (!_o->allocated || IsContainedInstance(_o) || application_terminated) ) 
			{
				_called = true;
				_o->allocated = false;
			}
		} else {
			// not a constructor, not static, pointer invalid -> object already destroyed
			_called = true;
		}
	}

	_args = _smoke->argumentList + _smoke->methods[_method].args;
	_items = _smoke->methods[_method].numArgs;
	numItems = items;
	_stack = new Smoke::StackItem[items + 1];
	_retval = _sp;
}

MethodCall::~MethodCall() { delete[] _stack; }

void MethodCall::unsupported()
{
	if (strcmp(_smoke->className(method().classId), "QGlobalSpace") == 0) {
		qFatal("Cannot handle '%s' as argument to %s",
		       type().name(),
		       _smoke->methodNames[method().name]);
	} else {
		qFatal("Cannot handle '%s' as argument to %s::%s",
		       type().name(),
		       _smoke->className(method().classId),
		       _smoke->methodNames[method().name]);
	}
}

void MethodCall::callMethod()
{
	if (_called) return;
	_called = true;
	Smoke::ClassFn fn = _smoke->classes[method().classId].classFn;
	void *ptr = 0;
	if (_o != 0 && _o->ptr != 0) {
		ptr = _smoke->cast(_o->ptr, _o->classId, method().classId);
	}
	_items = -1;
	
	/*
	 * special case the QApplication/QCoreApplication constructor call
	 * the int reference has to stay valid all the time, so create an additional pointer here
	 */
	if (isConstructor() && (   strcmp(_smoke->methodNames[method().name], "QApplication") == 0
				|| strcmp(_smoke->methodNames[method().name], "QCoreApplication") == 0)) {
		int* i = new int(_sp[1].s_int);
		_stack[1].s_voidp = i;
	}
	
	(*fn)(method().method, ptr, _stack);
	
	if (isConstructor()) {
		_o = alloc_smokeqyoto_object(true, _smoke, method().classId, _stack[0].s_voidp);
		(*SetSmokeObject)(_target, _o);
		mapPointer(_target, _o, _o->classId, 0);
	} else if (isDestructor()) {
		unmapPointer(_o, _o->classId, 0);
		(*SetSmokeObject)(_target, 0);
		free_smokeqyoto_object(_o);
	} else {
		MethodReturnValue r(_smoke, _method, _stack, _retval);
	}
}

void MethodCall::next()
{
	int oldcur = _cur;
	_cur++;
	while(!_called && _cur < _items) {
		Marshall::HandlerFn fn = getMarshallFn(type());
		(*fn)(this);
		_cur++;
	}
	callMethod();
	_cur = oldcur;
}