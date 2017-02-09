using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Social_Media
{
    [Activity(Label = "SignIn")]
    class SignInCls : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SignInLayout);
            ActionBar.Hide();

            Button mainMenuBtn = FindViewById<Button>(Resource.Id.button1);
            mainMenuBtn.Click += MainMenuBtn_Click;
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Intent mainMenuInt = new Intent(this, typeof(MainMenu));
            this.StartActivity(mainMenuInt);
        }
    }
}