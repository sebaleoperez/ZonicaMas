using Foundation;
using UIKit;
using Xamarin.Forms;
using ZonicaMas.Interfaces;

[assembly: Dependency(typeof(ZonicaMas.iOS.ShareService))]
namespace ZonicaMas.iOS
{
	public class ShareService : ISocial
	{
        public void ShareLink(string Text)
        {
            var window = UIApplication.SharedApplication.KeyWindow;
            var rootViewController = window.RootViewController;

            var activityViewController = new UIActivityViewController(new NSString[] { new NSString(Text) }, null);

            rootViewController.PresentViewController(activityViewController, true, null);
        }
    }
}
