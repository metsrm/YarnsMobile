using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YarnsMobile.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter an Author")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please enter a Copyright Year")]
        [RegularExpression(@"\d+", ErrorMessage = "Invalid year")]
        [Display(Name = "Copyright Year")]
        public string CopyrightYear { get; set; }

        [Required(ErrorMessage = "Please enter an ISBN")]
        public string ISBN { get; set; }

        public string Image { get; set; }

        public byte[] PhotoFile { get; set; }

        public string ImageMimeType { get; set; }

        [NotMapped]
        [Display(Name = "Cover Image")]
        public IFormFile CoverImage { get; set; }

        [Required(ErrorMessage = "Please enter a Price")]
        [RegularExpression(@"\d+.\d{2}", ErrorMessage = "Invalid price")]
        [Display(Name = "Current Price")]
        public string CurrentPrice { get; set; }

        public virtual IEnumerable<Review> Reviews { get; set; }
    }
}
