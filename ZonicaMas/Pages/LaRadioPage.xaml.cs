using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ZonicaMas.Pages
{
    public partial class LaRadioPage : ContentPage
    {
        public LaRadioPage()
        {
            InitializeComponent();

            lblText.Text = "Zonica+ es una nueva radio del Grupo Radial OnLine Zonica. \n" +
                "En nuestra aplicación podrás escuchar 24hs nuestra programación. \n\n" +
                "Con esta emisora sumamos a nuestra plataforma: \n" +
                "+ actualidad, + política, + cultura, + educación, + deporte, + noticias, + entrevistas. ";
        }

        private void Url_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.zonica.com.ar"));
        }
    }
}
