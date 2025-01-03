using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CinemaArena.Common.EntityValidationConstants.Genre;

namespace CinemaArena.Data.Models
{
	public class Genre
	{
		public Genre()
		{
			MovieGenres = new HashSet<MovieGenre>();
		}

		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;

		public virtual ICollection<MovieGenre> MovieGenres { get; set; }
	}
}
