using GameShopWebApi.Authentication;
using GameShopWebApi.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameShopWebApi.Data
{
	public class ApplicationDbContext:IdentityDbContext<IdentityUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{


		}
		//public DbSet<Login> Logins { get; set; }

		public DbSet<Category> Categories { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Game> Games { get; set; }
		//public DbSet<GameCustomer> GameCustomers { get; set; }
		//public DbSet<GameCategory> GameCategories { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Reviewer> Reviewers { get; set; }

		/*protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<GameCategory>()
				   .HasKey(pc => new { pc.GameId, pc.CategoryId });
			modelBuilder.Entity<GameCategory>()
					.HasOne(p => p.Game)
					.WithMany(pc => pc.GameCategories)
					.HasForeignKey(p => p.GameId);
			modelBuilder.Entity<GameCategory>()
					.HasOne(p => p.Category)
					.WithMany(pc => pc.GameCategories)
					.HasForeignKey(c => c.CategoryId);

			modelBuilder.Entity<GameCustomer>()
					.HasKey(po => new { po.GameId, po.CustomerId });
			modelBuilder.Entity<GameCustomer>()
					.HasOne(p => p.Game)
					.WithMany(pc => pc.GameCustomers)
					.HasForeignKey(p => p.GameId);
			modelBuilder.Entity<GameCustomer>()
					.HasOne(p => p.Customer)
					.WithMany(pc => pc.GameCustomers)
					.HasForeignKey(c => c.GameId);
		}*/
	}
}
