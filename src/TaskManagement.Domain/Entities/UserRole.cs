using Microsoft.AspNetCore.Identity;

namespace TaskManagement.Domain.Entities
{
	public class UserRole : IdentityUserRole<int>
	{
		public int Id { get; set; }
	}
}
