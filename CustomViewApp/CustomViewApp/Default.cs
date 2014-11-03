
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace CustomViewApp
{
	public partial class Default : UIViewController
	{
		public Default () : base ("Default", null)
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
			//Reflects all instances thoughout the app
			UILabel.Appearance.BackgroundColor = UIColor.Blue;
			var labelStyle = UILabel.AppearanceWhenContainedIn (typeof(MyView));
			labelStyle.BackgroundColor = UIColor.Green;

		}
	}
}

