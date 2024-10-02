namespace Library_DEPI.Models
{
    public class Return
    {
        public int Id { get; set; }
        public DateTime ReturnDate { get; set; } = DateTime.Now;
        public decimal PenaltyAmount { get; set; }
        public int CheckoutID { get; set; }
        public Checkout Checkout { get; set; }
    }
}
