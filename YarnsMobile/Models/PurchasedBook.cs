using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YarnsMobile.Models
{
    public class PurchasedBook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int MemberId { get; set; }

        public virtual Member Member { get; set; }

        public int BookId { get; set; }

        public virtual Book Book { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal PurchasePrice { get; set; }
    }
}
