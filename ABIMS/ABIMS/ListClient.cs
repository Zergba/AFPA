﻿using System;
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

        private List<DetailClient> windowsList; 

        private List<Client> lastClientList;

        private BindingSource source;

        public List<DetailClient> WindowsList
        {
            get
            {
                return windowsList;
            }

            set
            {
                windowsList = value;
            }
        }

        public List<Client> LastClientList
        {
            get
            {
                return lastClientList;
            }

            set
            {
                lastClientList = value;
            }
        }

        public DataGridView Datagridview
        {
            get
            {
                return this.dataGridView1;
            }
        }

        public ListClient(Form parent)
        {         
            this.WindowsList = new List<DetailClient>();
            this.LastClientList = new List<Client>();
            this.source = new BindingSource(Clients.clients.ListClients, null);
            InitializeComponent();
            initGrid();
        }

        private void populateGrid()
        {
            this.dataGridView1.DataSource = source;
            this.dataGridView1.Refresh();
        }
        private void initGrid()
        {
            this.dataGridView1.DataSource = new BindingList<Client>();
            this.dataGridView1.Refresh();
        }

        public void updateLastClientList(Client client)
        {
            if (this.cbbLastsSeen.Items.Count >= 10) this.cbbLastsSeen.Items.RemoveAt(0);
            if(!this.cbbLastsSeen.Items.Contains(client))this.cbbLastsSeen.Items.Add(client);
        }
        public void deleteLastClientList(Client client)
        {
            if(!Clients.clients.ListClients.Contains(client)&& this.cbbLastsSeen.Items.Contains(client))
                this.cbbLastsSeen.Items.Remove(client);
        }
       
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Client client = (Client)dataGridView1.CurrentRow.DataBoundItem;
            DetailClient dc = new DetailClient(client,this);
            updateLastClientList(client);
            WindowsList.Add(dc);
            dc.Show();    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AjoutClient ac = new AjoutClient(this);
            ac.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection SelectedRows = dataGridView1.SelectedRows;
            foreach(DataGridViewRow row in SelectedRows)
            {
                Client client = (Client)row.DataBoundItem;
                DetailClient dc = new DetailClient(client,this);
                updateLastClientList(client);
                WindowsList.Add(dc);
                dc.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<DetailClient> temp = new List<DetailClient>();
            foreach(DetailClient dc in WindowsList)
            {
                if (!dc.CbKeepOpen.Checked)
                {
                    temp.Add(dc);
                }
            }
            foreach(DetailClient dc in temp)
            {
                dc.Close();
                WindowsList.Remove(dc);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection SelectedRows = dataGridView1.SelectedRows;
            if (MessageBox.Show("Êtes vous sûr de vouloir supprimer ce(s) client(s) ?", "Supprimer Clients", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    foreach (DataGridViewRow row in SelectedRows)
                    {
                        Client client = (Client)row.DataBoundItem;
                        Clients.clients.RemoveClient(client);
                        deleteLastClientList(client);
                    }
                    MessageBox.Show("Le(s) client(s) a(ont) bien été supprimé(s)", "Supprimer Clients OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.Refresh();
                }catch(Exception ex)
                {
                    MessageBox.Show("Impossible de supprimer tous les client", "Supprimer Client KO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cbbLastsSeen.SelectedItem != null)
            {
                Client client = (Client)cbbLastsSeen.SelectedItem;
                DetailClient dc = new DetailClient(client, this);
                dc.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            initGrid();
        }
    }
}
