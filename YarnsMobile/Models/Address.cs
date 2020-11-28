using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YarnsMobile.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string AddressName { get; set; }

        [Display(Name = "Unit #")]
        public string UnitNumber { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        public virtual IEnumerable<Member> Members { get; set; }
    }
}
