using Microsoft.AspNetCore.Identity;

namespace TaskManagement.Domain.Entities
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public IEnumerable<AppTask>? Tasks { get; set; }
		public ICollection<IdentityUserRole<int>> UserRoles { get; set; }
	}

}
