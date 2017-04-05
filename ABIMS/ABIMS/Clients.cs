
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIMS.Model
{
    public class Clients
    {
        /// <summary>
        /// singleton
        /// </summary>
        private static Clients _clients = null;

        /// <summary>
        /// liste de clients
        /// </summary>
        private BindingList<Client> listClients;

        public static Clients clients
        {
            get
            {
                if (_clients == null)
                {
                    _clients = new Clients();
                }
                return _clients;
            }
        }
       
        public BindingList<Client> ListClients
        {
            get
            {
                return listClients;
            }

            set
            {
                listClients = value;
            }
        }
        /// <summary>
        /// constructeur
        /// </summary>
        public Clients()
        {
            this.ListClients = new BindingList<Client>();
            this.test();
        }
        /// <summary>
        /// ajouter un client à la liste
        /// </summary>
        /// <param name="client"></param>
        public void AddClient(Client client)
        {          
            ListClients.Add(client);              
        }
        /// <summary>
        /// supprimer un client de la liste
        /// </summary>
        /// <param name="client"></param>
        public void RemoveClient(Client client)
        {
            ListClients.Remove(client);
        }
        /// <summary>
        /// mettre à jour le client
        /// </summary>
        /// <param name="client"></param>
        /// <param name="Id"></param>
        /// <param name="Name"></param>
        /// <param name="Type"></param>
        /// <param name="ActivityDomain"></param>
        /// <param name="Adresse"></param>
        /// <param name="PhoneNumber"></param>
        /// <param name="SalesRevenu"></param>
        /// <param name="Staff"></param>
        public void UpdateClient(Client client, Int32 Id, String Name, String Type, String ActivityDomain, String Adresse, String PhoneNumber, Int32 SalesRevenu, Int32 Staff)
        {
            client.Id = Id;
            client.Name = Name;
            client.Type = Type;
            client.ActivityDomain = ActivityDomain;
            client.Adresse = Adresse;
            client.PhoneNumber = PhoneNumber;
            client.SalesRevenu = SalesRevenu;
            client.Staff = Staff;
        }
        /// <summary>
        /// retourne un client en fonction de son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Client findClientByID(Int32 id)
        {
            foreach(Client client in this.ListClients)
            {
                if (client.Id == id) return client;
            }
            return null;
        }
        /// <summary>
        /// retourne une liste de clients en fonction du nom client
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<Client>findClientByName(String Name)
        {
            List<Client> result = new List<Client>();
            foreach (Client client in this.ListClients)
            {
                if (client.Name==Name)result.Add(client);
            }
            return result;
        }
        /// <summary>
        /// jeu d'essai
        /// </summary>
        public void test()
        {
            this.ListClients.Add(new Model.Client("a", Client.TYPE_PUBLIC,Client.NATURE_MAIN, "maïs", "2 rue de la republique", "0123456789", 1, 1));
            this.ListClients.Add(new Model.Client("aa", Client.TYPE_PUBLIC, Client.NATURE_OLD, "blé", "blablabla", "0123456789", 1, 1));
            this.ListClients.Add(new Model.Client("b", Client.TYPE_PUBLIC, Client.NATURE_SECONDARY, "fromage", "adresse lambda", "0123456789", 1, 1));
            this.ListClients.Add(new Model.Client("bc", Client.TYPE_PUBLIC, Client.NATURE_MAIN, "lait", "trop loin", "0123456789", 1, 1));
            this.ListClients.Add(new Model.Client("bcb", Client.TYPE_PRIVATE, Client.NATURE_MAIN, "porc", "assez proche", "0123456789", 1, 1));
            this.ListClients.Add(new Model.Client("a", Client.TYPE_PRIVATE, Client.NATURE_MAIN, "poulet", "derriere toi", "0123456789", 1, 1));
            this.ListClients.Add(new Model.Client("3", Client.TYPE_PRIVATE, Client.NATURE_MAIN, "poulet", "derriere toi", "0123456789", 1, 1));
        }
    }
}
