using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopTestesUnitariosSquad
{
    public class ObjetoQualquer
    {
        public ObjetoQualquer(IOutroObjetoQualquer obq)
        {
            Obq = obq;
        }

        public IOutroObjetoQualquer Obq { get; }

        public void UmMetodoQualquer()
        {
            Obq.outroMetodoQualquer();
        }

        
    }
}
