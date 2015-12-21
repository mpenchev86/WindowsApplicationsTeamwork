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

            this.sportViewGrid1.SportItems = new[]
            {
                new SportButtonContent()
                {
                    SportType = new SportTypeViewModel()
                    {
                        StackRow = 0,
                        StackCol = 0,
                        Name = "Football",
                        ImagePath = "http://weknowyourdreams.com/images/football/football-06.jpg"
                    },
                    DestinationPageType = typeof(LocationsPage)
                }
            };
            this.sportViewGrid2.SportItems = new[]
            {
                new SportButtonContent()
                {
                    SportType = new SportTypeViewModel()
                    {
                        StackRow = 0,
                        StackCol = 1,
                        Name = "Basketball",
                        ImagePath = "http://www.jumpstartsports.com/upload/images/Radnor_Basketball/448650-basketball__mario_sports_mix_.png"
                    },
                    DestinationPageType = typeof(LocationsPage)
                }
            };
            this.sportViewGrid3.SportItems = new[]
            {
                new SportButtonContent()
                {
                    SportType = new SportTypeViewModel()
                    {
                        StackRow = 1,
                        StackCol = 0,
                        Name = "Volleyball",
                        ImagePath = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQ3CraG3oZonu4PKjedU-PbSy9WQefot0hNa0B2rGxOkTZatYNU"
                    },
                    DestinationPageType = typeof(LocationsPage)
                }
            };
            this.sportViewGrid4.SportItems = new[]
            {
                new SportButtonContent()
                {
                    SportType = new SportTypeViewModel()
                    {
                        StackRow = 1,
                        StackCol = 1,
                        Name = "Handball",
                        ImagePath = "http://handballcab.com.ar/css/images/logoHandball.png"
                    },
                    DestinationPageType = typeof(LocationsPage)
                }
            };
        }
       
        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LocationsPage));
        }
    }
}
