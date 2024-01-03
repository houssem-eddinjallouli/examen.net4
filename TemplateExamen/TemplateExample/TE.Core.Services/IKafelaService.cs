using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TE.Core.Domain;

namespace TE.Core.Services
{
    internal interface IKafelaService:IService<Kafala>
    {
        IList<Beneficiary> listebene();
        int totaldont(DateTime dd ,DateTime df);

        IList<Donator> listedonat();
    }
}
