using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace LonelyMe.Droid.App
{
    public class SignupResultsAdapter : BaseAdapter
    {
        readonly Activity _activity;
        readonly List<string> _socialAccounts;

        public SignupResultsAdapter(Activity defaultActivity, List<string> socialAccounts)
        {
            _activity = defaultActivity;
            _socialAccounts = socialAccounts;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = (convertView
                        ?? _activity.LayoutInflater.Inflate(
                            Resource.Layout.SignUpResults, parent, false)
                       ) as LinearLayout;

            view.FindViewById<TextView>(Resource.Id.message_text).Text = "Created Account For '" +  _socialAccounts[position] + "'";
            return view;
        }

        public override Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override int Count
        {
            get { return _socialAccounts.Count; }
        }
    }
}