namespace Work
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Models.Insurance insurance = new Models.Insurance();

            Abstacts.Employee[] employees = new Abstacts.Employee[3];
            employees[0] = new Models.Acounter("Pam", "Bisli", 099864, "Acounter", 15000, 50, insurance);
            employees[1] = new Models.Manager("Michael", "Scott", 056494, "Manager", 35000, 24, insurance);
            employees[2] = new Models.Manager("Jim", "Hapert", 975488, "Manager", 24000, 60, insurance);

            Facade.ServicesFacade facade = new Facade.ServicesFacade();
            facade.Mix(employees);

            Console.WriteLine("\nType a position which you want to find (for examaple: Manager): ");
            string search=Console.ReadLine();
            Extentions.Search.MakeSearch(employees, search);
        }
    }
}
