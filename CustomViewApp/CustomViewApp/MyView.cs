using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using System.Drawing;

namespace CustomViewApp
{
	[Register("MyView")]
	public class MyView : UIView
	{
		UILabel labelStatus;

		public MyView (IntPtr handle) :base(handle)
		{
			this.Initialize ();
		}

		public MyView (RectangleF handle) :base(handle)
		{
			this.Initialize ();
		}

		public void Initialize()
		{
			this.BackgroundColor = UIColor.LightGray;
			this.labelStatus = new UILabel (new RectangleF (0f, 400f, this.Frame.Width, 60f));
			this.labelStatus.TextAlignment = UITextAlignment.Center;
			this.labelStatus.BackgroundColor = UIColor.DarkGray;
			this.AddSubview (labelStatus);
		}

		public override void TouchesMoved (NSSet touches, UIEvent evt)
		{
			base.TouchesMoved (touches, evt);

			UITouch touch = (UITouch)touches.AnyObject;

			PointF touchLocation = touch.LocationInView (this);
			this.labelStatus.Text = String.Format ("{0}, {1}", touchLocation.X, touchLocation.Y);
		}
	}
}

