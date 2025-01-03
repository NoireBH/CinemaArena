using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaArena.Common
{
	public static class EntityValidationConstants
	{
		public class Movie
		{
			public const int NameMinLength = 1;
			public const int NameMaxLength = 40;

			public const int DescriptionMinLength = 10;
			public const int DescriptionMaxLength = 500;

			public const string YoutubeLinkRegex = "^((?:https?:)?\\/\\/)?((?:www|m)\\.)?((?:youtube(-nocookie)?\\.com|youtu.be))(\\/(?:[\\w\\-]+\\?v=|embed\\/|live\\/|v\\/)?)([\\w\\-]+)(\\S+)?$";
		}

		public class Genre
		{
			public const int NameMinLength = 2;
			public const int NameMaxLength = 20;
		}
	}
}
