using ZonicaMas.Helpers;
using Xamarin.Forms;

namespace ZonicaMas.Controls
{
    public partial class MenuItem : Grid
    {
        public string IconSource
        {
            get { return this.Icon.Source.ToString(); }
            set { this.Icon.Source = value; }
        }

        public string Text
        {
            get { return this.Label.Text; }
            set { this.Label.Text = value; }
        }

        public int PageId { get; set; }

        public MenuItem()
        {
            InitializeComponent();

            GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => PageHelper.Navigate(PageId)),
                NumberOfTapsRequired = 1
            });
        }
    }
}
