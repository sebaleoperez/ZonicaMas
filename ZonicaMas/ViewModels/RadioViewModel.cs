using ZonicaMas.Interfaces;
using Xamarin.Forms;
using System.Threading.Tasks;
using ZonicaMas.Helpers;
using System;
namespace ZonicaMas.ViewModels
{
    class RadioViewModel : BaseViewModel
    {
        public bool PlayDisplayed { get { return !isPlaying && !radioIsLoading; } }
        public bool StopDisplayed { get { return isPlaying && !radioIsLoading; } }

        private string programUrl;
        public string ProgramUrl
        {
            get { return programUrl; }
            set
            {
                programUrl = value;
                OnPropertyChanged("ProgramUrl");
            }
        }

        private string programName;

        public string ProgramName
        {
            get { return "Estás escuchando: " + programName; }
            set
            {
                programName = value;
                OnPropertyChanged("ProgramName");
            }
        }


        private bool isPlaying = App.IsPlaying;
        public bool IsPlaying
        {
            get { return isPlaying; }
            set
            {
                isPlaying = value;
                OnPropertyChanged("PlayDisplayed");
                OnPropertyChanged("StopDisplayed");
                OnPropertyChanged("IsPlaying");
                App.IsPlaying = value;
            }
        }

        private bool radioIsLoading;

        public bool RadioIsLoading
        {
            get { return radioIsLoading; }
            set
            {
                radioIsLoading = value;
                OnPropertyChanged("PlayDisplayed");
                OnPropertyChanged("StopDisplayed");
                OnPropertyChanged("RadioIsLoading");
            }
        }

        public string EstasEscuchando { get; set; }
        public string ProgramSource { get; set; }

        public async Task LoadAsync()
        {
            try
            {
                ProgramUrl = await WebDataHelper.GetProgramLink();
            }
            catch (Exception)
            {
                ProgramName = programName + "\nError al mostrar la imágen del programa";
            }

            try
            {
                ProgramName = await WebDataHelper.GetProgramName();
            }
            catch (Exception)
            {
                ProgramName = programName + "Error al mostrar el nombre del programa";
            }
        }

        public async Task Play()
        {
            RadioIsLoading = true;

            await Task.Run(() =>
                DependencyService.Get<IStreaming>().Play());
            IsPlaying = true;

            RadioIsLoading = false;
        }

        public async Task Stop()
        {
            RadioIsLoading = true;

            await Task.Run(() =>
                DependencyService.Get<IStreaming>().Stop());
            IsPlaying = false;

            RadioIsLoading = false;
        }

        public async Task Pause()
        {
            RadioIsLoading = true;

            await Task.Run(() =>
                DependencyService.Get<IStreaming>().Pause());
            IsPlaying = false;

            RadioIsLoading = false;
        }
    }
}
