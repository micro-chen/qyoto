//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public interface IQIODevice {
			int Flags();
			int Mode();
			int State();
			bool IsDirectAccess();
			bool IsSequentialAccess();
			bool IsCombinedAccess();
			bool IsBuffered();
			bool IsRaw();
			bool IsSynchronous();
			bool IsAsynchronous();
			bool IsTranslated();
			bool IsReadable();
			bool IsWritable();
			bool IsReadWrite();
			bool IsInactive();
			bool IsOpen();
			int Status();
			void ResetStatus();
			bool Open(int mode);
			void Close();
			void Flush();
			ulong Size();
			ulong At();
			bool At(ulong arg1);
			bool AtEnd();
			bool Reset();
			long ReadBlock(string data, long maxlen);
			long WriteBlock(string data, long len);
			long ReadLine(string data, long maxlen);
			long WriteBlock(QByteArray data);
			QByteArray ReadAll();
			int Getch();
			int Putch(int arg1);
			int Ungetch(int arg1);
	}

	[SmokeClass("QIODevice")]
	public class QIODevice : MarshalByRefObject, IQIODevice {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QIODevice(Type dummy) {}
		interface IQIODeviceProxy {
		}

		protected void CreateQIODeviceProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QIODevice), this);
			_interceptor = (QIODevice) realProxy.GetTransparentProxy();
		}
		private QIODevice ProxyQIODevice() {
			return (QIODevice) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QIODevice() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQIODeviceProxy), null);
			_staticInterceptor = (IQIODeviceProxy) realProxy.GetTransparentProxy();
		}
		private static IQIODeviceProxy StaticQIODevice() {
			return (IQIODeviceProxy) _staticInterceptor;
		}

		public QIODevice() : this((Type) null) {
			CreateQIODeviceProxy();
			NewQIODevice();
		}
		[SmokeMethod("QIODevice()")]
		private void NewQIODevice() {
			ProxyQIODevice().NewQIODevice();
		}
		[SmokeMethod("flags() const")]
		public int Flags() {
			return ProxyQIODevice().Flags();
		}
		[SmokeMethod("mode() const")]
		public int Mode() {
			return ProxyQIODevice().Mode();
		}
		[SmokeMethod("state() const")]
		public int State() {
			return ProxyQIODevice().State();
		}
		[SmokeMethod("isDirectAccess() const")]
		public bool IsDirectAccess() {
			return ProxyQIODevice().IsDirectAccess();
		}
		[SmokeMethod("isSequentialAccess() const")]
		public bool IsSequentialAccess() {
			return ProxyQIODevice().IsSequentialAccess();
		}
		[SmokeMethod("isCombinedAccess() const")]
		public bool IsCombinedAccess() {
			return ProxyQIODevice().IsCombinedAccess();
		}
		[SmokeMethod("isBuffered() const")]
		public bool IsBuffered() {
			return ProxyQIODevice().IsBuffered();
		}
		[SmokeMethod("isRaw() const")]
		public bool IsRaw() {
			return ProxyQIODevice().IsRaw();
		}
		[SmokeMethod("isSynchronous() const")]
		public bool IsSynchronous() {
			return ProxyQIODevice().IsSynchronous();
		}
		[SmokeMethod("isAsynchronous() const")]
		public bool IsAsynchronous() {
			return ProxyQIODevice().IsAsynchronous();
		}
		[SmokeMethod("isTranslated() const")]
		public bool IsTranslated() {
			return ProxyQIODevice().IsTranslated();
		}
		[SmokeMethod("isReadable() const")]
		public bool IsReadable() {
			return ProxyQIODevice().IsReadable();
		}
		[SmokeMethod("isWritable() const")]
		public bool IsWritable() {
			return ProxyQIODevice().IsWritable();
		}
		[SmokeMethod("isReadWrite() const")]
		public bool IsReadWrite() {
			return ProxyQIODevice().IsReadWrite();
		}
		[SmokeMethod("isInactive() const")]
		public bool IsInactive() {
			return ProxyQIODevice().IsInactive();
		}
		[SmokeMethod("isOpen() const")]
		public bool IsOpen() {
			return ProxyQIODevice().IsOpen();
		}
		[SmokeMethod("status() const")]
		public int Status() {
			return ProxyQIODevice().Status();
		}
		[SmokeMethod("resetStatus()")]
		public void ResetStatus() {
			ProxyQIODevice().ResetStatus();
		}
		[SmokeMethod("open(int)")]
		public virtual bool Open(int mode) {
			return ProxyQIODevice().Open(mode);
		}
		[SmokeMethod("close()")]
		public virtual void Close() {
			ProxyQIODevice().Close();
		}
		[SmokeMethod("flush()")]
		public virtual void Flush() {
			ProxyQIODevice().Flush();
		}
		[SmokeMethod("size() const")]
		public virtual ulong Size() {
			return ProxyQIODevice().Size();
		}
		[SmokeMethod("at() const")]
		public virtual ulong At() {
			return ProxyQIODevice().At();
		}
		[SmokeMethod("at(QIODevice::Offset)")]
		public virtual bool At(ulong arg1) {
			return ProxyQIODevice().At(arg1);
		}
		[SmokeMethod("atEnd() const")]
		public virtual bool AtEnd() {
			return ProxyQIODevice().AtEnd();
		}
		[SmokeMethod("reset()")]
		public bool Reset() {
			return ProxyQIODevice().Reset();
		}
		[SmokeMethod("readBlock(char*, Q_ULONG)")]
		public virtual long ReadBlock(string data, long maxlen) {
			return ProxyQIODevice().ReadBlock(data,maxlen);
		}
		[SmokeMethod("writeBlock(const char*, Q_ULONG)")]
		public virtual long WriteBlock(string data, long len) {
			return ProxyQIODevice().WriteBlock(data,len);
		}
		[SmokeMethod("readLine(char*, Q_ULONG)")]
		public virtual long ReadLine(string data, long maxlen) {
			return ProxyQIODevice().ReadLine(data,maxlen);
		}
		[SmokeMethod("writeBlock(const QByteArray&)")]
		public long WriteBlock(QByteArray data) {
			return ProxyQIODevice().WriteBlock(data);
		}
		[SmokeMethod("readAll()")]
		public virtual QByteArray ReadAll() {
			return ProxyQIODevice().ReadAll();
		}
		[SmokeMethod("getch()")]
		public virtual int Getch() {
			return ProxyQIODevice().Getch();
		}
		[SmokeMethod("putch(int)")]
		public virtual int Putch(int arg1) {
			return ProxyQIODevice().Putch(arg1);
		}
		[SmokeMethod("ungetch(int)")]
		public virtual int Ungetch(int arg1) {
			return ProxyQIODevice().Ungetch(arg1);
		}
		~QIODevice() {
			DisposeQIODevice();
		}
		public void Dispose() {
			DisposeQIODevice();
		}
		private void DisposeQIODevice() {
			ProxyQIODevice().DisposeQIODevice();
		}


	}
}
