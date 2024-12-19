using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Entities
{
    internal abstract class Compte
    {
        protected static int id = 0;
        protected int Myid { get; set; }
        protected int solde { get; set; }
        protected int num_comp { get; set; }

        protected String genNum(int idclient, int tel)
        {
            return ("000" + idclient + tel);
        }

        protected Compte(int solde, int telclient)
        {
            this.solde = solde;
            this.num_comp = int.Parse(genNum(Myid, telclient));
        }
    }
}
