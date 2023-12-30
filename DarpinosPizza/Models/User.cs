namespace DarpinosPizza.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<PurchasesRecords> Purchases { get; set; } = new List<PurchasesRecords>();

        public User()
        {

        }

        public User(int id, string name, string email, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public void AddProduct(PurchasesRecords purchases)
        {
            Purchases.Add(purchases);
        }
        public void RemoveProduct(PurchasesRecords purchases)
        {
            Purchases.Remove(purchases);
        }

        public double TotalPurchases(DateTime initial, DateTime final)
        {
            return Purchases.Where(p => p.Date >= initial && p.Date <= final).Sum(p => p.Amount);
        }
    }
}
