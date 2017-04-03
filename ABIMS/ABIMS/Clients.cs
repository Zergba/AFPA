
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

        private static Clients _clients = null;


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

        public Clients()
        {
            this.ListClients = new BindingList<Client>();
            this.test();
        }

        public void AddClient(Client client)
        {          
            ListClients.Add(client);              
        }

        public void RemoveClient(Client client)
        {
            ListClients.Remove(client);
        }

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
        public Client findClientByID(Int32 id)
        {
            foreach(Client client in this.ListClients)
            {
                if (client.Id == id) return client;
            }
            return null;
        }

        public List<Client>findClientByName(String Name)
        {
            List<Client> result = new List<Client>();
            foreach (Client client in this.ListClients)
            {
                if (client.Name == Name) result.Add(client);
            }
            return result;
        }

        public void test()
        {
            this.ListClients.Add(new Model.Client(1, "a", Client.TYPE_PUBLIC, "", "", "0123456789", 1, 1));
            this.ListClients.Add(new Model.Client(2, "aa", Client.TYPE_PUBLIC, "", "", "0123456789", 1, 1));
            this.ListClients.Add(new Model.Client(3, "b", Client.TYPE_PUBLIC, "", "", "0123456789", 1, 1));
            this.ListClients.Add(new Model.Client(4, "bc", Client.TYPE_PUBLIC, "", "", "0123456789", 1, 1));
            this.ListClients.Add(new Model.Client(5, "bcb", Client.TYPE_PRIVATE, "", "", "0123456789", 1, 1));
        }




    }
}
