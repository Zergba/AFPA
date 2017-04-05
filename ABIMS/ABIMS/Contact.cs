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
        Int32 id;
        Client client;
        String name;
        String function;
        String phone;
        String email;
        Int32 totalTimeWorked;

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
    }
}
