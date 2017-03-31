using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIMS
{
    class Clients
    {
        List<Client> listClients;

        public Clients()
        {
            this.listClients = new List<Client>();
        }

        public void AddClient(Client client)
        {          
            listClients.Add(client);              
        }

        public void RemoveClient(Client client)
        {
            listClients.Remove(client);
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
            foreach(Client client in this.listClients)
            {
                if (client.Id == id) return client;
            }
            return null;
        }

        public IList<Client>findClientByName(String Name)
        {
            List<Client> result = new List<Client>();
            foreach (Client client in this.listClients)
            {
                if (client.Name == Name) result.Add(client);
            }
            return result;
        }




    }
}
