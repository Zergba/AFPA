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
        /// <summary>
        /// formulaire parent 
        /// </summary>
        private Form1 parent;
        /// <summary>
        /// liste des fenetres clients actuellement ouverte
        /// </summary>
        private List<DetailClient> windowsList;
        /// <summary>
        /// liste des derniers clients consultés
        /// </summary>
        private List<Client> lastClientList;
        /// <summary>
        ///source du datagrid
        /// </summary>
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
        /// <summary>
        /// accesseur vers le datagridview (principalement pour refresh)
        /// </summary>
        public DataGridView Datagridview
        {
            get
            {
                return this.dataGridView1;
            }
        }
        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="parent"></param>
        public ListClient(Form1 parent)
        {
            this.parent = parent; 
            this.WindowsList = new List<DetailClient>();
            this.LastClientList = new List<Client>();
            this.source = new BindingSource(Clients.clients.ListClients, null);
            InitializeComponent();
            initGrid();
        }
        /// <summary>
        /// peuple le datagrid depuis la source
        /// </summary>
        private void populateGrid()
        {
            this.dataGridView1.DataSource = source;
            this.dataGridView1.Refresh();
        }
        /// <summary>
        /// initialisation du datagrid
        /// </summary>
        private void initGrid()
        {
            this.dataGridView1.DataSource = new BindingList<Client>();
            this.dataGridView1.Refresh();
        }
        /// <summary>
        /// fermer les fiches clients d'un client qui vient d'etre supprimé
        /// </summary>
        /// <param name="client"></param>
        public void closeDeletedClient(Client client)
        {
            List<DetailClient> ldc = new List<DetailClient>();
            foreach(ListClient lc in parent.ListWindowListClient)
            {
                foreach(DetailClient dc in lc.windowsList)
                {
                    if (dc.Client == client) ldc.Add(dc);
                }
            }
            foreach (DetailClient dc in ldc)
            {
                dc.Close();
            }
        }
        /// <summary>
        /// garder en mémoire les derniers clients consultés sans doublons
        /// </summary>
        /// <param name="client"></param>
        public void updateLastClientList(Client client)
        {
            if (this.cbbLastsSeen.Items.Count >= 10) this.cbbLastsSeen.Items.RemoveAt(0);
            if(!this.cbbLastsSeen.Items.Contains(client))this.cbbLastsSeen.Items.Add(client);
        }
        /// <summary>
        /// enleve de l'historique de clients consultés un client qui aurait été supprimé
        /// </summary>
        /// <param name="client"></param>
        public void deleteLastClientList(Client client)
        {
            if(!Clients.clients.ListClients.Contains(client)&& this.cbbLastsSeen.Items.Contains(client))
                this.cbbLastsSeen.Items.Remove(client);
        }
       /// <summary>
       /// ouvrir une fiche client au double clic sur le datagridview
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Client client = (Client)dataGridView1.CurrentRow.DataBoundItem;
                DetailClient dc = new DetailClient(client, this);
                updateLastClientList(client);
                WindowsList.Add(dc);
                dc.Show();
            }  
        }

        /// <summary>
        /// ouvre une fenetre de création client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            AjoutClient ac = new AjoutClient(this);
            ac.ShowDialog();
        }
        /// <summary>
        /// ouvres les fiches clients de tous les clients selectionnés dans le datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// ferme toutes les fiches clients ouvertes dont la checkbox "garder ouvert" n'est pas cochée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            List<DetailClient> temp = new List<DetailClient>();
            foreach (ListClient lc in parent.ListWindowListClient)
            {
                foreach (DetailClient dc in lc.WindowsList)
                {
                    if (!dc.CbKeepOpen.Checked)
                    {
                        temp.Add(dc);
                    }
                }
            }
            foreach(DetailClient dc in temp)
            {
                dc.Close();
                WindowsList.Remove(dc);
            }
        }
        /// <summary>
        /// supprimer tous les clients selectionnés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection SelectedRows = dataGridView1.SelectedRows;
            if (MessageBox.Show("Êtes vous sûr de vouloir supprimer ce(s) client(s) ? (les fiches clients ouvertes seront fermées)", "Supprimer Clients", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    foreach (DataGridViewRow row in SelectedRows)
                    {
                        Client client = (Client)row.DataBoundItem;
                        Clients.clients.RemoveClient(client);
                        deleteLastClientList(client);
                        closeDeletedClient(client);
                    }
                    MessageBox.Show("Le(s) client(s) a(ont) bien été supprimé(s)", "Supprimer Clients OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.Refresh();
                    
                }catch(Exception ex)
                {
                    MessageBox.Show("Impossible de supprimer tous les client", "Supprimer Client KO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// ouvre une fiche de detail client parmi l'historique de clients consultés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            if (cbbLastsSeen.SelectedItem != null)
            {
                Client client = (Client)cbbLastsSeen.SelectedItem;
                DetailClient dc = new DetailClient(client, this);
                dc.Show();
            }
        }
        /// <summary>
        /// affiche le datagridview avec la liste de client complete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            populateGrid();
        }
        /// <summary>
        /// vide le datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            initGrid();
        }
        /// <summary>
        /// rechercher un client en fonction de son nom ou de son ID, si l'option correspondante est cochée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            String strSearch = this.tbSearch.Text;
            BindingList<Client> searchList = new BindingList<Client>();

            if (cbIdClient.Checked)
            {
                try
                {
                    searchList.Add(Clients.clients.findClientByID(Int32.Parse(strSearch)));
                }catch(Exception ex)
                {
                    //MessageBox.Show("recherche par ID impossible", "chercher client par ID KO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (cbNameClient.Checked)
            {
                List<Client> lc = Clients.clients.findClientByName(strSearch);
                foreach(Client client in lc)
                {
                    searchList.Add(client);
                }

            }
            if (cbNameContact.Checked)
            {
                List<Client> lc = Clients.clients.findClientByContactName(strSearch);
                foreach (Client client in lc)
                {
                    searchList.Add(client);
                }
            }
            if (cbIdContact.Checked)
            {
                try
                {
                    searchList.Add(Clients.clients.findClientByContactId(Int32.Parse(strSearch)));
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("recherche par ID impossible", "chercher client par ID KO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Datagridview.DataSource = searchList;
            this.tbSearch.Text = "Saisir les termes de votre recherche";
        }

        /// <summary>
        /// a la fermeture de cette fenetre, permet au parent d'oublier cette fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parent.ListWindowListClient.Remove(this);
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Saisir les termes de votre recherche")
            {
                tbSearch.Text = "";
            }
        }
    }
}
