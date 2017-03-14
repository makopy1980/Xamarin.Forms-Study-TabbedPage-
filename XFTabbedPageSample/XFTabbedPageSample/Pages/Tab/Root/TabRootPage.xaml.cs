using System;
using System.Collections.Generic;
using System.Diagnostics;

using Xamarin.Forms;

namespace XFTabbedPageSample.Pages.Tab.Root
{
    public partial class TabRootPage : TabbedPage
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TabRootPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 表示画面変更時
        /// </summary>
        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();

            var pageIndex = this.Children.IndexOf(this.CurrentPage);
            Debug.WriteLine("Page Index: " + pageIndex);
        }

        // ここでBackキーを無効にすると全体に効いてしまう
        //
        /// <summary>
        /// Backキー押下時動作
        /// </summary>
        //protected override bool OnBackButtonPressed()
        //{
        //    // Backキー無効化
        //    return true;
        //}
    }
}
