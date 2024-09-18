using Microsoft.EntityFrameworkCore;
using stripe_dotnet_example.Entities;

public class DbContext : Microsoft.EntityFrameworkCore.DbContext
{
	public DbContext(DbContextOptions<DbContext> options)
		  : base(options)
	{
	}

	public DbSet<Customer> Customers { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
	}
}
