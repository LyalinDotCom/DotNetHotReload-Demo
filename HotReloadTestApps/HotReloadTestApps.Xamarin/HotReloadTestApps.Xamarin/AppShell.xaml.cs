using HotReloadTestApps.Xamarin.ViewModels;
using HotReloadTestApps.Xamarin.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HotReloadTestApps.Xamarin
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
