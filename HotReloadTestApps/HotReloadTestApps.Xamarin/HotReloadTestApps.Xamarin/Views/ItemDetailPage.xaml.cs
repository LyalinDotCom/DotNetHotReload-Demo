using HotReloadTestApps.Xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace HotReloadTestApps.Xamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}