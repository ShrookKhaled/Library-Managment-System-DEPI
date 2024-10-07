namespace Library_DEPI.Models
{
    public class Checkout
    {
        public int Id { get; set; }
        public DateTime CheckoutDate { get; set; } = DateTime.Now;
        public int BookID { get; set; }
        public Book Book { get; set; }
        public string MemberID { get; set; }
        public Member Member { get; set; }
    }
}
