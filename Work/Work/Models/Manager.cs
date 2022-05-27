namespace Work.Models
{
    sealed class Manager : Abstacts.Employee
    {
        public int NumbersStocks { get; set; }
        public Manager(string name, string surname, int id, string empHistory, int salary, int numberOperation, Insurance insurance) : base(name, surname, id, empHistory, salary, insurance)
        {
            NumbersStocks = numberOperation;
        }

        public override string CountBonus()
        {
            if (NumbersStocks > 25 && NumbersStocks < 50)
            {
                Salary += 5000;
                BonusInfo = $"Salary with bonuses: {Salary}";
            }
            else if (NumbersStocks > 50)
            {
                Salary += 10000;
                BonusInfo = $"Salary with double bonus: {Salary}";
            }
            else
            {
                BonusInfo = $"In this case there are not any bonuses. Salary the same {Salary}";
            }

            return BonusInfo;
        }
    }
}
