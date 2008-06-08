//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {

	using Kimono;
	using System;
	using Qyoto;

	/// <remarks>
	///  SlaveConfig
	///  This class manages the configuration for io-slaves based on protocol
	///  and host. The Scheduler makes use of this class to configure the slave
	///  whenever it has to connect to a new host.
	///  You only need to use this class if you want to override specific
	///  configuration items of an io-slave when the io-slave is used by
	///  your application. 
	///  Normally io-slaves are being configured by "kio_<protocol>rc" 
	///  configuration files. Groups defined in such files are treated as host 
	///  or domain specification. Configuration items defined in a group are 
	///  only applied when the slave is connecting with a host that matches with 
	///  the host and/or domain specified by the group.
	///       See <see cref="ISlaveConfigSignals"></see> for signals emitted by SlaveConfig
	/// </remarks>		<short>    SlaveConfig </short>

	[SmokeClass("KIO::SlaveConfig")]
	public class SlaveConfig : QObject {
 		protected SlaveConfig(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(SlaveConfig), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static SlaveConfig() {
			staticInterceptor = new SmokeInvocationKDE(typeof(SlaveConfig), null);
		}
		/// <remarks>
		///  Configure slaves of type <code>protocol</code> by setting <code>key</code> to <code>value.</code>
		///  If <code>host</code> is specified the configuration only applies when dealing
		///  with <code>host.</code>
		///  Changes made to the slave configuration only apply to slaves
		///  used by the current process.
		///          </remarks>		<short>    Configure slaves of type <code>protocol</code> by setting <code>key</code> to <code>value.</code></short>
		public void SetConfigData(string protocol, string host, string key, string value) {
			interceptor.Invoke("setConfigData$$$$", "setConfigData(const QString&, const QString&, const QString&, const QString&)", typeof(void), typeof(string), protocol, typeof(string), host, typeof(string), key, typeof(string), value);
		}
		/// <remarks>
		///  Configure slaves of type <code>protocol</code> with <code>config.</code>
		///  If <code>host</code> is specified the configuration only applies when dealing
		///  with <code>host.</code>
		///  Changes made to the slave configuration only apply to slaves
		///  used by the current process.
		///          </remarks>		<short>    Configure slaves of type <code>protocol</code> with <code>config.</code></short>
		public void SetConfigData(string protocol, string host, KIO.MetaData config) {
			interceptor.Invoke("setConfigData$$#", "setConfigData(const QString&, const QString&, const KIO::MetaData&)", typeof(void), typeof(string), protocol, typeof(string), host, typeof(KIO.MetaData), config);
		}
		/// <remarks>
		///  Query slave configuration for slaves of type <code>protocol</code> when
		///  dealing with <code>host.</code>
		///          </remarks>		<short>    Query slave configuration for slaves of type <code>protocol</code> when  dealing with <code>host.</code></short>
		public KIO.MetaData ConfigData(string protocol, string host) {
			return (KIO.MetaData) interceptor.Invoke("configData$$", "configData(const QString&, const QString&)", typeof(KIO.MetaData), typeof(string), protocol, typeof(string), host);
		}
		/// <remarks>
		///  Query a specific configuration key for slaves of type <code>protocol</code> when
		///  dealing with <code>host.</code>
		///          </remarks>		<short>    Query a specific configuration key for slaves of type <code>protocol</code> when  dealing with <code>host.</code></short>
		public string ConfigData(string protocol, string host, string key) {
			return (string) interceptor.Invoke("configData$$$", "configData(const QString&, const QString&, const QString&)", typeof(string), typeof(string), protocol, typeof(string), host, typeof(string), key);
		}
		/// <remarks>
		///  Undo any changes made by calls to setConfigData.
		///          </remarks>		<short>    Undo any changes made by calls to setConfigData.</short>
		public void Reset() {
			interceptor.Invoke("reset", "reset()", typeof(void));
		}
		public SlaveConfig() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("SlaveConfig", "SlaveConfig()", typeof(void));
		}
		public static KIO.SlaveConfig Self() {
			return (KIO.SlaveConfig) staticInterceptor.Invoke("self", "self()", typeof(KIO.SlaveConfig));
		}
		protected new ISlaveConfigSignals Emit {
			get { return (ISlaveConfigSignals) Q_EMIT; }
		}
	}

	public interface ISlaveConfigSignals : IQObjectSignals {
		/// <remarks>
		///  This signal is raised when a slave of type <code>protocol</code> deals
		///  with <code>host</code> for the first time.
		///  Your application can use this signal to make some last minute
		///  configuration changes with setConfigData based on the
		///  host.
		///          </remarks>		<short>    This signal is raised when a slave of type <code>protocol</code> deals  with <code>host</code> for the first time.</short>
		[Q_SIGNAL("void configNeeded(const QString&, const QString&)")]
		void ConfigNeeded(string protocol, string host);
	}
}