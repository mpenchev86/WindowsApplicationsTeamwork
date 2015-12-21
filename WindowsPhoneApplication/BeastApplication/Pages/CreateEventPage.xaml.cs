using BeastApplication.Controls;
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
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BeastApplication.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateEventPage : Page
    {
        public CreateEventPage()
        {
            this.InitializeComponent();

            //this.navigationView.NavItems = new[]
            //{
            //    new AppBarButtonContent()
            //    {
            //        Title = "Back",
            //        DestinationPageType = typeof(ListEventsPage)
            //    }
            //};
        }

        //private async void OnChangeProgressStateButtonClick(object sender, RoutedEventArgs e)
        //{
        //    this.TheProgressRing.IsActive = true;
        //    await Task.Delay(1000);
        //    this.TheProgressRing.IsActive = false;
        //    (Window.Current.Content as Frame)
        //          .Navigate(typeof(ListEventsPage));
        //}
    }
}
