namespace Work.Facade
{
    internal class ServicesFacade
    {
        Services.PrintConsole print;
        Services.Promotion promotion;
        Services.Sort sort;

        public ServicesFacade()
        {
            print = new Services.PrintConsole();
            promotion = new Services.Promotion();
            sort = new Services.Sort();
        }

        public void Mix(Abstacts.Employee[] emp)
        {
            print.Print(emp);
            promotion.GetPromotion(emp);
            sort.Sorting(emp);
        }   
    }
}
