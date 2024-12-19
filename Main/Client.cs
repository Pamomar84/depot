using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBanque.Entities;

namespace GestionBanque.Main
{
    internal class Client
    {

        private static int id = 0;
        private int Myid { get; set; }

        private string nom { get; set; }
        private string prenom { get; set; }
        public int Tel { get; set; }

        private List<Compte> comptes;

        public Client(String nom, String prenom, int Tel) {
            this.nom = nom;
            this.prenom = prenom;
            Myid = id++;
            this.Tel = Tel;
            
        }

        public void afficherDetails(Client clientel)
        {
            Console.WriteLine("Nom: "+clientel.nom);
            Console.WriteLine("Prenom: " + clientel.prenom);
            Console.WriteLine("Id: " + clientel.Myid);
            Console.WriteLine("Tel: " + clientel.Tel);
            
        }
    }
}
