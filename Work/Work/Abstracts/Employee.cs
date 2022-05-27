namespace Work.Abstacts
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int EmployeeID { get; set; }

        public string EmploymentHistory { get; set; }

        public int Salary { get; set; }

        public string BonusInfo { get; set; }

        public Models.Insurance Insurance { get; set; }

        public Employee(string name, string surname, int id, string empHistory, int salary, Models.Insurance insurance)
        {
            Name = name;
            Surname = surname;
            EmployeeID = id;
            EmploymentHistory = empHistory;
            Salary = salary;
            Insurance = insurance;
        }

        public virtual string CountBonus() { return BonusInfo; }
    }
}
