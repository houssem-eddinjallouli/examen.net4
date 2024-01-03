using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE.Core.Domain
{
    public class Donator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        //[Phone]
        //[DataType(DataType.PhoneNumber)]
        //public string Phone { get; set; }
        //public string Adress { get; set; }
        //public string Email { get; set; }
        public Contact MyContact { get; set; }
        public virtual IList<Donation> Donations { get; set; }
        public virtual IList<Kafala> Kafalas { get; set; }

    }
}
