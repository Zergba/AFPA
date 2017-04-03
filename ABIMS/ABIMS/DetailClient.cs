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
        public DetailClient(Client client)
        {
            this.Client = client;
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
        }
    }
}
