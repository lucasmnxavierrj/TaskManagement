using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain.Entities;
using TaskManagement.Infra.Data.EntityConfigurations;

namespace TaskManagement.Infra.Data.Context
{
    public class AppDbContext : IdentityDbContext<User, Role, int>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{ }

		public DbSet<Domain.Entities.AppTask> Tasks { get; set; }
		public DbSet<TaskType> TaskTypes { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Role> Roles { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new TaskConfigurations());
			modelBuilder.ApplyConfiguration(new TaskTypeConfigurations());
			modelBuilder.ApplyConfiguration(new UserConfigurations());
			modelBuilder.ApplyConfiguration(new RoleConfigurations());

		}
	}
}
