namespace Work.Services
{
    internal class Sort : Interfaces.Services.ISort
    {
        public void Sorting(Abstacts.Employee[] employees)
        {
            int[] salary = new int[employees.Length];
            int count = 0;
            Console.WriteLine("\nSorted salary:");

            foreach (var employee in employees)
            {
                salary[count++] = employee.Salary;
            }

            Array.Sort(salary);

            for (int i = 0; i < salary.Length; i++)
            {
                Console.WriteLine(salary[i]);
            }
        }
    }
}
