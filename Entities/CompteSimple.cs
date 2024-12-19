using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Entities
{
    internal class CompteSimple : Compte
    {
        private int duree;

        public CompteSimple(int solde, int telclient, int duree ) : base(solde, telclient)
        {
            this.duree = duree;
        }
    }
}
