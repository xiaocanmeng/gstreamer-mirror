// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;

	public delegate void OnMessageDataEventHandler(object o, OnMessageDataEventArgs args);

	public class OnMessageDataEventArgs : GLib.SignalArgs {
		public GLib.Bytes Data{
			get {
				return (GLib.Bytes) Args [0];
			}
		}

	}
}