using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBanque.Main;

namespace GestionBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Agence> agenceList = new List<Agence>();
            int choix;
            do
            {
                Console.WriteLine("**************Menu*****************");
                Console.WriteLine("1: Ajouter une agence ");
                Console.WriteLine("2: Ajouter un client ");
                Console.WriteLine("3: Creer  un compte ");
                Console.WriteLine("***********  4: Quitter **********");
                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        Console.WriteLine("*****************************************************************");    
                        Console.WriteLine("Creer une agence");
                        Console.WriteLine("Saisir le code de l'agence (Chaine de caractere)");
                        String code = Console.ReadLine();
                        Agence agnc = new Agence(code);
                        agenceList.Add(agnc);
                        Console.WriteLine("*****************************************************************");

                        break;
                    case 2:
                        Console.WriteLine("*****************************************************************");
                       

                        Console.WriteLine("Ajouter un client ");
                        foreach (var item in agenceList)
                        {
                            item.afficherDetails(item);
                        }
                        Console.WriteLine("Liste des agences ci-dessus choisissez en tapant l'id de l'agnece ");
                        int choixAgnece = int.Parse(Console.ReadLine());
                       
                        foreach (var item in agenceList)
                        {
                            if (item.Myidy==choixAgnece)
                            {
                                Console.WriteLine("Donner le nom");
                                String name = Console.ReadLine();
                                Console.WriteLine("Donner le prenom");
                                String fname= Console.ReadLine();
                                Console.WriteLine("Le numero de telephone ");
                                int tel =int .Parse(Console.ReadLine());
                                Client createCL= new Client(name, fname,tel);
                                item.ajouterClients(createCL);
                            }
                        }

                        Console.WriteLine("*****************************************************************");

                        break;
                    case 3:
                        Console.WriteLine("*****************************************************************");
                        foreach (var item in agenceList)
                        {
                            Console.WriteLine("--------------------------");

                            item.afficherDetails(item);
                            item.afficherClients();
                            Console.WriteLine("--------------------------");

                        }




                        Console.WriteLine(" Vous voulez creer un compte/ " +
                            " * 1- Compte epragne *" +
                            "* 2-Compte simple *");
                        int choixcompte=int.Parse(Console.ReadLine());


                        Console.WriteLine("*****************************************************************");
                        break;
                    default:
                        Console.WriteLine("Your choice is not avalaible");
                        break;
                }
                Console.Clear();   
            }
            while (choix != 4);
        }
    }
}
