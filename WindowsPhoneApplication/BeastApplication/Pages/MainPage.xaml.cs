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
            //this.DataContext = new MainPageViewModel();
            this.navigationView.NavItems = new[]
            {
                new AppBarButtonContent()
                {
                    Title = "Next",
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
