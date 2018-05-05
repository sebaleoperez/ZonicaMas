using System;
using ZonicaMas.Pages;
using Xamarin.Forms;

namespace ZonicaMas
{
    public partial class App : Application
    {
        public static MasterDetailPage MenuItem { get; set; }
        public static bool IsPlaying { get; set; }

        public App ()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}
