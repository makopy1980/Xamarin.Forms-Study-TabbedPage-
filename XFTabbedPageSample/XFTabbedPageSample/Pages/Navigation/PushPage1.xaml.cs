using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFTabbedPageSample.Pages.Navigation
{
    public partial class PushPage1 : ContentPage
    {
        public PushPage1()
        {
            InitializeComponent();

            if (Device.OS != TargetPlatform.iOS)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }
        }

        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }
    }
}
