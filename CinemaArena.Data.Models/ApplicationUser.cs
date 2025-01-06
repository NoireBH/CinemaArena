using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaArena.Data.Models
{
	using Microsoft.AspNetCore.Identity;
	/// <summary>
	/// This is custom user class that works with the default ASP.NET Core Identity.
	/// You can add additional info to the built-in users.
	/// </summary>

	public class ApplicationUser : IdentityUser
	{
		public ApplicationUser()
		{

		}

	}
}
