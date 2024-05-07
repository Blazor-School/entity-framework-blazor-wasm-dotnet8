using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkInFrontend.DAL;

public class BlazorSchoolContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseInMemoryDatabase("BlazorSchoolDB");
}
