using ABIMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABIMS
{
    public partial class DetailContact : ABIMS.ParentContact
    {
        public DetailContact(Contact contact, Client client, ParentClient parent):base(contact, client, parent)
        {
            InitializeComponent();
            loadContact();
        }

        private void loadContact()
        {
            this.tbIdContact.Text = this.Contact.Id.ToString();
            this.tbClient.Text = (this.Client.Name != null) ? this.Client.Name : "sans nom";
            this.tbName.Text = this.Contact.Name;
            this.tbFonction.Text = this.Contact.Function;
            this.tbPhone.Text = this.Contact.Phone;
            this.tbEmail.Text = this.Contact.Email;
        }
    }
}
