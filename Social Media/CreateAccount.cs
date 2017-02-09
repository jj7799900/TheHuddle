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
    [Activity(Label = "CreateAccount")]
    class CreateAccount : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CreateAccountLayout);
            ActionBar.Hide();

            Button createBtn = FindViewById<Button>(Resource.Id.button1);
            createBtn.Click += CreateBtn_Click;

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Intent mainMenuInt = new Intent(this, typeof(MainMenu));
            this.StartActivity(mainMenuInt);
        }
    }
}