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

namespace Displaying_Editing_Text
{
	[Register ("Displaying_Editing_TextViewController")]
	partial class Displaying_Editing_TextViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton genericButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView genericTextView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (genericButton != null) {
				genericButton.Dispose ();
				genericButton = null;
			}
			if (genericTextView != null) {
				genericTextView.Dispose ();
				genericTextView = null;
			}
		}
	}
}
