namespace Work.Services
{
    internal class Promotion : Interfaces.Services.IPromotion
    {
        public void GetPromotion(Abstacts.Employee[] employees)
        {
            Console.WriteLine("These persons were promoted!");

            foreach (var employee in employees)
            {
                switch (employee)
                {
                    case Models.Acounter a when a.NumbersAccounts > 30:
                        Console.WriteLine($"{employee.Name} has made {a.NumbersAccounts} for a short time!");
                        break;
                    case Models.Manager m when m.NumbersStocks > 50:
                        Console.WriteLine($"{employee.Name} has made {m.NumbersStocks} for a short time!");
                        break;
                }
            }
        }
    }
}
