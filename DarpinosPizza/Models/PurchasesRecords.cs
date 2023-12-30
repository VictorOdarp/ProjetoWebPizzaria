using DarpinosPizza.Models.Enums;

namespace DarpinosPizza.Models
{
    public class PurchasesRecords
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public User User { get; set; }

        public PurchasesRecords()
        {

        }

        public PurchasesRecords(int id, DateTime date, double amount, SaleStatus status, User user)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            User = user;
        }
    }
}
