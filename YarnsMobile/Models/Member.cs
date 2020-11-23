using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YarnsMobile.Models
{
    public class Member : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        public string AccountNumberPrefix { get; set; }

        public int AccountNumberSuffix { get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        public virtual IEnumerable<PurchasedBook> PurchasedBooks { get; set; }

        public virtual IEnumerable<Phone> PhoneNumbers { get; set; }
    }
}
