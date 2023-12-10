using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Domain.Interfaces
{
	public interface IBaseRepository<Entity> where Entity : class
	{
		void Add(Entity entity);
		void Commit();
	}
}
