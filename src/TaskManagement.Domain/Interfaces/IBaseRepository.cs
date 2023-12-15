namespace TaskManagement.Domain.Interfaces
{
	public interface IBaseRepository<T> where T : class
	{
		void Add(T entity);
		Task AddAsync(T entity);
		void Commit();
	}
}