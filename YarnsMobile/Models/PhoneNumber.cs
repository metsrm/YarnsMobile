using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YarnsMobile.Models
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public int SignatureId { get; set; }

        [InverseProperty("Numbers")]
        public virtual PhoneSignature Signature { get; set; }
    }
}
