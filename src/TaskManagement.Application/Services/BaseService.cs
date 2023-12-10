using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
	public abstract class BaseService<T> where T : class
	{
		private readonly IBaseRepository<T> _baseRepository;
		public BaseService(IBaseRepository<T> baseRepository)
		{
			_baseRepository = baseRepository;
		}

		public void Add(T entity) => _baseRepository.Add(entity);
		public void Commit() => _baseRepository.Commit();
	}
}
