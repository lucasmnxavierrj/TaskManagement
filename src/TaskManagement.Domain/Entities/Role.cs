using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Domain.Entities
{
	public class Role : IdentityRole<int>
	{
		public string Description { get; set; }
		public ICollection<IdentityUserRole<int>> UserRoles { get; set; }
	}
}
