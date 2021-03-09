using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace Droid.Sample.Poc
{
    [Activity(Label = "SecondaryActivity")]
    public class SecondaryActivity : AppCompatActivity
    {
        TextView tv1, tv2, tv3, tv4;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SupportActionBar.Show();
            SetContentView(Resource.Layout.second_layout);
            tv1 = FindViewById<TextView>(Resource.Id.tv1);
            tv2 = FindViewById<TextView>(Resource.Id.tv2);
            tv3 = FindViewById<TextView>(Resource.Id.tv3);
            tv4 = FindViewById<TextView>(Resource.Id.tv4);

            var bundle = savedInstanceState;
            tv1.Text = Intent.GetStringExtra("name1");
            tv2.Text = Intent.GetStringExtra("name2");
            tv3.Text = Intent.GetStringExtra("name3");
            tv4.Text = Intent.GetStringExtra("name4");
        }
    }
}