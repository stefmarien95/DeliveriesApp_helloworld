using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DeliveriesApp.Droid
{
	[Activity (Label = "DeliveriesApp.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
        EditText naamEditText;
        Button halloButton;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

            naamEditText = FindViewById<EditText>(Resource.Id.nameEditText);
            halloButton = FindViewById<Button>(Resource.Id.helloButton);

            halloButton.Click += HelloButton_Click;
		}

        private void HelloButton_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, $"Hallo {naamEditText.Text}", ToastLength.Long).Show();
        }
    }
}


