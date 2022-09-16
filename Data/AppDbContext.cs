using Microsoft.EntityFrameworkCore;

namespace Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }
    public DbSet<Student> Students { get; set; }
    protected override void OnModelCreating(ModelBuilder mb)
    {
        base.OnModelCreating(mb);
        mb.Entity<Student>().HasData(new Student[]
        {
            new Student{ Id=1,Name="Albert Einstein"},
            new Student{ Id=2,Name="Isaac Newton"},
            new Student{ Id=3,Name="Blaise Pascal"},
            new Student{ Id=4,Name="Nicola Tesla"}
        });
    }
}
