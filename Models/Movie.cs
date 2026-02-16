using System.ComponentModel.DataAnnotations;

namespace HW3.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Назва фільму є обов'язковою")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Назва має містити від 2 до 100 символів")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Режисер є обов'язковим")]
        [StringLength(60)]
        public string? Director { get; set; }

        [Required(ErrorMessage = "Оберіть жанр")]
        public string? Genre { get; set; }

        [Required(ErrorMessage = "Рік є обов’язковим")]
        [Range(1888, 2100, ErrorMessage = "Рік має бути між 1888 та 2100")]
        [MovieYear]
        public int Year { get; set; }

        [Url(ErrorMessage = "Некоректне посилання на постер")]
        public string? Poster { get; set; }

        [Required(ErrorMessage = "Опис є обов’язковим")]
        [MinLength(20, ErrorMessage = "Опис має містити щонайменше 20 символів")]
        public string? Description { get; set; }

        [Url(ErrorMessage = "Некоректне посилання на трейлер")]
        public string? Trailer { get; set; }
    }
}