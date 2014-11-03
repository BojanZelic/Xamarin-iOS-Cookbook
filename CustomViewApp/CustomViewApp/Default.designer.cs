// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace CustomViewApp
{
	[Register ("Default")]
	partial class Default
	{
		[Outlet]
		MonoTouch.UIKit.UILabel myLabel { get; set; }

		[Outlet]
		CustomViewApp.MyView myView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (myView != null) {
				myView.Dispose ();
				myView = null;
			}

			if (myLabel != null) {
				myLabel.Dispose ();
				myLabel = null;
			}
		}
	}
}
