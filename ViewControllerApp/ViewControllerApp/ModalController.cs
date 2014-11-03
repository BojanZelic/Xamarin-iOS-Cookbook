
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ViewControllerApp
{
	public partial class ModalController : UIViewController
	{
		public ModalController () : base ("ModalController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			this.dismissButton.TouchUpInside += async (object sender, EventArgs e) => {
				this.DismissViewControllerAsync(true);
			};
		}
	}
}

