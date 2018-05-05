using System;
using System.Collections.Generic;
using ZonicaMas.Interfaces;
using Xamarin.Forms;

namespace ZonicaMas.Pages
{
    public partial class SharePage : ContentPage
    {
        public SharePage()
        {
            InitializeComponent();

            lblWP.Text = "Agendá nuestro número y escribinos: \n11-2262-7728";
        }

        private void Whatsapp_Tapped(object sender, EventArgs e)
        {
            var uri = new Uri("tel:1122627728");
            Device.OpenUri(uri);
        }

        private void Share_Tapped(object sender, EventArgs e)
        {
            DependencyService.Get<ISocial>().ShareLink("Estoy escuchando Zonica+!! www.zonica.com.ar");
        }
    }
}
