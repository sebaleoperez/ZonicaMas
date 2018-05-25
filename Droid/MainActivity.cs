using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Firebase.Analytics;

namespace ZonicaMas.Droid
{
    [Activity(Label = "ZonicaMas.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            
            var firebase = FirebaseAnalytics.GetInstance(this);
            firebase.LogEvent(FirebaseAnalytics.Event.AppOpen, null);

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
        }
    }
}
