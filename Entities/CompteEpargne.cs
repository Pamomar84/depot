using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Entities
{
    internal class CompteEpargne : Compte
    {
        private float taudec { get; set; }

        public CompteEpargne(float taudec, int solde, int numcompte) : base(numcompte , solde)
        {
            this.taudec = taudec;
        }


    }
}
