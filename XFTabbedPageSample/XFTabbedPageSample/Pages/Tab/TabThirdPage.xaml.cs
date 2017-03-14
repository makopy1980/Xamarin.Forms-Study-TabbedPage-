using System;
using System.Collections.Generic;
using Xamarin.Forms;

using XFTabbedPageSample.Pages.Navigation;

namespace XFTabbedPageSample.Pages.Tab
{
    public partial class TabThirdPage : ContentPage
    {
        public TabThirdPage()
        {
            InitializeComponent();

            // ページタイトル→Tabのタイトル
            this.Title = "Third";

            if (Device.OS != TargetPlatform.iOS)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

        }

        /// <summary>
        /// "Next"ボタンタップ時動作
        /// </summary>
        private async void OnNextButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PushPage1(), true);
        }

        protected override bool OnBackButtonPressed()
        {
            // Backキー無効化
            return true;
        }
    }
}
