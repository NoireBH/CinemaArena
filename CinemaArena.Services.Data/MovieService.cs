using CinemaArena.Data;
using CinemaArena.Data.Models;
using CinemaArena.Services.Data.Interfaces;
using CinemaArena.Web.ViewModels.Movie;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaArena.Services.Data
{
	public class MovieService : IMovieService
	{
		private readonly CinemaArenaDbContext context;

		public MovieService(CinemaArenaDbContext context)
		{
			this.context = context;
		}

		public async Task<MovieViewModel[]> GetFiveLatestMovies()
		{
			Movie[] allMovies = await context.Movies.AsNoTracking().OrderBy(x => x.Id).ToArrayAsync();

			MovieViewModel[] movies = allMovies
				.Select(m => new MovieViewModel
				{
					Id = m.Id,
					Name = m.Title,
					Image = m.Image
				}).ToArray();

			return movies;
		}
	}
}
