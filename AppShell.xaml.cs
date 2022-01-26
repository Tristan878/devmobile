using System;
using System.Collections.Generic;
using projectDevMobile.ViewModels;
using projectDevMobile.Views;
using Xamarin.Forms;

namespace projectDevMobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
