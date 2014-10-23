// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace KeyboardApp
{
	[Register ("KeyboardAppViewController")]
	partial class KeyboardAppViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField emailField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (emailField != null) {
				emailField.Dispose ();
				emailField = null;
			}
		}
	}
}
