
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ScrollApp
{
	public partial class ScrollView : UIViewController
	{
		UIImageView imgView;

		public ScrollView () : base ("ScrollView", null)
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

			this.imgView = new UIImageView (UIImage.FromFile ("sXt5N3m.jpg"));

			this.scrollView.ContentSize = this.imgView.Image.Size;
			this.scrollView.ContentOffset = new PointF (200f, 50f);
			this.scrollView.PagingEnabled = true;
			this.scrollView.MinimumZoomScale = 0.25f;
			this.scrollView.MaximumZoomScale = 2f;

			this.scrollView.ViewForZoomingInScrollView = delegate(UIScrollView scrollView) {
				return this.imgView;
			};

			this.scrollView.ZoomScale = 1f;
			this.scrollView.IndicatorStyle = UIScrollViewIndicatorStyle.White;
			this.scrollView.AddSubview (this.imgView);

		}
	}
}

