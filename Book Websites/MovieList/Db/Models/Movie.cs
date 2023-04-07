using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MovieList.Db.Models
{
    public class Movie
    {
        public int MovieID { get; set; }


        [Required(ErrorMessage ="Please enter a name")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage ="Please enter a year")]
        [Range(1889, 3000, ErrorMessage ="Year must be after 1889")]
        public int? Year { get; set; }
        [Required(ErrorMessage ="Please enter a rating")]
        [Range(1,5,ErrorMessage ="Range must be between 1 and 5")]
        public int? Rating { get; set; }

        [Required(ErrorMessage ="Please enter a genre")]
        public string GenreID { get; set; } = string.Empty;

        [ValidateNever]
        public Genre Genre { get; set; } = null!;
        public string Slug => Name?.Replace(' ', '-') + '-' + Year?.ToString();

    }
}
