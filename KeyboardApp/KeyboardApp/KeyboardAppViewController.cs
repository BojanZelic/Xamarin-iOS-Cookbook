using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace KeyboardApp
{
	public partial class KeyboardAppViewController : UIViewController
	{
		private NSObject kbdWillShow, kbdDidHide;

		public KeyboardAppViewController (IntPtr handle) : base (handle)
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

			this.emailField.KeyboardType = UIKeyboardType.EmailAddress;
			this.emailField.ReturnKeyType = UIReturnKeyType.Done;

			//Subscribe to the notification center and add a handler to it. 
			//Notification center can also be accessed by NSNotificationCenter.DefaultCenter
			this.kbdWillShow = UIKeyboard.Notifications.ObserveDidShow ((s, e) => {
				RectangleF kbdBounds = (RectangleF) e.FrameEnd;
				RectangleF textFrame = (RectangleF) this.emailField.Frame;
				textFrame.Y -= kbdBounds.Height;
				this.emailField.Frame = textFrame;
			});
				

			this.kbdDidHide = UIKeyboard.Notifications.ObserveDidHide ((s, e) => {
				//For some reason this actions actually will hide the textField. Not sure how.
				//But iOS seems to automatically reset the position.
//				RectangleF kbdBounds = (RectangleF) e.FrameEnd;
//				RectangleF textFrame = (RectangleF) this.emailField.Frame;
//				textFrame.Y += kbdBounds.Height;
//				this.emailField.Frame = textFrame;
			});

			this.emailField.ShouldReturn = delegate(UITextField textField){
				return textField.ResignFirstResponder();
			};

			//Remove the observer if needed
			//NSNotificationCenter.DefaultCenter.RemoveObserver (this.kbdWillShow);

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

