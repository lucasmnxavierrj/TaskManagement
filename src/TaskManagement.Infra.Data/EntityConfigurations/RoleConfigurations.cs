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
	public class RoleConfigurations : IEntityTypeConfiguration<Role>
	{
		public void Configure(EntityTypeBuilder<Role> builder)
		{
			builder.ToTable("Roles");
			builder.HasKey(u => u.Id);

			builder.Property(u => u.Description).HasMaxLength(100).IsRequired();

			builder
				.HasMany(u => u.UserRoles)
				.WithOne()
				.HasForeignKey(ur => ur.RoleId)
				.IsRequired();
		}
	}
}
