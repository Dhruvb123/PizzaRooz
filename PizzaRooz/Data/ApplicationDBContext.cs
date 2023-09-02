using Microsoft.EntityFrameworkCore;
using PizzaRooz.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PizzaRooz.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<Users> Users { get; set; }

		// DbSet for each entity class representing the corresponding database table
		public DbSet<PizzaOrder> Pizzas { get; set; }
		// Add more DbSets for other entity classes if you have them

		// Optional: You can override OnModelCreating method to configure entity relationships, keys, etc.
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Example configuration for a Pizza entity
			modelBuilder.Entity<PizzaOrder>()
				.HasKey(p => p.Id); // Assuming Pizza class has a property 'Id' representing the primary key

			// Configuration for User entity
			modelBuilder.Entity<Users>()
				.HasKey(u => u.Id);
			// Add more configurations for other entity classes if needed
		}
	}
}

