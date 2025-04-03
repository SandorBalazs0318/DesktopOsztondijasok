using CommunityToolkit.Mvvm.ComponentModel;
using ScholarshipProject.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipProjectWpf.ViewModel
{
    public partial class ConrtolPanelViewModel : ObservableObject
    {
        private readonly ScholarshipRepo _repo;

        [ObservableProperty] private string numberOfScholarship = string.Empty;
        [ObservableProperty] private string highestnumberScholarship = string.Empty;
        [ObservableProperty] private string hasAmountZero = string.Empty;
        [ObservableProperty] private string hasAmount = string.Empty;
        [ObservableProperty] private string lowestNumberScholarship = string.Empty;
        [ObservableProperty] private string sumScholarship = string.Empty;
        [ObservableProperty] private string avarageScholarship = string.Empty;
        public ConrtolPanelViewModel(ScholarshipRepo repo)
        {
            _repo = repo;
            NumberOfScholarship = $"{repo.GetNumberOfScholarship()} fő";
            HighestnumberScholarship = $"{repo.GetBiggestNumber()} Ft";
            HasAmountZero = $"{repo.GetNotHasScholarship()} fő";
            HasAmount = $"{repo.GetHasScholarship()} fő";
            LowestNumberScholarship = $"{repo.GetLowestNumber()} Ft";
            SumScholarship = $"{repo.GetAllScholarships()} Ft";
            AvarageScholarship = $"{repo.GetAvarage()} Ft";
        }
    }
}
