namespace BeastApplication.Pages
{
    using BeastApplication.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices.WindowsRuntime;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Controls.Primitives;
    using Windows.UI.Xaml.Data;
    using Windows.UI.Xaml.Input;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Navigation;
    using BeastApplication;
    using Controls;

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.navigationView.NavItems = new[]
            {
                new AppBarButtonContent()
                {
                    Title = "Next",
                    DestinationPageType = typeof(LocationsPage)
                }
            };

            this.sportViewGrid.SportItems = new[]
            {
                new SportButtonContent()
                {
                    SportType = new SportTypeViewModel()
                    {
                        Name = "Football",
                        ImagePath = "http://weknowyourdreams.com/images/football/football-06.jpg"
                    },
                    DestinationPageType = typeof(LocationsPage)
                },
                new SportButtonContent()
                {
                    SportType = new SportTypeViewModel()
                    {
                        Name = "Basketball",
                        ImagePath = "http://www.jumpstartsports.com/upload/images/Radnor_Basketball/448650-basketball__mario_sports_mix_.png"
                    },
                    DestinationPageType = typeof(LocationsPage)
                },
                new SportButtonContent()
                {
                    SportType = new SportTypeViewModel()
                    {
                        Name = "Volleyball",
                        ImagePath = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQ3CraG3oZonu4PKjedU-PbSy9WQefot0hNa0B2rGxOkTZatYNU"
                    },
                    DestinationPageType = typeof(LocationsPage)
                },
                new SportButtonContent()
                {
                    SportType = new SportTypeViewModel()
                    {
                        Name = "Handball",
                        ImagePath = "http://handballcab.com.ar/css/images/logoHandball.png"
                    },
                    DestinationPageType = typeof(LocationsPage)
                }
            };
        }

        public double WindowWidth
        {
            get { return (this.Frame.Width) / 2; }
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LocationsPage));
        }
    }
}
