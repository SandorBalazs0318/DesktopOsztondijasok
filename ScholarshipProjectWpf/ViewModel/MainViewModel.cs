using CommunityToolkit.Mvvm.ComponentModel;
using ScholarshipProject.Repos;
using ScholarshipProjectWpf.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipProjectWpf.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        private ScholarshipRepo _repo = new();

        [ObservableProperty]
        private ConrtolPanelViewModel _controlPanelViewModel;

        [ObservableProperty]
        private ManagementViewModel _managementViewModel;

        public MainViewModel()
        {
            _controlPanelViewModel = new ConrtolPanelViewModel(_repo);
            _managementViewModel = new ManagementViewModel(_repo);
        }
    }
}
