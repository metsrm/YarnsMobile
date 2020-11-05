using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YarnsMobile.Models
{
    public class PhoneSignature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PhoneNumber> Numbers { get; set; }
    }
}
