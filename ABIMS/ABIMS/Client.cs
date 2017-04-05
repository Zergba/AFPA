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

        private static Int32 countID = 1;
        
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
        public Int32 Id
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
        public String Name
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
        public String Type
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
        public String ActivityDomain
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
        public String Adresse
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
        public String PhoneNumber
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
        public Int32 SalesRevenu
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
        public Int32 Staff
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
        public String Nature
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

        public static int CountID
        {
            get
            {
                return countID;
            }

            set
            {
                countID = value;
            }
        }

        public Client(String name, String type,String nature, String activityDomain, String adresse, String phoneNumber, Int32 salesRevenu, Int32 staff)
        {
            this.Id = Client.CountID++;
            this.Name = name;
            this.Type = type;
            this.ActivityDomain = activityDomain;
            this.Adresse = adresse;
            this.PhoneNumber = phoneNumber;
            this.SalesRevenu = salesRevenu;
            this.Staff = staff;
        }

        public override string ToString()
        {
            return this.Id+" - "+this.Name;
        }
    }
}
