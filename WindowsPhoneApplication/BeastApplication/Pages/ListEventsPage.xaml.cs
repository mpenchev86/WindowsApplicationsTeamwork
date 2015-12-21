using BeastApplication.Controls;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

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
                new SportEventViewModel("6:00 PM", 22, 3, "Reniiii")
            };

            this.navigationView.NavItems = new[]
            {
                new AppBarButtonContent()
                {
                    Title = "Back",
                    DestinationPageType = typeof(CalendarPage)
                },
                new AppBarButtonContent()
                {
                    Title = "Next",
                    DestinationPageType = typeof(CreateEventPage)
                }
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (Window.Current.Content as Frame)
                 .Navigate(typeof(CreateEventPage));
        }

        private void OnButtonJoinClick(object sender, RoutedEventArgs e)
        {          
            var dataContext = ((Button) sender).DataContext as SportEventViewModel;
            dataContext.ActualPeopleCount += 1;
        }
    }
}
