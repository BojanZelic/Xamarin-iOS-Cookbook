using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using Foundation;
using UIKit;

namespace ProgressApp
{
	public partial class ProgressAppViewController : UIViewController
	{
		UILabel labelStatus;
		UIButton buttonStartProgress;
		UIProgressView progressView;
		float incrementBy = 0f;

		public ProgressAppViewController (IntPtr handle) : base (handle)
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

			this.labelStatus = new UILabel (new RectangleF (60f, 60f, 200f, 50f));
			this.labelStatus.AdjustsFontSizeToFitWidth = true;

			this.buttonStartProgress = UIButton.FromType (UIButtonType.System);
			this.buttonStartProgress.Frame = new RectangleF (60f, 400f, 200f, 40f);

			this.buttonStartProgress.SetTitle ("Tap to start progress!", UIControlState.Normal);

			this.buttonStartProgress.TouchUpInside += (object sender, EventArgs e) => {
				//Disable the button
				this.buttonStartProgress.Enabled = false;
				this.progressView.Progress = 0f;

				//Start a progress
				Task.Factory.StartNew(this.StartProgress);
			};

			this.progressView = new UIProgressView (new RectangleF (60f, 200f, 200f, 50f));

			this.progressView.Progress = 0f;

			// Set the progress increment value
			// for 10 items
			this.incrementBy = 1f / 10f;

			this.View.AddSubview (this.labelStatus);
			this.View.AddSubview (this.buttonStartProgress);
			this.View.AddSubview (this.progressView);
		}

		public void StartProgress()
		{
			float currentProgress = 0f;
			while (currentProgress < 1f) {
				Thread.Sleep (1000);
				this.InvokeOnMainThread (delegate {
					//Advance the progress
					this.progressView.Progress += this.incrementBy;
					currentProgress = this.progressView.Progress;

					//Set the label text
					this.labelStatus.Text = string.Format("Current Value: {0}", Math.Round((double) this.progressView.Progress, 2));

					if (currentProgress >= 1f)
					{
						this.labelStatus.Text = "Progress Completed";
						this.buttonStartProgress.Enabled = true;
					}
				});
			}
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

