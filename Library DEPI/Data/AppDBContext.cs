


namespace Library_DEPI.Data
{
    public class AppDBContext : IdentityDbContext<IdentityUser>
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }
        //public DbSet<Member> Members { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        //public DbSet<Checkout> Checkouts { get; set; }
        //public DbSet<Return> Returns { get; set; }
        //public DbSet<Penalty> Penalties { get; set; }

    }
}
