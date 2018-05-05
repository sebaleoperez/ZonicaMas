using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ZonicaMas.Pages
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Master = new MenuPage();
            Detail = new NavigationPage(new RadioPage())
            {
                BarTextColor = Color.Black
            };

            App.MenuItem = this;
        }
    }
}
