using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TE.Core.Domain;
using TE.Core.Interfaces;

namespace TE.Core.Services
{
    internal class KafalaService : Service<Kafala>, IKafelaService
    {
        public KafalaService(IUnitOfWork uow) : base(uow)
        {
        }

        public IList<Beneficiary> listebene()
        {
            return GetAll()
                .Where(h=>h.EndDate > DateTime.Now)
                .Select(h=>h.MyBeneficiary).ToList();
        }

        public IList<Donator> listedonat()
        {
            return GetAll()
                .Where(h=>h.EndDate> DateTime.Now)
                .Select(j=>j.MYDonator)
                .Distinct() 
              .Where(k=>k.Kafalas==null|| !k.Kafalas.Any())
                .ToList();
        }

        public int totaldont(DateTime dd, DateTime df)
        {
            return GetAll()
                .Where(h => h.StartDate > dd && h.EndDate < df)
                .Select(j => j.Amount).Sum();
        }
    }
}
