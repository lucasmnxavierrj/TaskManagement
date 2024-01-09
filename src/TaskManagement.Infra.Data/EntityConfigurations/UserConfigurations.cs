using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Infra.Data.EntityConfigurations
{
	public class UserConfigurations : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.ToTable("Users");
			builder.HasKey(u => u.Id);

			builder.Property(u => u.FirstName).HasMaxLength(100).IsRequired();
			builder.Property(u => u.LastName).HasMaxLength(100).IsRequired();
			builder.Property(u => u.Email).HasMaxLength(256).IsRequired();
			builder.Property(u => u.UserName).HasMaxLength(80).IsRequired();
			builder.Property(u => u.CreatedOn).HasDefaultValue(DateTime.Now).IsRequired();

			builder.HasIndex(u => u.Email).IsUnique();
			builder.HasIndex(u => u.UserName).IsUnique();

			builder
				.HasMany(u => u.UserRoles)
				.WithOne()
				.HasForeignKey(ur => ur.UserId)
				.IsRequired();
		}
	}
}
