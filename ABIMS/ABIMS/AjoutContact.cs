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
    public partial class AjoutContact : ABIMS.ParentContact
    {
        public AjoutContact(Client client, ParentClient parent):base(new Contact(client, null,null,null,null,0), client, parent)
        { 
            InitializeComponent();
            this.tbIdContact.Text = Contact.Id.ToString();
            this.tbClient.Text = (this.Client.Name != null) ? this.Client.Name : "sans nom";
        }

        protected override void btnValidate_Click(object sender, EventArgs e)
        {
            this.Client.ContactList.Add(this.Contact);
            base.btnValidate_Click(sender, e); 
        }
    }
}
