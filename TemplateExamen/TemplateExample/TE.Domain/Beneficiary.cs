using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE.Core.Domain
{
    public class Beneficiary
    {
        [Key]
        //[MinLength(8)]
        //[Range(0,999999999)]
        [StringLength(8, MinimumLength = 8)]
        public string CIN { get; set; }
        public string Name { get; set; }
        //[Phone]
        //[DataType(DataType.PhoneNumber)]
        //public string Phone { get; set; }
        //public string Adress { get; set; }
        //public string Email { get; set; }
        public Contact MyContact { get; set; }
        public string Description { get; set; }
        public virtual IList<Kafala> Kafalas { get; set; }
    }
}
