using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFTabbedPageSample.Pages.Tab
{
    public partial class TabSecondPage : ContentPage
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TabSecondPage()
        {
            InitializeComponent();

            // ページタイトル→Tabのタイトル
            this.Title = "Second";
        }

        /// <summary>
        /// Backキー押下時動作
        /// </summary>
        protected override bool OnBackButtonPressed()
        {
            // Backキー無効化
            return true;
        }

        /// <summary>
        /// "To Tab1"ボタンタップ時動作
        /// </summary>
        private void OnTab1ButtonTapped(object sender, EventArgs e)
        {
            var tabbedPage = this.Parent as TabbedPage;
            tabbedPage.CurrentPage = tabbedPage.Children[0];
        }

        /// <summary>
        /// "To Tab3"ボタンタップ時動作
        /// </summary>
        private void OnTab3ButtonTapped(object sender, EventArgs e)
        {
            var tabbedPage = this.Parent as TabbedPage;
            tabbedPage.CurrentPage = tabbedPage.Children[2];
        }
    }
}
