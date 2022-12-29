using Honda.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Honda.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Make> Make { get; set; }

		public DbSet<ModelBike> ModelBike { get; set; }

		public DbSet<Feature> Feature { get; set; }

	}
}