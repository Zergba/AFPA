using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIMS.Model
{
    [Serializable]
    public class Client
    {

        public const String TYPE_PUBLIC = "publique";
        public const String TYPE_PRIVATE = "privée";
        public const String NATURE_MAIN = "principale";
        public const String NATURE_SECONDARY = "secondaire";
        public const String NATURE_OLD = "Ancienne";

        
        private Int32 id;
        private String name;
        private String type;
        private String activityDomain;
        private String adresse;
        private String phoneNumber;
        private Int32 salesRevenu;
        private String nature;
        private Int32 staff;
        private List<Contact> contactList;
        private List<Comment> commentList;

        [System.ComponentModel.DisplayName("Id")]
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
        [System.ComponentModel.DisplayName("Raison sociale")]
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

        [System.ComponentModel.DisplayName("Type")]
        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        [System.ComponentModel.DisplayName("Domaine d'activité")]
        public string ActivityDomain
        {
            get
            {
                return activityDomain;
            }

            set
            {
                activityDomain = value;
            }
        }

        [System.ComponentModel.DisplayName("Adresse")]
        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        [System.ComponentModel.DisplayName("Téléphone")]
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        [System.ComponentModel.DisplayName("Chiffre d'affaire")]
        public int SalesRevenu
        {
            get
            {
                return salesRevenu;
            }

            set
            {
                salesRevenu = value;
            }
        }

        [System.ComponentModel.DisplayName("Effectif")]
        public int Staff
        {
            get
            {
                return staff;
            }

            set
            {
                staff = value;
            }
        }

        internal List<Contact> ContactList
        {
            get
            {
                return contactList;
            }

            set
            {
                contactList = value;
            }
        }

        internal List<Comment> CommentList
        {
            get
            {
                return commentList;
            }

            set
            {
                commentList = value;
            }
        }

        [System.ComponentModel.DisplayName("Nature")]
        public string Nature
        {
            get
            {
                return nature;
            }

            set
            {
                nature = value;
            }
        }

        public Client(int id, string name, string type, string activityDomain, string adresse, string phoneNumber, int salesRevenu, int staff)
        {
            Id = id;
            Name = name;
            Type = type;
            ActivityDomain = activityDomain;
            Adresse = adresse;
            PhoneNumber = phoneNumber;
            SalesRevenu = salesRevenu;
            Staff = staff;
        }

        public override string ToString()
        {
            return this.Id+" - "+this.Name;
        }
    }
}
