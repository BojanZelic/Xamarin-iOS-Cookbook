using System;
using UIKit;

namespace Displaying_Editing_Text
{
	public class GenericTextViewDelegate : UITextViewDelegate
	{
		Displaying_Editing_TextViewController parentController;

		public GenericTextViewDelegate (Displaying_Editing_TextViewController parentController)
		{
			this.parentController = parentController;
		}

		public override void EditingEnded (UITextView textView)
		{
			parentController.GenericButton.SetTitle ("Done Editing", UIControlState.Normal);
		}

		public override void EditingStarted (UITextView textView)
		{
			this.parentController.GenericButton.SetTitle("Editing", UIControlState.Normal);
		}

		public override void Changed (UITextView textView)
		{
			Console.WriteLine ("Text Changed");
		}
	}
}

