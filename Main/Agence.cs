using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Main
{
    internal class Agence
    {
        private static int id = 0;
        public int Myidy { get; set; }

        private string code { get; set; }
        private string libelle;
        private List<Client> clients = new List<Client>();

        private String genLib(int id, String codec)
        {
            return (id + codec.Substring(0, 3));
        }

        public Agence(string code)
        {
            this.Myidy = ++id;
            this.code = code;
            this.libelle = genLib(Myidy, code);
            

        }
        
        public void afficherDetails(Agence agence)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Code Agence: " +  agence.code);
            Console.WriteLine("Id Agence: " + agence.Myidy);
            Console.WriteLine("Libelle Agence: " + agence.libelle);
            Console.WriteLine("--------------------------");

        }

        public void ajouterClients(Client client)
        {
            clients.Add(client);
        }
        public void afficherClients( ) {

            foreach (var item in clients)
            {
                Console.WriteLine("--------------------------");

                item.afficherDetails(item);
                Console.WriteLine("--------------------------");

            }
        }
    }
}
