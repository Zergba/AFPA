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
    public partial class AjoutClient : ABIMS.ParentClient
    {
        /// <summary>
        /// fenetre parente
        /// </summary>
        private ListClient parent;
      
        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="parent"></param>
        public AjoutClient(ListClient parent)
        {
            this.parent = parent;
            InitializeComponent();
            tbId.Text = Client.CountID.ToString();
        }
        /// <summary>
        /// annuler la création client et fermer la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelCreationClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// au clic sur le bouton, permet la creation et la memorisation d'un nouveau client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidCreationClient_Click(object sender, EventArgs e)
        {
           try
            {
                String Name = tbName.Text;
                String Adresse = tbAdress.Text;
                String ActivityDomain = tbDA.Text;
                String PhoneNumber = tbTel.Text;
                Int32 Staff = Int32.Parse(tbStaff.Text);
                Int32 SalesRevenu = Int32.Parse(tbCA.Text);
                String typeString = comboBox1.Text;
                String TypeClient;
                String Nature;
                if (typeString == "Public")
                {
                    TypeClient = Client.TYPE_PUBLIC;
                }
                else if (typeString == "Privé")
                {
                    TypeClient = Client.TYPE_PRIVATE;
                }else
                {
                    TypeClient = null;
                }
                String natureString = comboBox2.Text;
                if (natureString == "Principale")
                {
                    Nature = Client.NATURE_MAIN;
                }
                else if (natureString == "Secondaire")
                {
                    Nature = Client.NATURE_SECONDARY;
                }
                else if (natureString == "Ancienne")
                {
                    Nature = Client.NATURE_OLD;
                }else
                {
                    Nature = null;
                }
                Client client = new Client(Name, TypeClient,Nature, ActivityDomain, Adresse, PhoneNumber, SalesRevenu, Staff);
                Clients.clients.ListClients.Add(client);
                MessageBox.Show("Le client a bien été créé", "Creation client OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.parent.Datagridview.Refresh();
                if (this.checkBox1.Checked)//si checkbox "voir fiche client" est cochée
                {
                    DetailClient dc = new DetailClient(client, parent);
                    parent.WindowsList.Add(dc);
                    parent.updateLastClientList(client);
                    dc.Show();
                    
                }
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Attention saisie incorrecte", "Creation client KO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// reinitialise les champs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetCreationClient_Click(object sender, EventArgs e)
        {
            this.tbAdress.Text = "";
            this.tbId.Text = "";
            this.tbCA.Text = "";
            this.tbDA.Text = "";
            this.tbName.Text = "";
            this.tbStaff.Text = "";
            this.tbTel.Text = "";
            this.comboBox1.Text = "";
            this.comboBox2.Text = "";
        }
    }
}
