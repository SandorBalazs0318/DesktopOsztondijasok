namespace ScholarshipProject.Models
{
    public class ScholarshipApplicant
    {
        private string _email;
        private double _amount;

        public ScholarshipApplicant(string email, string name)
        {
            if (string.IsNullOrEmpty(email)) 
                throw new ArgumentNullException("email");
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            _email = email;
            Name = name;
            _amount = 0;
        }
        public string Email { get =>_email; set =>_email=value; }
        public string Name { get; set; }
        public double Amount { get =>_amount; set => _amount=value; }

        public void GetScholarship(double amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));
            _amount += amount;
        }

        public override string ToString()
        {
            return $"{Name} ({_email}) - {_amount} Ft";
        }
    }
}
