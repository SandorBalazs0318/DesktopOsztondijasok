using ScholarshipProject.DbModels;

namespace ScholarshipProject.Repos
{
    public class ScholarshipRepo
    {
        private readonly ScholarshipContext _context = new();

        public int GetNumberOfScholarship()
        {
            return _context.Scholarships.Count();
        }

        public double GetHasScholarship()
        {
            return _context.Scholarships.Where(x => x.Amount != 0).Count();
        }

        public double GetNotHasScholarship()
        {
            return _context.Scholarships.Where(x => x.Amount == 0).Count();
        }

        public double GetBiggestNumber()
        {
            return _context.Scholarships.Select(x => x.Amount).Max();
        }

        public double GetLowestNumber()
        {
            return _context.Scholarships.Select(x => x.Amount).Min();
        }

        public double GetAllScholarships()
        {
            return _context.Scholarships.Select(x => x.Amount).Sum();
        }
        public double GetAvarage()
        {
            return _context.Scholarships.Select(x => x.Amount).Average();
        }
    }
}
