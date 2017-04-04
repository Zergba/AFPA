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
        private ListClient parent;
      

        public AjoutClient(ListClient parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btnCancelCreationClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidCreationClient_Click(object sender, EventArgs e)
        {
           try
            {
                Int32 Id = Int32.Parse(tbId.Text);
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
                Client client = new Client(Id, Name, TypeClient, ActivityDomain, Adresse, PhoneNumber, SalesRevenu, Staff);
                Clients.clients.ListClients.Add(client);
                MessageBox.Show("Le client a bien été créé", "Creation client OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.parent.Datagridview.Refresh();
                if (this.checkBox1.Checked)
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
    }
}
