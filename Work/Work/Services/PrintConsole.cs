using System;
namespace Work.Services
{
    internal class PrintConsole : Interfaces.Services.IPrintConsole
    {
        private string _common;
        public void Print(Abstacts.Employee[] empl)
        {
            foreach (var emp in empl)
            {
                _common = $"Name: {emp.Name}\nSurname: {emp.Surname}\nID-Code: {emp.EmployeeID}\nSalary: {emp.Salary}\n" +
                                    $"Position: {emp.EmploymentHistory}\nInsurance code: {emp.Insurance.Id}";

                switch (emp)
                {
                    case Models.Acounter a:
                        Console.WriteLine($"{_common}\nHas done { a.NumbersAccounts} operation(s)\n{a.CountBonus()}\n");
                        break;
                    case Models.Manager m:
                        Console.WriteLine($"{_common}\nHas done {m.NumbersStocks} stock(s)\n{m.CountBonus()}\n");
                        break;
                }
            }
        }
    }
}
