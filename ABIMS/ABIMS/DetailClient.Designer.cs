namespace ABIMS
{
    partial class DetailClient
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnValidModif = new System.Windows.Forms.Button();
            this.btnCancelModif = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.cbKeepOpen = new System.Windows.Forms.CheckBox();
            this.cbModifications = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(15, 35);
            // 
            // tbStaff
            // 
            this.tbStaff.Enabled = false;
            // 
            // tbCA
            // 
            this.tbCA.Enabled = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            // 
            // tbTel
            // 
            this.tbTel.Enabled = false;
            // 
            // tbAdress
            // 
            this.tbAdress.Enabled = false;
            // 
            // tbDA
            // 
            this.tbDA.Enabled = false;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.Text = "Identifiant Client";
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(15, 323);
            this.tabControl1.Size = new System.Drawing.Size(517, 289);
            // 
            // tabPage1
            // 
            this.tabPage1.Size = new System.Drawing.Size(509, 263);
            // 
            // tabPage2
            // 
            this.tabPage2.Size = new System.Drawing.Size(509, 263);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(228, 232);
            this.button4.Size = new System.Drawing.Size(119, 23);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 232);
            this.button3.Size = new System.Drawing.Size(113, 23);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 232);
            this.button2.Size = new System.Drawing.Size(108, 23);
            // 
            // button1
            // 
            this.button1.Size = new System.Drawing.Size(102, 23);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            // 
            // btnValidModif
            // 
            this.btnValidModif.Enabled = false;
            this.btnValidModif.Location = new System.Drawing.Point(13, 631);
            this.btnValidModif.Name = "btnValidModif";
            this.btnValidModif.Size = new System.Drawing.Size(114, 23);
            this.btnValidModif.TabIndex = 2;
            this.btnValidModif.Text = "Valider modifications";
            this.btnValidModif.UseVisualStyleBackColor = true;
            this.btnValidModif.Click += new System.EventHandler(this.btnValidModif_Click);
            // 
            // btnCancelModif
            // 
            this.btnCancelModif.Enabled = false;
            this.btnCancelModif.Location = new System.Drawing.Point(133, 631);
            this.btnCancelModif.Name = "btnCancelModif";
            this.btnCancelModif.Size = new System.Drawing.Size(123, 23);
            this.btnCancelModif.TabIndex = 3;
            this.btnCancelModif.Text = "Annuler modifications";
            this.btnCancelModif.UseVisualStyleBackColor = true;
            this.btnCancelModif.Click += new System.EventHandler(this.btnCancelModif_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(372, 631);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(156, 23);
            this.btnDeleteClient.TabIndex = 4;
            this.btnDeleteClient.Text = "Supprimer le client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // cbKeepOpen
            // 
            this.cbKeepOpen.AutoSize = true;
            this.cbKeepOpen.Location = new System.Drawing.Point(432, 12);
            this.cbKeepOpen.Name = "cbKeepOpen";
            this.cbKeepOpen.Size = new System.Drawing.Size(93, 17);
            this.cbKeepOpen.TabIndex = 5;
            this.cbKeepOpen.Text = "Garder Ouvert";
            this.cbKeepOpen.UseVisualStyleBackColor = true;
            // 
            // cbModifications
            // 
            this.cbModifications.AutoSize = true;
            this.cbModifications.Location = new System.Drawing.Point(338, 12);
            this.cbModifications.Name = "cbModifications";
            this.cbModifications.Size = new System.Drawing.Size(88, 17);
            this.cbModifications.TabIndex = 6;
            this.cbModifications.Text = "Modifications";
            this.cbModifications.UseVisualStyleBackColor = true;
            this.cbModifications.CheckedChanged += new System.EventHandler(this.cbModifications_CheckedChanged);
            // 
            // DetailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(538, 666);
            this.Controls.Add(this.cbModifications);
            this.Controls.Add(this.cbKeepOpen);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnCancelModif);
            this.Controls.Add(this.btnValidModif);
            this.Name = "DetailClient";
            this.Text = "ABIMS - Détail Client";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.btnValidModif, 0);
            this.Controls.SetChildIndex(this.btnCancelModif, 0);
            this.Controls.SetChildIndex(this.btnDeleteClient, 0);
            this.Controls.SetChildIndex(this.cbKeepOpen, 0);
            this.Controls.SetChildIndex(this.cbModifications, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidModif;
        private System.Windows.Forms.Button btnCancelModif;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.CheckBox cbKeepOpen;
        private System.Windows.Forms.CheckBox cbModifications;
    }
}
