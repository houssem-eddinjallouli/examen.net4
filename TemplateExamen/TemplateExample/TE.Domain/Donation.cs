using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE.Core.Domain
{
    public class Donation
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [DataType(DataType.Currency)]
        public int Amount { get; set; }
        public virtual Donator MyDonator { get; set; }
    }
}
