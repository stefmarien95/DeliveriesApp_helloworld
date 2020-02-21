using System;

using UIKit;

namespace DeliveriesApp.iOS
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

            helloButton.TouchUpInside += HelloButton_TouchUpInside;
		}

        private void HelloButton_TouchUpInside(object sender, EventArgs e)
        {
            var alert = UIAlertController.Create("Hallo", $"Hallo {nameTextField.Text}", UIAlertControllerStyle.Alert);

            var cancelAction = UIAlertAction.Create("Hallo", UIAlertActionStyle.Cancel, null);

            alert.AddAction(cancelAction);

            PresentViewController(alert, true, null);
        }

        public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			
		}
	}
}

