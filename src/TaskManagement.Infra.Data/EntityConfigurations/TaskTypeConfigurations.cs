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
	public class TaskTypeConfigurations : IEntityTypeConfiguration<TaskType>
	{
		public void Configure(EntityTypeBuilder<TaskType> builder)
		{
			builder.HasKey(tt => tt.Id);

			builder.Property(t => t.Name).HasMaxLength(100).IsRequired();
			builder.Property(t => t.Description).HasMaxLength(255).IsRequired();
		}
	}
}
