using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFTabbedPageSample.Pages.Tab
{
    public partial class TabSecondPage : ContentPage
    {
        public TabSecondPage()
        {
            InitializeComponent();

            // ページタイトル→Tabのタイトル
            this.Title = "Second";
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
