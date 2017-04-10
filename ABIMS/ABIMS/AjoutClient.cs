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
        /// constructeur
        /// </summary>
        /// <param name="parent"></param>
        public AjoutClient(Client client, ListClient parent):base(client, parent)
        {
           
            InitializeComponent();
            tbId.Text = Client.CountID.ToString();
            this.lbComment.DataSource = new BindingSource(this.Client.CommentList, null);
            
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
                }else
                {
                    this.Client.Type = null;
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
                }else
                {
                    this.Client.Nature = null;
                }
               
                Clients.clients.ListClients.Add(Client);
                MessageBox.Show("Le client a bien été créé", "Creation client OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.parent.Datagridview.Refresh();
                if (this.checkBox1.Checked)//si checkbox "voir fiche client" est cochée
                {
                    DetailClient dc = new DetailClient(Client, parent);
                    parent.WindowsList.Add(dc);
                    parent.updateLastClientList(Client);
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
