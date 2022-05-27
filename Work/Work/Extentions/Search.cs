namespace Work.Extentions
{
    public static class Search
    {
        public static void MakeSearch(this Abstacts.Employee[] emp, string search)
        {
            foreach (var employee in emp)
            {
                if (employee.EmploymentHistory == search)
                {
                    Console.WriteLine($"{employee.EmployeeID} {employee.Name} has a position of {search}");
                }
            }
        }
    }
}
