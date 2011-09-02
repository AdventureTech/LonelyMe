using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Widget;
using Android.OS;
using LonelyMe.Domain;

namespace LonelyMe.Droid.App
{
    [Activity(Label = "Lonely Me :(", MainLauncher = true, Icon = "@drawable/icon")]
    public class DefaultActivity : Activity
    {
        Registration _registration;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            _registration = new Registration();

            FindViewById<Button>(Resource.Id.signup).Click += delegate
                {
                    var account = _registration.Register(FindViewById<EditText>(Resource.Id.username).Text,
                                                         FindViewById<EditText>(Resource.Id.password).Text);
                    
                    var dialog = ProgressDialog.Show(this, "Working", "Creating Account..");

                    RunOnUiThread(delegate
                        {
                            FindViewById<ListView>(Resource.Id.signup_results).Adapter = new SignupResultsAdapter(this, account.SocialAccounts);
                        });

                    dialog.Hide();

                };
        }

    }
}

