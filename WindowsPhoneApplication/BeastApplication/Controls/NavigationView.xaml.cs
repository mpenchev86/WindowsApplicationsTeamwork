namespace BeastApplication.Controls
{
    using BeastApplication.Pages;
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

    public sealed partial class NavigationView : UserControl
    {
        public NavigationView()
        {
            this.InitializeComponent();
        }

        public IEnumerable<AppBarButtonContent> NavItems
        {
            get { return (IEnumerable<AppBarButtonContent>)GetValue(NavItemsProperty); }
            set { SetValue(NavItemsProperty, value); }
        }

        public static DependencyProperty NavItemsProperty
        {
            get
            {
                return navItemsProperty;
            }
        }

        // Using a DependencyProperty as the backing store for NavItems.  This enables animation, styling, binding, etc...
        private static readonly DependencyProperty navItemsProperty =
            DependencyProperty.Register(
                "NavItems", 
                typeof(IEnumerable<AppBarButtonContent>), 
                typeof(NavigationView), 
                new PropertyMetadata(null, new PropertyChangedCallback(HandleNavItemsChanged)));

        private static void HandleNavItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var navigationView = d as NavigationView;
            navigationView.navViewListBox.ItemsSource = e.NewValue as IEnumerable<AppBarButtonContent>;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (Window.Current.Content as Frame)
                 .Navigate(typeof(LocationsPage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var dataContext = btn.DataContext;
            var destPage = (dataContext as AppBarButtonContent).DestinationPageType;
            (Window.Current.Content as Frame)
                 .Navigate(destPage);
        }

         
        //public static int GetMyProperty(DependencyObject obj)
        //{
        //    return (int)obj.GetValue(MyPropertyProperty);
        //}

        //public static void SetMyProperty(DependencyObject obj, int value)
        //{
        //    obj.SetValue(MyPropertyProperty, value);
        //}

        //// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty MyPropertyProperty =
        //    DependencyProperty.RegisterAttached("MyProperty", typeof(int), typeof(ownerclass), new PropertyMetadata(0));
    }
}
