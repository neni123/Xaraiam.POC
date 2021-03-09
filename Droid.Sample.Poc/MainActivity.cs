using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using AndroidX.AppCompat.App;

namespace Droid.Sample.Poc
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText et1, et2, et3, et4;
        Button btn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            et1 = FindViewById<EditText>(Resource.Id.editText1);
            et2 = FindViewById<EditText>(Resource.Id.editText2);
            et3 = FindViewById<EditText>(Resource.Id.editText3);
            et4 = FindViewById<EditText>(Resource.Id.editText4);
            btn = FindViewById<Button>(Resource.Id.button_submit);

            btn.Click += delegate 
            {
                if (!string.IsNullOrEmpty(et1.Text) &&
                    !string.IsNullOrEmpty(et2.Text) &&
                    !string.IsNullOrEmpty(et3.Text) &&
                    !string.IsNullOrEmpty(et4.Text))
                {


                    var intent = new Intent(this, typeof(SecondaryActivity));
                    intent.PutExtra("name1", et1.Text);
                    intent.PutExtra("name2", et2.Text);
                    intent.PutExtra("name3", et3.Text);
                    intent.PutExtra("name4", et4.Text);
                    StartActivity(intent);
                    return;
                }
                Toast.MakeText(this, "Please enter all fields", ToastLength.Long).Show();
            };
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}