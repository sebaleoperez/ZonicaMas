using ZonicaMas.Interfaces;
using Android.Media;
using ZonicaMas.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(StreamingService))]
namespace ZonicaMas.Droid
{
    public class StreamingService : IStreaming
    {
        MediaPlayer player;
        string dataSource = "rtsp://streamlky.alsolnet.com/zonicamas/zonicamas.stream";

        bool IsPrepared = false;

        public void Play()
        {
            if (!IsPrepared)
            {
                if (player == null)
                    player = new MediaPlayer();
                else
                    player.Reset();

                player.SetDataSource(dataSource);
                player.PrepareAsync();
            }

            player.Prepared += (sender, args) =>
            {
                player.Start();
                IsPrepared = true;
            };
        }

        public void Pause()
        {
            player.Pause();
        }

        public void Stop()
        {
            player.Stop();
            IsPrepared = false;
        }
    }
}