﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaArena.Data.Models;

namespace CinemaArena.Data.Configurations
{
	public class MovieEntityConfiguration : IEntityTypeConfiguration<Movie>
	{
		public void Configure(EntityTypeBuilder<Movie> builder)
		{
			builder.HasData(SeedMovies());
		}

		private Movie[] SeedMovies()
		{

			var movies = new HashSet<Movie>();

			Movie movie;

			movie = new Movie()
			{
				Id = 1,
				Title = "The Shawshank Redemption",
				Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.",
				TrailerUrl = "https://www.youtube.com/embed/NmzuHjWmXOc",
				Image = "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1200_.jpg",

			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = 2,
				Title = "The Godfather",
				Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
				TrailerUrl = "https://www.youtube.com/embed/sY1S34973zA",
				Image = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UY1982_.jpg"
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = 3,
				Title = "Saw",
				Description = "Two strangers awaken in a room with no recollection of how they got there, and soon discover they're pawns in a deadly game perpetrated by a notorious serial killer.",
				TrailerUrl = "https://www.youtube.com/embed/S-1QgOMQ-ls",
				Image = "https://m.media-amazon.com/images/M/MV5BM2M1MzI1MWYtYmM2ZC00OWY3LTk0ZGMtNmRkNzU1NzEzMWE5XkEyXkFqcGdeQXVyODUwOTkwODk@._V1_FMjpg_UX1000_.jpg"
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = 4,
				Title = "The Dark Knight",
				Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
				TrailerUrl = "https://www.youtube.com/embed/EXeTwQWrcwY",
				Image = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_FMjpg_UY2048_.jpg"
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = 5,
				Title = "Pulp Fiction",
				Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
				TrailerUrl = "https://www.youtube.com/embed/s7EdQ4FqbhY",
				Image = "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UX1055_.jpg"
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = 6,
				Title = "Five Nights at Freddy's",
				Description = "A troubled security guard begins working at Freddy Fazbear's Pizza. During his first night on the job, he realizes that the night shift won't be so easy to get through. Pretty soon he will unveil what actually happened at Freddy's.",
				TrailerUrl = "https://www.youtube.com/embed/0VH9WCFV6XQ",
				Image = "https://m.media-amazon.com/images/M/MV5BNmNlZWI4MDQtMzFlYS00NzJmLTkwZjItZWVmNmJjZGYxNDA1XkEyXkFqcGdeQXVyMTM0NTUzNDIy._V1_FMjpg_UX1000_.jpg"
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = 7,
				Title = "It",
				Description = "In the summer of 1989, a group of bullied kids band together to destroy a shape-shifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town.\r\n\r\n",
				TrailerUrl = "https://www.youtube.com/embed/FnCdOQsX5kc",
				Image = "https://m.media-amazon.com/images/M/MV5BZDVkZmI0YzAtNzdjYi00ZjhhLWE1ODEtMWMzMWMzNDA0NmQ4XkEyXkFqcGdeQXVyNzYzODM3Mzg@._V1_.jpg"
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = 8,
				Title = "Drive",
				Description = "A mysterious Hollywood action film stuntman gets in trouble with gangsters when he tries to help his neighbor's husband rob a pawn shop while serving as his getaway driver.\r\n\r\n",
				TrailerUrl = "https://www.youtube.com/embed/KBiOF3y1W0Y",
				Image = "https://m.media-amazon.com/images/M/MV5BZjY5ZjQyMjMtMmEwOC00Nzc2LTllYTItMmU2MzJjNTg1NjY0XkEyXkFqcGdeQXVyNjQ1MTMzMDQ@._V1_FMjpg_UX1000_.jpg"
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = 9,
				Title = "Barbie",
				Description = "Barbie and Ken are having the time of their lives in the colorful and seemingly perfect world of Barbie Land. However, when they get a chance to go to the real world, they soon discover the joys and perils of living among humans.\r\n\r\n",
				TrailerUrl = "https://www.youtube.com/embed/pBk4NYhWNMM",
				Image = "https://m.media-amazon.com/images/M/MV5BNjU3N2QxNzYtMjk1NC00MTc4LTk1NTQtMmUxNTljM2I0NDA5XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_FMjpg_UX1000_.jpg"
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = 10,
				Title = "Blade Runner 2049",
				Description = "Young Blade Runner K's discovery of a long-buried secret leads him to track down former Blade Runner Rick Deckard, who's been missing for thirty years.",
				TrailerUrl = "https://www.youtube.com/embed/gCcx85zbxz4",
				Image = "https://m.media-amazon.com/images/M/MV5BNzA1Njg4NzYxOV5BMl5BanBnXkFtZTgwODk5NjU3MzI@._V1_FMjpg_UX1000_.jpg"
			};

			movies.Add(movie);

			return movies.ToArray();
		}
	}
}
