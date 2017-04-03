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
            DetailClient dc = new DetailClient(client);
            windows_list.Add(dc);
            dc.Show();    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
