namespace ABIMS
{
    partial class AjoutClient
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
            this.btnValidCreationClient = new System.Windows.Forms.Button();
            this.btnCancelCreationClient = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnResetCreationClient = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbAddComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            // 
            // button3
            // 
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // button6
            // 
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnValidCreationClient
            // 
            this.btnValidCreationClient.Location = new System.Drawing.Point(12, 621);
            this.btnValidCreationClient.Name = "btnValidCreationClient";
            this.btnValidCreationClient.Size = new System.Drawing.Size(100, 23);
            this.btnValidCreationClient.TabIndex = 2;
            this.btnValidCreationClient.Text = "Valider la création";
            this.btnValidCreationClient.UseVisualStyleBackColor = true;
            this.btnValidCreationClient.Click += new System.EventHandler(this.btnValidCreationClient_Click);
            // 
            // btnCancelCreationClient
            // 
            this.btnCancelCreationClient.Location = new System.Drawing.Point(246, 621);
            this.btnCancelCreationClient.Name = "btnCancelCreationClient";
            this.btnCancelCreationClient.Size = new System.Drawing.Size(104, 23);
            this.btnCancelCreationClient.TabIndex = 3;
            this.btnCancelCreationClient.Text = "Annuler la création";
            this.btnCancelCreationClient.UseVisualStyleBackColor = true;
            this.btnCancelCreationClient.Click += new System.EventHandler(this.btnCancelCreationClient_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(356, 625);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(180, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Voir la fiche Client après création";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnResetCreationClient
            // 
            this.btnResetCreationClient.Location = new System.Drawing.Point(120, 621);
            this.btnResetCreationClient.Name = "btnResetCreationClient";
            this.btnResetCreationClient.Size = new System.Drawing.Size(120, 23);
            this.btnResetCreationClient.TabIndex = 5;
            this.btnResetCreationClient.Text = "Réinitialiser la création";
            this.btnResetCreationClient.UseVisualStyleBackColor = true;
            this.btnResetCreationClient.Click += new System.EventHandler(this.btnResetCreationClient_Click);
            // 
            // AjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(531, 666);
            this.Controls.Add(this.btnResetCreationClient);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnCancelCreationClient);
            this.Controls.Add(this.btnValidCreationClient);
            this.Name = "AjoutClient";
            this.Text = "ABIMS - Ajout Client";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.btnValidCreationClient, 0);
            this.Controls.SetChildIndex(this.btnCancelCreationClient, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.btnResetCreationClient, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbAddComment.ResumeLayout(false);
            this.gbAddComment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidCreationClient;
        private System.Windows.Forms.Button btnCancelCreationClient;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnResetCreationClient;
    }
}
