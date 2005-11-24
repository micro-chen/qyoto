//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	///<remarks>*************************************************
	/// $Id: qt/qsocketnotifier.h   3.3.4   edited May 27 2003 $
	///
	///* Definition of QSocketNotifier class
	///
	///* Created : 951114
	///
	///* Copyright (C) 1992-2000 Trolltech AS.  All rights reserved.
	///
	///* This file is part of the kernel module of the Qt GUI Toolkit.
	///
	///* This file may be distributed under the terms of the Q Public License
	/// as defined by Trolltech AS of Norway and appearing in the file
	/// LICENSE.QPL included in the packaging of this file.
	///
	///* This file may be distributed and/or modified under the terms of the
	/// GNU General Public License version 2 as published by the Free Software
	/// Foundation and appearing in the file LICENSE.GPL included in the
	/// packaging of this file.
	///
	///* Licensees holding valid Qt Enterprise Edition or Qt Professional Edition
	/// licenses may use this file in accordance with the Qt Commercial License
	/// Agreement provided with the Software.
	///
	///* This file is provided AS IS with NO WARRANTY OF ANY KIND, INCLUDING THE
	/// WARRANTY OF DESIGN, MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE.
	///
	///* See http://www.trolltech.com/pricing.html or email sales@trolltech.com for
	///   information about Qt Commercial License Agreements.
	/// See http://www.trolltech.com/qpl/ for QPL licensing information.
	/// See http://www.trolltech.com/gpl/ for GPL licensing information.
	///
	///* Contact info@trolltech.com if any conditions of this licensing are
	/// not clear to you.
	///
	///********************************************** See <see cref="IQSocketNotifierSignals"></see> for signals emitted by QSocketNotifier
	///</remarks>		<short>                                                                               $Id: qt/qsocketnotifier.</short>

	public class QSocketNotifier : QObject, IDisposable {
 		protected QSocketNotifier(Type dummy) : base((Type) null) {}
		interface IQSocketNotifierProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQSocketNotifierProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSocketNotifier), this);
			_interceptor = (QSocketNotifier) realProxy.GetTransparentProxy();
		}
		private QSocketNotifier ProxyQSocketNotifier() {
			return (QSocketNotifier) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSocketNotifier() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSocketNotifierProxy), null);
			_staticInterceptor = (IQSocketNotifierProxy) realProxy.GetTransparentProxy();
		}
		private static IQSocketNotifierProxy StaticQSocketNotifier() {
			return (IQSocketNotifierProxy) _staticInterceptor;
		}

		enum E_Type {
			Read = 0,
			Write = 1,
			Exception = 2,
		}
		public new virtual QMetaObject MetaObject() {
			return ProxyQSocketNotifier().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQSocketNotifier().ClassName();
		}
		public QSocketNotifier(int socket, int arg2, QObject parent, string name) : this((Type) null) {
			CreateQSocketNotifierProxy();
			NewQSocketNotifier(socket,arg2,parent,name);
		}
		private void NewQSocketNotifier(int socket, int arg2, QObject parent, string name) {
			ProxyQSocketNotifier().NewQSocketNotifier(socket,arg2,parent,name);
		}
		public QSocketNotifier(int socket, int arg2, QObject parent) : this((Type) null) {
			CreateQSocketNotifierProxy();
			NewQSocketNotifier(socket,arg2,parent);
		}
		private void NewQSocketNotifier(int socket, int arg2, QObject parent) {
			ProxyQSocketNotifier().NewQSocketNotifier(socket,arg2,parent);
		}
		public QSocketNotifier(int socket, int arg2) : this((Type) null) {
			CreateQSocketNotifierProxy();
			NewQSocketNotifier(socket,arg2);
		}
		private void NewQSocketNotifier(int socket, int arg2) {
			ProxyQSocketNotifier().NewQSocketNotifier(socket,arg2);
		}
		public int Socket() {
			return ProxyQSocketNotifier().Socket();
		}
		public int Type() {
			return ProxyQSocketNotifier().Type();
		}
		public bool IsEnabled() {
			return ProxyQSocketNotifier().IsEnabled();
		}
		public virtual void SetEnabled(bool arg1) {
			ProxyQSocketNotifier().SetEnabled(arg1);
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQSocketNotifier().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQSocketNotifier().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQSocketNotifier().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQSocketNotifier().TrUtf8(arg1);
		}
		public new bool Event(QEvent arg1) {
			return ProxyQSocketNotifier().Event(arg1);
		}
		~QSocketNotifier() {
			ProxyQSocketNotifier().Dispose();
		}
		public new void Dispose() {
			ProxyQSocketNotifier().Dispose();
		}
	}

	public interface IQSocketNotifierSignals {
		void Activated(int socket);
	}
}
