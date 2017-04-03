using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIMS.Model
{
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
        private Int32 staff;
        private List<Contact> contactList;
        private List<Comment> commentList;

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
    }
}
