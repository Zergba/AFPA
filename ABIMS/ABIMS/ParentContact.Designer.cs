namespace ABIMS
{
    partial class ParentContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentContact));
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbIdContact = new System.Windows.Forms.TextBox();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbFonction = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFonction = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(13, 211);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(135, 23);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "Valider ";
            this.btnValidate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(231, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(10, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(59, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Id Contact:";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(112, 13);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(36, 13);
            this.lblClient.TabIndex = 3;
            this.lblClient.Text = "Client:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nom";
            // 
            // tbIdContact
            // 
            this.tbIdContact.Enabled = false;
            this.tbIdContact.Location = new System.Drawing.Point(68, 10);
            this.tbIdContact.Name = "tbIdContact";
            this.tbIdContact.Size = new System.Drawing.Size(38, 20);
            this.tbIdContact.TabIndex = 5;
            // 
            // tbClient
            // 
            this.tbClient.Enabled = false;
            this.tbClient.Location = new System.Drawing.Point(151, 10);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(214, 20);
            this.tbClient.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(102, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(250, 20);
            this.tbName.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.tbFonction);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblFonction);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(13, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 165);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations contact";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(102, 134);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(250, 20);
            this.tbEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 137);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Adresse Email";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(102, 96);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(250, 20);
            this.tbPhone.TabIndex = 11;
            // 
            // tbFonction
            // 
            this.tbFonction.Location = new System.Drawing.Point(102, 58);
            this.tbFonction.Name = "tbFonction";
            this.tbFonction.Size = new System.Drawing.Size(250, 20);
            this.tbFonction.TabIndex = 10;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 99);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 13);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Téléphone";
            // 
            // lblFonction
            // 
            this.lblFonction.AutoSize = true;
            this.lblFonction.Location = new System.Drawing.Point(6, 61);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(48, 13);
            this.lblFonction.TabIndex = 8;
            this.lblFonction.Text = "Fonction";
            // 
            // ParentContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 240);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.tbIdContact);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValidate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParentContact";
            this.Text = "ABIMS - Ajout contact";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        protected System.Windows.Forms.Button btnValidate;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Label lblID;
        protected System.Windows.Forms.Label lblClient;
        protected System.Windows.Forms.TextBox tbIdContact;
        protected System.Windows.Forms.TextBox tbClient;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.TextBox tbName;
        protected System.Windows.Forms.TextBox tbPhone;
        protected System.Windows.Forms.TextBox tbFonction;
        protected System.Windows.Forms.TextBox tbEmail;
    }
}