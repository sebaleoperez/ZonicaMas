using Firebase.Analytics;
using Foundation;
using UIKit;

namespace ZonicaMas.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
			global::Xamarin.Forms.Forms.Init();

            Firebase.Core.App.Configure();
            Analytics.LogEvent(EventNamesConstants.AppOpen, null);

            LoadApplication(new App());
         
            return base.FinishedLaunching(app, options);
        }
    }
}
