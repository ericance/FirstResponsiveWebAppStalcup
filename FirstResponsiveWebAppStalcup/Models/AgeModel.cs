using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppStalcup.Models
{
	public class AgeModel
	{
		public int? CURRENT_YEAR = DateTime.Now.Year;

		// Variables are user input

		[Required(ErrorMessage = "Please enter your name")]
		[StringLength (25, ErrorMessage =
		"Name must be less than 25 characters.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Please enter a year")]
		[Range(1900, 2021, ErrorMessage =
		"Year must be between 1900 and 2021.")]
		public int? BirthYear { get; set; }

		public int? AgeThisYear()
		{
			int? age = 0;
			age = (CURRENT_YEAR - BirthYear);
			return age;
		}
	}
}
