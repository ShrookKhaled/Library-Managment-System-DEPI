namespace Library_DEPI.Models
{
    public class Gift
    {
        public int Id { get; set; }
        public DateTime GiftDate { get; set; } = DateTime.Now;
        public int GiftedBookID { get; set; }
        public Book GitedBook { get; set; }
        public int MemberID { get; set; }
        public Member Member { get; set; }

    }
}
