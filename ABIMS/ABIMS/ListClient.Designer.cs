using ABIMS.Model;
using System.Resources;
using System.Windows.Forms;

namespace ABIMS
{
    partial class ListClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListClient));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerLesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.réouvrirLeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToutesLesFenêtresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.afficherListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viderListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.åProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.åProposToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbIdContact = new System.Windows.Forms.CheckBox();
            this.cbNameContact = new System.Windows.Forms.CheckBox();
            this.cbNameClient = new System.Windows.Forms.CheckBox();
            this.cbIdClient = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.cbbLastsSeen = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.clientsToolStripMenuItem,
            this.åProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem1.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripSeparator1,
            this.afficherListeToolStripMenuItem,
            this.viderListeToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnClientToolStripMenuItem,
            this.voirLesClientsToolStripMenuItem,
            this.supprimerLesClientsToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Gestion client";
            // 
            // ajouterUnClientToolStripMenuItem
            // 
            this.ajouterUnClientToolStripMenuItem.Name = "ajouterUnClientToolStripMenuItem";
            this.ajouterUnClientToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ajouterUnClientToolStripMenuItem.Text = "Ajouter un client";
            this.ajouterUnClientToolStripMenuItem.Click += new System.EventHandler(this.button4_Click);
            // 
            // voirLesClientsToolStripMenuItem
            // 
            this.voirLesClientsToolStripMenuItem.Name = "voirLesClientsToolStripMenuItem";
            this.voirLesClientsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.voirLesClientsToolStripMenuItem.Text = "voir les clients";
            this.voirLesClientsToolStripMenuItem.Click += new System.EventHandler(this.button5_Click);
            // 
            // supprimerLesClientsToolStripMenuItem
            // 
            this.supprimerLesClientsToolStripMenuItem.Name = "supprimerLesClientsToolStripMenuItem";
            this.supprimerLesClientsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.supprimerLesClientsToolStripMenuItem.Text = "Supprimer les clients";
            this.supprimerLesClientsToolStripMenuItem.Click += new System.EventHandler(this.button6_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.réouvrirLeClientToolStripMenuItem,
            this.fermerToutesLesFenêtresToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "Fenêtres";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // réouvrirLeClientToolStripMenuItem
            // 
            this.réouvrirLeClientToolStripMenuItem.Name = "réouvrirLeClientToolStripMenuItem";
            this.réouvrirLeClientToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.réouvrirLeClientToolStripMenuItem.Text = "Réouvrir le client";
            this.réouvrirLeClientToolStripMenuItem.Click += new System.EventHandler(this.réouvrirLeClientToolStripMenuItem_Click);
            // 
            // fermerToutesLesFenêtresToolStripMenuItem
            // 
            this.fermerToutesLesFenêtresToolStripMenuItem.Name = "fermerToutesLesFenêtresToolStripMenuItem";
            this.fermerToutesLesFenêtresToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.fermerToutesLesFenêtresToolStripMenuItem.Text = "Fermer toutes les fenêtres";
            this.fermerToutesLesFenêtresToolStripMenuItem.Click += new System.EventHandler(this.fermerToutesLesFenêtresToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // afficherListeToolStripMenuItem
            // 
            this.afficherListeToolStripMenuItem.Name = "afficherListeToolStripMenuItem";
            this.afficherListeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afficherListeToolStripMenuItem.Text = "Afficher Liste";
            this.afficherListeToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // viderListeToolStripMenuItem
            // 
            this.viderListeToolStripMenuItem.Name = "viderListeToolStripMenuItem";
            this.viderListeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viderListeToolStripMenuItem.Text = "Vider Liste";
            this.viderListeToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // åProposToolStripMenuItem
            // 
            this.åProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.åProposToolStripMenuItem1});
            this.åProposToolStripMenuItem.Name = "åProposToolStripMenuItem";
            this.åProposToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.åProposToolStripMenuItem.Text = "?";
            // 
            // åProposToolStripMenuItem1
            // 
            this.åProposToolStripMenuItem1.Name = "åProposToolStripMenuItem1";
            this.åProposToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.åProposToolStripMenuItem1.Text = "Å Propos";
            this.åProposToolStripMenuItem1.Click += new System.EventHandler(this.åProposToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbSearch);
            this.groupBox1.Controls.Add(this.cbIdContact);
            this.groupBox1.Controls.Add(this.cbNameContact);
            this.groupBox1.Controls.Add(this.cbNameClient);
            this.groupBox1.Controls.Add(this.cbIdClient);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(187, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(7, 68);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(187, 20);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.Text = "Saisir les termes de votre recherche";
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            // 
            // cbIdContact
            // 
            this.cbIdContact.AutoSize = true;
            this.cbIdContact.Location = new System.Drawing.Point(7, 43);
            this.cbIdContact.Name = "cbIdContact";
            this.cbIdContact.Size = new System.Drawing.Size(75, 17);
            this.cbIdContact.TabIndex = 3;
            this.cbIdContact.Text = "Id Contact";
            this.cbIdContact.UseVisualStyleBackColor = true;
            // 
            // cbNameContact
            // 
            this.cbNameContact.AutoSize = true;
            this.cbNameContact.Location = new System.Drawing.Point(94, 43);
            this.cbNameContact.Name = "cbNameContact";
            this.cbNameContact.Size = new System.Drawing.Size(88, 17);
            this.cbNameContact.TabIndex = 2;
            this.cbNameContact.Text = "Nom Contact";
            this.cbNameContact.UseVisualStyleBackColor = true;
            // 
            // cbNameClient
            // 
            this.cbNameClient.AutoSize = true;
            this.cbNameClient.Location = new System.Drawing.Point(94, 20);
            this.cbNameClient.Name = "cbNameClient";
            this.cbNameClient.Size = new System.Drawing.Size(77, 17);
            this.cbNameClient.TabIndex = 1;
            this.cbNameClient.Text = "Nom Client";
            this.cbNameClient.UseVisualStyleBackColor = true;
            // 
            // cbIdClient
            // 
            this.cbIdClient.AutoSize = true;
            this.cbIdClient.Location = new System.Drawing.Point(7, 20);
            this.cbIdClient.Name = "cbIdClient";
            this.cbIdClient.Size = new System.Drawing.Size(64, 17);
            this.cbIdClient.TabIndex = 0;
            this.cbIdClient.Text = "Id Client";
            this.cbIdClient.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(13, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Vider liste";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Afficher liste";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(13, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 107);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestion client";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 79);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Supprimer les clients";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Voir les clients";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = global::ABIMS.ResourceString.strAddClient;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.cbbLastsSeen);
            this.groupBox4.Location = new System.Drawing.Point(13, 356);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 107);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fenêtres";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 78);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(187, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = global::ABIMS.ResourceString.strCloseWindows;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(187, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = global::ABIMS.ResourceString.strReopenClient;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // cbbLastsSeen
            // 
            this.cbbLastsSeen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLastsSeen.FormattingEnabled = true;
            this.cbbLastsSeen.Location = new System.Drawing.Point(7, 20);
            this.cbbLastsSeen.Name = "cbbLastsSeen";
            this.cbbLastsSeen.Size = new System.Drawing.Size(187, 21);
            this.cbbLastsSeen.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(220, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(934, 527);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // ListClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 557);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListClient";
            this.Text = "ABIMS - Liste de clients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListClient_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.GroupBox groupBox4;
        protected System.Windows.Forms.Button btnSearch;
        protected System.Windows.Forms.TextBox tbSearch;
        protected System.Windows.Forms.CheckBox cbIdContact;
        protected System.Windows.Forms.CheckBox cbNameContact;
        protected System.Windows.Forms.CheckBox cbNameClient;
        protected System.Windows.Forms.CheckBox cbIdClient;
        protected System.Windows.Forms.Button button3;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.Button button6;
        protected System.Windows.Forms.Button button5;
        protected System.Windows.Forms.Button button4;
        protected System.Windows.Forms.Button button8;
        protected System.Windows.Forms.Button button7;
        protected System.Windows.Forms.ComboBox cbbLastsSeen;
        protected System.Windows.Forms.DataGridView dataGridView1;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem ajouterUnClientToolStripMenuItem;
        private ToolStripMenuItem voirLesClientsToolStripMenuItem;
        private ToolStripMenuItem supprimerLesClientsToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem åProposToolStripMenuItem;
        private ToolStripMenuItem åProposToolStripMenuItem1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem réouvrirLeClientToolStripMenuItem;
        private ToolStripMenuItem fermerToutesLesFenêtresToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem afficherListeToolStripMenuItem;
        private ToolStripMenuItem viderListeToolStripMenuItem;
    }
}