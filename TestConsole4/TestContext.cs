using Microsoft.EntityFrameworkCore;
using TestConsole4.Model;

namespace TestConsole4;

public class TestContext:DbContext
{
    public DbSet<Note> Notes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = mydb.db");
    }
}