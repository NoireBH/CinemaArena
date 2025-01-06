using CinemaArena.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CinemaArena.Data
{
	public class CinemaArenaDbContext : IdentityDbContext
	{
		public CinemaArenaDbContext(DbContextOptions<CinemaArenaDbContext> options)
			: base(options)
		{
		}

		public DbSet<Movie> Movies { get; set; } = null!;

		public DbSet<MovieGenre> MovieGenres { get; set; } = null!;

		public DbSet<Genre> Genres { get; set; } = null!;

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<MovieGenre>().HasKey(x => new { x.GenreId, x.MovieId });

			base.OnModelCreating(builder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.EnableSensitiveDataLogging();
			base.OnConfiguring(optionsBuilder);
		}
	}
}
