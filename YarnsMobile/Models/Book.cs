using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YarnsMobile.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int CopyrightYear { get; set; }
        public string ISBN { get; set; }
        public decimal SalesPrice { get; set; }
        public DateTime DateOfSale { get; set; }
        public string ImageName { get; set; }
        public byte[] PhotoFile { get; set; }
        public string ImageMimeType { get; set; }
        public ICollection<Member> Members { get; set; }

        [NotMapped]
        public IFormFile PhotoAvatar { get; set; }
    }
}
