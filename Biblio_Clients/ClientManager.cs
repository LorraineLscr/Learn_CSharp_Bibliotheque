using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Clients
{
    internal class ClientManager
    {
        public static void Main()
        {

            // Créer une liste de clients
            List<Client> clients = new List<Client>();

            clients.Add(new Client() { Id = 1, Name = "ELSYLOG", City = "Denestanville" });
            clients.Add(new Client() { Id = 2, Name = "INTERMARCHE", City = "Saint-Nicolas-d'Aliermont" });
            clients.Add(new Client() { Id = 3, Name = "AGORINFO", City = "Isneauville" });

            // Parcourir la liste avec la boucle foreach
            foreach (Client item in clients)
            {
                Console.WriteLine("Id : " + item.Id + " " + item.Name + " City : " + item.City + "\n");
            }

            // Rechercher un client avec la méthode Find
            Console.WriteLine("Rechercher : ");
            string searchString = Console.ReadLine();
            Client c = clients.Find(c => c.Name == searchString);
            if (c != null)
                Console.WriteLine("Id : " + c.Id + " Name : " + c.Name + " City : " + c.City + "\n");
            else
                Console.WriteLine("Pas trouvé");


        }
    }
}
