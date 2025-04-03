using ScholarshipProject.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipProjectWpf.ViewModel
{
    public class ManagementViewModel
    {
        private ScholarshipRepo _repo;

        public ManagementViewModel(ScholarshipRepo repo)
        {
            _repo = repo;
        }
    }
}
