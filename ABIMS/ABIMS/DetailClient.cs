using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ABIMS.Model;

namespace ABIMS
{
    public partial class DetailClient : ABIMS.ParentClient
    {
        private Client client;
        private DataGridView dgv;
        public DetailClient(Client client, DataGridView dgv)
        {
            this.Client = client;
            this.dgv = dgv;
            InitializeComponent();
            loadClient();
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
        public void loadClient()
        {
            this.tbId.Text = this.Client.Id.ToString();
            this.tbAdress.Text = this.Client.Adresse;
            this.tbName.Text = this.Client.Name;
            this.tbCA.Text = this.Client.SalesRevenu.ToString();
            this.tbStaff.Text = this.Client.Staff.ToString();
            this.tbTel.Text = this.Client.PhoneNumber;
            this.tbDA.Text = this.Client.ActivityDomain;
            if (this.Client.Type == Client.TYPE_PRIVATE)
            {
                this.comboBox1.SelectedIndex = 0;
            }else if(this.Client.Type == Client.TYPE_PUBLIC)
            {
                this.comboBox1.SelectedIndex = 1;
            }
        }

        private void cbModifications_CheckedChanged(object sender, EventArgs e)
        {            
            this.tbId.Enabled = !this.tbId.Enabled;
            this.tbName.Enabled = !this.tbName.Enabled;
            this.tbAdress.Enabled = !this.tbAdress.Enabled;
            this.tbCA.Enabled = !this.tbCA.Enabled;
            this.tbDA.Enabled = !this.tbDA.Enabled;
            this.tbStaff.Enabled = !this.tbStaff.Enabled;
            this.tbTel.Enabled = !this.tbTel.Enabled;
            this.comboBox1.Enabled = !this.comboBox1.Enabled;
            this.comboBox2.Enabled = !this.comboBox2.Enabled;
            this.btnValidModif.Enabled = !this.btnValidModif.Enabled;
            this.btnCancelModif.Enabled = !this.btnCancelModif.Enabled;
        }

        private void btnCancelModif_Click(object sender, EventArgs e)
        {
            this.loadClient();
        }

        private void btnValidModif_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("valider les modifications ?", "Valider modification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    this.Client.Id = Int32.Parse(tbId.Text);
                    this.Client.Name = tbName.Text;
                    this.Client.Adresse = tbAdress.Text;
                    this.Client.ActivityDomain = tbDA.Text;
                    this.Client.PhoneNumber = tbTel.Text;
                    this.Client.Staff = Int32.Parse(tbStaff.Text);
                    this.Client.SalesRevenu = Int32.Parse(tbCA.Text);
                    String typeString = comboBox1.Text;
                    if (typeString == "Public")
                    {
                        this.Client.Type = Client.TYPE_PUBLIC;
                    }
                    else if (typeString == "Privé")
                    {
                        this.Client.Type = Client.TYPE_PRIVATE;
                    }
                    String natureString = comboBox2.Text;
                    if (natureString == "Principale")
                    {
                        this.Client.Nature = Client.NATURE_MAIN;
                    }
                    else if (natureString == "Secondaire")
                    {
                        this.Client.Nature = Client.NATURE_SECONDARY;
                    }
                    else if (natureString == "Ancienne")
                    {
                        this.Client.Nature = Client.NATURE_OLD;
                    }
                    MessageBox.Show("Le client a bien été modifié", "valider modification OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgv.Refresh();
                }catch(Exception ex)
                {
                    MessageBox.Show("Attention saisie incorrecte", "valider modification KO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes vous sûr de vouloir supprimer ce client ?", "Supprimer Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    Clients.clients.ListClients.Remove(this.Client);
                    MessageBox.Show("Le client a bien été supprimé", "Supprimer Client OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgv.Refresh();
                    this.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("Impossible de supprimer le client", "Supprimer Client KO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
