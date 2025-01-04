using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CinemaArena.Web.Controllers
{
	[Authorize]
	public class BaseController : Controller
	{
		
	}
}
