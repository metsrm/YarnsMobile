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

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [Display(Name = "Copyright Year")]
        public int CopyrightYear { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Display(Name = "Photo")]
        public string CoverImage { get; set; }

        [Required]
        [Display(Name = "Current Price")]
        public decimal CurrentPrice { get; set; }

        public virtual IEnumerable<Review> Reviews { get; set; }
    }
}
