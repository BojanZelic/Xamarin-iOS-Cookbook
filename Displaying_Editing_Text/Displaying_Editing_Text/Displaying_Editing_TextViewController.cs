using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace Displaying_Editing_Text
{
	public partial class Displaying_Editing_TextViewController : UIViewController
	{
		//Have to overwrite these to mark them as 'public' since the ones in designer.cs cannot be changed
		public UIButton GenericButton { get { return genericButton; } set{ genericButton = value; } }
		public UITextView GenericTextView { get { return genericTextView; } set{ genericTextView = value; } }

		public Displaying_Editing_TextViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.


		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			this.genericButton.Enabled = false;
			this.genericButton.TouchUpInside += (object sender, EventArgs e) => {
				this.genericTextView.ResignFirstResponder();
			};

			this.genericTextView.Delegate = new GenericTextViewDelegate (this);
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

