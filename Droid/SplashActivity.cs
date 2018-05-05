using Android.App;
using Android.OS;
using Android.Content.PM;

namespace ZonicaMas.Droid
{
    [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestedOrientation = ScreenOrientation.Portrait;

            StartActivity(typeof(MainActivity));
        }
    }
}
