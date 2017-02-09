using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Social_Media
{
    [Activity(Label = "Social_Media", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout 
            ActionBar.Hide();
            SetContentView(Resource.Layout.Main);

            Button signUp = FindViewById<Button>(Resource.Id.button1);
            signUp.Click += SignUp_Click;

            Button createBtn = FindViewById<Button>(Resource.Id.button2);
            createBtn.Click += CreateBtn_Click;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Intent createInt = new Intent(this, typeof(CreateAccount));
            this.StartActivity(createInt);
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Intent mainInt = new Intent(this, typeof(SignInCls));
            this.StartActivity(mainInt);
        }
    }
}

