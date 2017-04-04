using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using ABIMS.Model;

namespace ABIMS
{
    public partial class ListClient : Form
    {

        static List<DetailClient>windows_list = new List<DetailClient>();

        private BindingSource source;

        public ListClient(Form parent)
        {         
            InitializeComponent();
            initGrid();
        }
        private void initGrid()
        {
            this.source = new BindingSource(Clients.clients.ListClients, null);
            this.dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Client client = (Client)dataGridView1.CurrentRow.DataBoundItem;
            DetailClient dc = new DetailClient(client, this.dataGridView1, windows_list);
            windows_list.Add(dc);
            dc.Show();    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AjoutClient ac = new AjoutClient(this.dataGridView1, windows_list);
            ac.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection SelectedRows = dataGridView1.SelectedRows;
            foreach(DataGridViewRow row in SelectedRows)
            {
                Client client = (Client)row.DataBoundItem;
                DetailClient dc = new DetailClient(client, this.dataGridView1, windows_list);
                windows_list.Add(dc);
                dc.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<DetailClient> temp = new List<DetailClient>();
            foreach(DetailClient dc in windows_list)
            {
                if (!dc.CbKeepOpen.Checked)
                {
                    temp.Add(dc);
                }
            }
            foreach(DetailClient dc in temp)
            {
                dc.Close();
                windows_list.Remove(dc);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection SelectedRows = dataGridView1.SelectedRows;
            if (MessageBox.Show("Êtes vous sûr de vouloir supprimer ces clients ?", "Supprimer Clients", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    foreach (DataGridViewRow row in SelectedRows)
                    {
                        Client client = (Client)row.DataBoundItem;
                        Clients.clients.RemoveClient(client);
                    }
                    MessageBox.Show("Les client ont bien été supprimés", "Supprimer Clients OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.Refresh();
                }catch(Exception ex)
                {
                    MessageBox.Show("Impossible de supprimer tous les client", "Supprimer Client KO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
