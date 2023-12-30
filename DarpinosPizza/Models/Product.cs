using Microsoft.Identity.Client;

namespace DarpinosPizza.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();

        public Product()
        {

        }

        public Product(int id, string name, string category, double price)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public double TotalProducts(DateTime initial, DateTime final)
        {
            return Users.Sum(p => p.TotalPurchases(initial, final));
        }
        
       
    }
}
