
using CinemaArena.Models;
using CinemaArena.Services.Data;
using CinemaArena.Services.Data.Interfaces;
using CinemaArena.Web.Controllers;
using CinemaArena.Web.ViewModels.Movie;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CinemaArena.Controllers
{
	public class HomeController : BaseController
	{
		private readonly ILogger<HomeController> logger;
		private readonly IMovieService movieService;

		public HomeController(
			ILogger<HomeController> logger,
			IMovieService movieService
			)
		{
			this.logger = logger;
			this.movieService = movieService;
		}

		[AllowAnonymous]
		public async Task<IActionResult> Index()
		{
			MovieViewModel[] featuredMovies = await movieService.GetFiveLatestMovies();

			return View(featuredMovies);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
