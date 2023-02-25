using TnyavnToSpotifySongDownloader.Services;
using TnyavnToSpotifySongDownloader.Views;
using System.Windows;


namespace TnyavnToSpotifySongDownloader
{

    public partial class MainWindow : System.Windows.Window
    {
        SpotifyService spotifyService;

        public MainWindow()
        {
            InitializeComponent();

            // initializing the spotify service used to make HTTP calls
            spotifyService = new SpotifyService();

            NavigationFrame.Navigate(new SearchView());
        }

        private void NavigationFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
