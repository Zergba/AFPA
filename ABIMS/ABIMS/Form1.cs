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
    public partial class Form1 : Form
    {
        private List<ListClient> listWindowListClient;
        public Form1()
        {
            this.ListWindowListClient = new List<ListClient>();
            InitializeComponent();
        }

        public List<ListClient> ListWindowListClient
        {
            get
            {
                return listWindowListClient;
            }

            set
            {
                listWindowListClient = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ListClient lc = new ListClient(this);
            this.ListWindowListClient.Add(lc);
            lc.Show();
        }
    }
}
