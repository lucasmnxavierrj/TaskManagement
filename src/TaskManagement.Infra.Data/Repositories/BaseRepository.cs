using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Interfaces;
using TaskManagement.Infra.Data.Context;

namespace TaskManagement.Infra.Data.Repositories
{
	public class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : class
	{
		protected readonly AppDbContext _context;

		public BaseRepository(AppDbContext context)
		{
			_context = context;
		}

		public void Add(Entity entity)
			=> _context.Add(entity);

		public void Commit() => _context.SaveChanges();
	}
}
