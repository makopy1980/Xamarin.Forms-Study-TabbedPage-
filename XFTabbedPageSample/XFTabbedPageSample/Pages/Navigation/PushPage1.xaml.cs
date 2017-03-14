using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFTabbedPageSample.Pages.Navigation
{
    public partial class PushPage1 : ContentPage
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public PushPage1()
        {
            InitializeComponent();

            // Android, WindowsPhoneではTabが画面上部に表示されるため、
            // NavigationBarを非表示にする
            if (Device.OS != TargetPlatform.iOS)
            {
                // NavigationBar非表示
                NavigationPage.SetHasNavigationBar(this, false);
            }
        }

        /// <summary>
        /// Backキー押下時動作
        /// </summary>
        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }
    }
}
