using System;
using System.ComponentModel.DataAnnotations;

namespace AdvancedProgramming_Lesson2.Models
{
    public class Book
    {
        [Display(Name = ("Indentyfikator"))]
        public int Id { get; set; }
        [Display(Name = ("Tytuł"))]
        [StringLength(60, MinimumLength = 5)]
        public string Title { get; set; }
        [DataType(DataType.Date)]               // propertis adv
        [Display(Name = ("Data premiery"))]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = ("Gatunke"))]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        [Display(Name = ("Cena"))]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
