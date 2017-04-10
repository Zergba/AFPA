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
    public partial class ParentClient : Form
    {

        private Client client;
        protected ListClient parent;

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

        public ParentClient(Client client, ListClient parent)
        {
            this.parent = parent;
            this.Client = client;
            InitializeComponent();
            initGrid();
        }
        private void initGrid()
        {
            this.dataGridViewContact.DataSource = new BindingSource(this.Client.ContactList, null);
            this.dataGridViewContact.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewContact.CurrentRow;
            Contact contact = (Contact)row.DataBoundItem;
            Client.ContactList.Remove(contact);
            dataGridViewContact.Refresh();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AjoutContact ac = new AjoutContact(Client, this.dataGridViewContact);
            ac.ShowDialog();
        }


        private void btnAddClient_Click(object sender, EventArgs e)
        {
            this.Client.CommentList.Add(new Comment(this.tbAddComment.Text));
            this.tbAddComment.Text = "";
            this.lbComment.Refresh();
        }

      


        private void button6_Click(object sender, EventArgs e)
        {
            Comment comm = (Comment)lbComment.SelectedItem;
            if (comm != null && MessageBox.Show("Êtes vous sûr de vouloir supprimer ce commentaire ?", "Supprimer Commentaire", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Client.CommentList.Remove(comm);
                this.lbComment.Refresh();
            }
        }
    }   
}
