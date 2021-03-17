using HotReloadTestApps.Shared.Entities;
using HotReloadTestApps.Shared.Services;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;

namespace HotReloadTestApps.WPF.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        //Properties

        private ObservableCollection<DotNetRelease> _DotNetReleases;
        public ObservableCollection<DotNetRelease> DotNetReleases
        {
            get { return _DotNetReleases; }
            set { SetProperty(ref _DotNetReleases, value); }
        }

        // Init
        public MainWindowViewModel()
        {
            // Init
            DotNetReleases = new ObservableCollection<DotNetRelease>();

            // Load data
            RefreshList();
        }

        // Internal Methods
        private async void RefreshList()
        {
            DotNetInfoService dotnetInfo = new();

            var results = await dotnetInfo.GetReleasesAsync();

            DotNetReleases.Clear();

            DotNetReleases.AddRange(results);
        }

        // Commands
        private ICommand refreshData;
        public ICommand RefreshData => refreshData ??= new DelegateCommand(PerformRefreshData);

        private void PerformRefreshData()
        {
            RefreshList();
        }
    }
}
