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
	public class TaskConfigurations : IEntityTypeConfiguration<Domain.Entities.AppTask>
	{
		public void Configure(EntityTypeBuilder<Domain.Entities.AppTask> builder)
		{
			builder.HasKey(t => t.Id);

			builder.Property(t => t.Name).HasMaxLength(100).IsRequired();
			builder.Property(t => t.Description).HasMaxLength(255).IsRequired();
			builder.Property(t => t.Type).HasMaxLength(100).IsRequired();
			builder.Property(t => t.Status).HasDefaultValue(1).IsRequired();
			builder.Property(t => t.CreatedOn).HasDefaultValue(DateTime.Now).IsRequired();
			
			builder.HasOne(t => t.User)
				.WithMany(u => u.Tasks)
				.HasForeignKey(t => t.UserId);

			builder.HasOne(t => t.TaskType)
				.WithMany(tt => tt.Tasks)
				.HasForeignKey(t => t.TaskTypeId);
		}
	}
}
