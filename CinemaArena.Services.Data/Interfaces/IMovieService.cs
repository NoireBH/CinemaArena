using CinemaArena.Web.ViewModels.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaArena.Services.Data.Interfaces
{
	public interface IMovieService
	{
		Task<MovieViewModel[]> GetFiveLatestMovies();
	}
}
