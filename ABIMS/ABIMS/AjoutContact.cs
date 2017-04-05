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
    public partial class AjoutContact : Form
    {
        private Client client;
        DataGridView dgv;
       
        public AjoutContact(Client client, DataGridView dgv)
        {
            this.Dgv = dgv;
            this.Client = client;
            InitializeComponent();
            this.tbIdContact.Text = Contact.CountId.ToString();
            this.tbClient.Text = (this.Client.Name!=null)?this.Client.Name:"sans nom";
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

        public DataGridView Dgv
        {
            get
            {
                return dgv;
            }

            set
            {
                dgv = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Client.ContactList.Add(new Contact(this.Client, tbName.Text, tbFonction.Text, tbPhone.Text, tbEmail.Text, 0));
            this.Dgv.Refresh();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
