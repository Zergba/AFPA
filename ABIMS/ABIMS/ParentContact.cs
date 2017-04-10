using ABIMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIMS
{
    public partial class ParentContact : Form
    {
        private Client client;
        protected ParentClient parent;
        private Contact contact;
       
        protected ParentContact()
        {
            InitializeComponent();
        }
        public ParentContact(Contact contact, Client client, ParentClient parent)
        {
            this.Contact = contact;
            this.parent = parent;
            this.Client = client;
            InitializeComponent();
        }
       

        public Client Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

       

        public Contact Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void btnValidate_Click(object sender, EventArgs e)
        {
            this.Contact.Name = tbName.Text;
            this.Contact.Function = tbFonction.Text;
            this.Contact.Phone = tbPhone.Text;
            this.Contact.Email = tbEmail.Text;
            this.parent.dgv.Refresh();
            this.Close();
        }
    }
}
