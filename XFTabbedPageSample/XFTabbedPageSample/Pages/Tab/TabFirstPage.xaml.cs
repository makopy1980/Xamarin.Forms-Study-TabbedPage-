using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFTabbedPageSample.Pages.Tab
{
    public partial class TabFirstPage : ContentPage
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TabFirstPage()
        {
            InitializeComponent();

            // ページタイトル→Tabのタイトル
            this.Title = "First";
        }

        /// <summary>
        /// Backキー押下時動作
        /// </summary>
        protected override bool OnBackButtonPressed()
        {
            // Backキー無効化
            return true;
        }
    }
}
