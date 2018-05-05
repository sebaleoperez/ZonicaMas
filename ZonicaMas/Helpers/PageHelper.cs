using Xamarin.Forms;
using ZonicaMas.Pages;
namespace ZonicaMas.Helpers
{
    class PageHelper
    {
        public static void Navigate(int pageId)
        {
            var page = GetPage(pageId);
            var navigationPage = new NavigationPage(page);

            navigationPage.BarBackgroundColor = Color.FromHex("#f4f4f4");
            navigationPage.BarTextColor = Color.Black;

            App.MenuItem.IsPresented = false;
            App.MenuItem.Detail = navigationPage;
        }

        private static Page GetPage(int id)
        {
            switch (id)
            {
                case 0:
                    return new RadioPage();
                case 1:
                    return new LaRadioPage();
                case 2:
                    return new SharePage();
                default:
                    return null;
            }
        }
    }
}
