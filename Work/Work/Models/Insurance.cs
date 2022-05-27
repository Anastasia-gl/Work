namespace Work.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public Insurance()
        {
            GetId();
        }
        private void GetId()
        {
            Random random = new Random();
            Id = random.Next(1, 1000);
        }
    }
}
