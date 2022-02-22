using System.Data.Entity;

public class LibraryContext : DbContext
{
    public LibraryContext(string connectionString) : base(connectionString)
    { }
    public DbSet<BookEntity> Books { get; set; }
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<ReservationEntity> Reserves { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
