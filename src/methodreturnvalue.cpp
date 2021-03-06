/***************************************************************************
    begin                : Wed Jun 16 2004
    copyright            : (C) 2004 by Richard Dale
    email                : Richard_Dale@tipitina.demon.co.uk
 ***************************************************************************/

/***************************************************************************
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU Lesser General Public License as        *
 *   published by the Free Software Foundation; either version 2 of the    *
 *   License, or (at your option) any later version.                       *
 *                                                                         *
 ***************************************************************************/

#include "methodreturnvalue.h"
#include "qyoto.h"

namespace Qyoto {

MethodReturnValue::MethodReturnValue(Smoke *smoke, Smoke::Index method, Smoke::Stack stack, Smoke::StackItem * retval) :
	_smoke(smoke), _method(method), _retval(retval), _stack(stack)
{
	Marshall::HandlerFn fn = getMarshallFn(type());
	(*fn)(this);
}

void
MethodReturnValue::unsupported()
{
	qFatal("Cannot handle '%s' as return-type of %s::%s",
	       type().name(),
	       strcmp(_smoke->className(method().classId), "QGlobalSpace") == 0 ? "" : _smoke->className(method().classId),
	       _smoke->methodNames[method().name] );
}

void
MethodReturnValue::next() {}

}
