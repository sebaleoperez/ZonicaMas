using System;
using System.Threading.Tasks;
using ZonicaMas.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZonicaMas.Pages
{
    public partial class RadioPage : ContentPage
    {
        private RadioViewModel ViewModel { get { return (RadioViewModel)BindingContext; } }

        public RadioPage()
        {
            InitializeComponent();
            BindingContext = new RadioViewModel();

            ViewModel.LoadAsync().ConfigureAwait(false);
            SetRefresh();
        }


        private async void Play_Tapped(object sender, EventArgs e)
        {
            try
            {
                await ViewModel.Play();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error!", "Ha ocurrido un error al reproducir la radio. Estamos trabajando para solucionarlo.", "OK");
                ViewModel.RadioIsLoading = false;
            }
        }

        private async void Stop_Tapped(object sender, EventArgs e)
        {
            try
            {
                await ViewModel.Stop();
            }
            catch (Exception)
            {
                await DisplayAlert("Error!", "Ha ocurrido un error al reproducir la radio. Estamos trabajando para solucionarlo.", "OK");
                ViewModel.RadioIsLoading = false;
            }
        }

        private async void Pause_Tapped(object sender, EventArgs e)
        {
            try
            {
                await ViewModel.Pause();
            }
            catch (Exception)
            {
                await DisplayAlert("Error!", "Ha ocurrido un error al reproducir la radio. Estamos trabajando para solucionarlo.", "OK");
                ViewModel.RadioIsLoading = false;
            }
        }

        //TODO: REDES SOCIALES!!!
        private void Facebook_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/zonicaradio"));
        }

        private void Twitter_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://twitter.com/radiozonica"));
        }

        private void Instagram_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.instagram.com/radiozonica/"));
        }

        private void Youtube_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.youtube.com/channel/UCKPqqHlEtPfJ-WOePpTUFPw"));
        }

        private void Soundcloud_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.mixcloud.com/GrupoZonica/"));
        }

        private async void SetRefresh()
        {
            try
            {
                var ms = ((30 - (DateTime.Now.Minute % 30)) + 1) * 60000;
                await Task.Delay(ms);
                await ViewModel.LoadAsync();

                Device.StartTimer(TimeSpan.FromMinutes(30), () =>
                {
                    ViewModel.LoadAsync().ConfigureAwait(false);
                    return true;
                });
            }
            catch (Exception)
            {
                await DisplayAlert("Error!", "Ha ocurrido un error al reproducir la radio. Estamos trabajando para solucionarlo.", "OK");
            }
        }
    }
}
