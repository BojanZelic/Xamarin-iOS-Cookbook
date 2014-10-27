
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PageNavApp
{
	public partial class PageNavAppViewController : UIViewController
	{
		UIImageView page1;
		UIImageView page2;
		UIImageView page3;

		public PageNavAppViewController () : base ("PageNavAppViewController", null)
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
			
			// Perform any additional setup after loading the view, typically from a nib
			this.scrollView.DecelerationEnded += ScrollView_DecelerationEnded;
			this.pageControl.ValueChanged += PageControl_ValueChanged;
			this.scrollView.Scrolled += (object sender, EventArgs e) => {
				Console.WriteLine("Scrolled");
			};

			this.scrollView.PagingEnabled = true;
			RectangleF pageFrame = this.scrollView.Frame;

			this.scrollView.ContentSize = new SizeF (pageFrame.Width * 3, pageFrame.Height);
			this.page1 = new UIImageView (pageFrame);
			this.page1.ContentMode = UIViewContentMode.ScaleToFill;
			this.page1.Image = UIImage.FromFile ("AlBhvW8.jpg");

			pageFrame.X += this.scrollView.Frame.Width;
			this.page2 = new UIImageView (pageFrame);
			this.page2.ContentMode = UIViewContentMode.ScaleToFill;
			this.page2.Image = UIImage.FromFile ("bBgttr4.png");

			pageFrame.X += this.scrollView.Frame.Width;
			this.page3 = new UIImageView (pageFrame);
			this.page3.ContentMode = UIViewContentMode.ScaleToFill;
			this.page3.Image = UIImage.FromFile ("QlwxHKW.jpg");

			this.scrollView.AddSubview (this.page1);
			this.scrollView.AddSubview (this.page2);
			this.scrollView.AddSubview (this.page3);
		}

		void PageControl_ValueChanged (object sender, EventArgs e)
		{
			PointF contentOffset = this.scrollView.ContentOffset;

			switch (this.pageControl.CurrentPage) {
			case 0:
				contentOffset.X = this.page1.Frame.X;
				this.scrollView.SetContentOffset (contentOffset, true);
				break;
			case 1:
				contentOffset.X = this.page2.Frame.X;
				this.scrollView.SetContentOffset (contentOffset, true);
				break;
			case 2:
				contentOffset.X = this.page3.Frame.X;
				this.scrollView.SetContentOffset (contentOffset, true);
				break;
			}
		}

		void ScrollView_DecelerationEnded (object sender, EventArgs e)
		{
			float x1 = this.page1.Frame.X;
			float x2 = this.page2.Frame.X;

			float x = this.scrollView.ContentOffset.X;

			if (x == x1) {
				this.pageControl.CurrentPage = 0;
			} else if (x == x2) {
				this.pageControl.CurrentPage = 1;
			} else {
				this.pageControl.CurrentPage = 2;
			}
		}
	}
}

