using ABIMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIMS
{
    public class Contact
    {

        private static Int32 countId = 1;

        private Int32 id;
        private Client client;
        private String name;
        private String function;
        private String phone;
        private String email;
        private Int32 totalTimeWorked;


        [System.ComponentModel.DisplayName("Nom Contact")]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        [System.ComponentModel.DisplayName("Téléphone")]
        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        [System.ComponentModel.DisplayName("Adresse Email")]
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        [System.ComponentModel.DisplayName("Temps d'intervention cumulé")]
        public int TotalTimeWorked
        {
            get
            {
                return totalTimeWorked;
            }

            set
            {
                totalTimeWorked = value;
            }
        }

        [System.ComponentModel.DisplayName("Fonction")]
        public string Function
        {
            get
            {
                return function;
            }

            set
            {
                function = value;
            }
        }

        public static int CountId
        {
            get
            {
                return countId;
            }

            set
            {
                countId = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public Contact(Client client, string name, string function, string phone, string email, int totalTimeWorked)
        {
            this.Id = Contact.CountId++;
            this.client = client;
            this.name = name;
            this.function = function;
            this.phone = phone;
            this.email = email;
            this.totalTimeWorked = totalTimeWorked;
        }

    }
}
