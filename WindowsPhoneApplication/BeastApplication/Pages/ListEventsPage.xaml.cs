using BeastApplication.Controls;
using BeastApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace BeastApplication.Pages
{
    public sealed partial class ListEventsPage : Page
    {
        public ListEventsPage()
        {
            this.InitializeComponent();
            this.ViewModel = new SportEventPageViewModel();
            this.ViewModel.SportEvents = new List<SportEventViewModel>
            {
                new SportEventViewModel("8:00 PM", 12, 2, "Reni"),
                new SportEventViewModel("6:00 PM", 22, 3, "Miro")
            };

            this.navigationView.NavItems = new[]
            {
                new AppBarButtonContent()
                {
                    Title = "Back",
                    DestinationPageType = typeof(CalendarPage)
                },
            };
        }

        public SportEventPageViewModel ViewModel {
            get
            {
                return this.DataContext as SportEventPageViewModel;
            }
                
            set
            {
                this.DataContext = value;
            }
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                UserSelection.Date = "Schedule for " + (e.Parameter as string).Split(' ')[0].ToString();
            }
            this.datePicked.Text = UserSelection.Date;
        }

        private async void OnAddEventButtonClick(object sender, RoutedEventArgs e)
        {
            this.TheProgressRing.IsActive = true;
            await Task.Delay(1000);
            this.TheProgressRing.IsActive = false;
        }
    }
}
