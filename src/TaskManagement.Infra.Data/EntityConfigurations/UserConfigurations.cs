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
			builder.HasKey(u => u.Id);

			builder.Property(u => u.FirstName).HasMaxLength(100).IsRequired();
			builder.Property(u => u.LastName).HasMaxLength(100).IsRequired();
			builder.Property(u => u.Email).HasMaxLength(256).IsRequired();
			builder.Property(u => u.Password).HasMaxLength(256).IsRequired();
			builder.Property(u => u.UserName).HasMaxLength(80).IsRequired();
			builder.Property(t => t.CreatedOn).HasDefaultValue(DateTime.Now).IsRequired();
		}
	}
}
