using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
	public class BaseService<T> where T : class
	{
		private readonly IBaseRepository<T> _baseRepository;
		public BaseService(IBaseRepository<T> baseRepository)
		{
			_baseRepository = baseRepository;
		}

		public void Commit() => _baseRepository.Commit();
		public void Add(T entity) => _baseRepository.Add(entity);
	}
}