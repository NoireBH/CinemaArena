
using CinemaArena.Models;
using CinemaArena.Web.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CinemaArena.Controllers
{
	public class HomeController : BaseController
	{
		private readonly ILogger<HomeController> logger;

		public HomeController(ILogger<HomeController> logger)
		{
			this.logger = logger;
		}

		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
