﻿using BeastApplication.Controls;
using BeastApplication.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls.Maps;
using BeastApplication.ViewModels;

namespace BeastApplication.Pages
{
    public sealed partial class LocationsPage : Page
    {
        private Geolocator geolocator;

        public LocationsPage()
        {
            this.InitializeComponent();
            this.geolocator = new Geolocator();
            this.InitGeolocation();
            this.geolocator.PositionChanged += OnGeolocationPositionChanged;

            this.navigationView.NavItems = new[]
            {
                new AppBarButtonContent()
                {
                    Title = "Back",
                    DestinationPageType = typeof(MainPage)
                },
                new AppBarButtonContent()
                {
                    Title = "Next",
                    DestinationPageType = typeof(CalendarPage)
                }
            };
        }

        private async void OnGeolocationPositionChanged(Geolocator sender, PositionChangedEventArgs args)
        {
            var lat = args.Position.Coordinate.Point.Position.Latitude;
            var lon = args.Position.Coordinate.Point.Position.Longitude;
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                this.tbLat.Text = string.Format("Latitude: {0}", lat);
                this.tbLon.Text = string.Format("Longitude: {0}", lon);
            });
            
        }

        private async void InitGeolocation()
        {
            var accessStatus = await Geolocator.RequestAccessAsync();
            var geoposition = await geolocator.GetGeopositionAsync();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                UserSelection.SportType = "for " + e.Parameter.ToString();
            }
            this.sportType.Text = UserSelection.SportType;
        }
    }
}
