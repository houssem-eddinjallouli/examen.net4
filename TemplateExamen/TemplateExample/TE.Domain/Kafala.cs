using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE.Core.Domain
{
    public class Kafala
    {
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Amount { get; set; }
        public virtual Donator MYDonator { get; set; }
        public virtual Beneficiary MyBeneficiary { get; set;}
        public int DonatorFk { get; set; }
        public string BeneficiaryFk { get; set; }
        
    }
}
