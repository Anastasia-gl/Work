namespace Work.Models
{
    sealed class Acounter : Abstacts.Employee
    {
        public int NumbersAccounts { get; set; }
        public Acounter(string name, string surname, int id, string empHistory, int salary, int numberOperation, Insurance insurance) : base(name, surname, id, empHistory, salary, insurance)
        {
            NumbersAccounts = numberOperation;
        }

        public override string CountBonus()
        {
            if (NumbersAccounts > 15 && NumbersAccounts < 30)
            {
                Salary += 1000;
                BonusInfo = $"Salary with bonuses: {Salary}";
            }
            else if (NumbersAccounts > 30)
            {
                Salary += 2000;
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
