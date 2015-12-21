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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace BeastApplication.Controls
{
    public sealed partial class SportButtonView : UserControl
    {
        public SportButtonView()
        {
            this.InitializeComponent();
        }

        public IEnumerable<SportButtonContent> SportItems
        {
            get { return (IEnumerable<SportButtonContent>)GetValue(SportItemsProperty); }
            set { SetValue(SportItemsProperty, value); }
        }

        public static DependencyProperty SportItemsProperty
        {
            get
            {
                return sportItemsProperty;
            }
        }

        // Using a DependencyProperty as the backing store for NavItems.  This enables animation, styling, binding, etc...
        private static readonly DependencyProperty sportItemsProperty =
            DependencyProperty.Register(
                "SportItems",
                typeof(IEnumerable<SportButtonContent>),
                typeof(SportButtonView),
                new PropertyMetadata(null, new PropertyChangedCallback(HandleSportItemsChanged)));

        private static void HandleSportItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var navigationView = d as SportButtonView;
            navigationView.sportViewGrid.ItemsSource = e.NewValue as IEnumerable<SportButtonContent>;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var dataContext = btn.DataContext;
            var destPage = (dataContext as SportButtonContent).DestinationPageType;
            var sportType = (dataContext as SportButtonContent).SportType.Name;
            (Window.Current.Content as Frame)
                 .Navigate(destPage, sportType);
        }
    }
}
