using TaskManagement.Domain.Interfaces;
using TaskManagement.Infra.Data.Context;

namespace TaskManagement.Infra.Data.Repositories
{
	public class BaseRepository<T> : IBaseRepository<T> where T : class
	{
		public readonly AppDbContext _context;
		public BaseRepository(AppDbContext context) 
		{
			_context = context;
		}

		public void Commit() => _context.SaveChanges();
		public void Add(T entity) => _context.Add(entity);
	}
}