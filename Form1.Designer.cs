namespace Sauvegarde
{
    partial class Form1
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
            this.listeDossiers = new System.Windows.Forms.ListBox();
            this.txtchemin1 = new System.Windows.Forms.TextBox();
            this.lblresultat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSauvegarde = new System.Windows.Forms.Button();
            this.txtdestination = new System.Windows.Forms.TextBox();
            this.btnParcourir1 = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.folderFchier1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderRepDest = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // listeDossiers
            // 
            this.listeDossiers.FormattingEnabled = true;
            this.listeDossiers.Location = new System.Drawing.Point(268, 156);
            this.listeDossiers.Name = "listeDossiers";
            this.listeDossiers.Size = new System.Drawing.Size(342, 82);
            this.listeDossiers.TabIndex = 22;
            // 
            // txtchemin1
            // 
            this.txtchemin1.Enabled = false;
            this.txtchemin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchemin1.Location = new System.Drawing.Point(268, 110);
            this.txtchemin1.Name = "txtchemin1";
            this.txtchemin1.Size = new System.Drawing.Size(244, 20);
            this.txtchemin1.TabIndex = 16;
            // 
            // lblresultat
            // 
            this.lblresultat.AutoSize = true;
            this.lblresultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblresultat.Location = new System.Drawing.Point(309, 347);
            this.lblresultat.Name = "lblresultat";
            this.lblresultat.Size = new System.Drawing.Size(51, 16);
            this.lblresultat.TabIndex = 20;
            this.lblresultat.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Sauvegarde de dossier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(141, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Destination";
            // 
            // btnSauvegarde
            // 
            this.btnSauvegarde.Location = new System.Drawing.Point(345, 383);
            this.btnSauvegarde.Name = "btnSauvegarde";
            this.btnSauvegarde.Size = new System.Drawing.Size(115, 48);
            this.btnSauvegarde.TabIndex = 18;
            this.btnSauvegarde.Text = "Sauvegarder";
            this.btnSauvegarde.UseVisualStyleBackColor = true;
            this.btnSauvegarde.Click += new System.EventHandler(this.btnSauvegarde_Click);
            // 
            // txtdestination
            // 
            this.txtdestination.Enabled = false;
            this.txtdestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtdestination.Location = new System.Drawing.Point(265, 275);
            this.txtdestination.Name = "txtdestination";
            this.txtdestination.Size = new System.Drawing.Size(244, 20);
            this.txtdestination.TabIndex = 17;
            this.txtdestination.Text = "Sélectionner un dossier";
            // 
            // btnParcourir1
            // 
            this.btnParcourir1.Location = new System.Drawing.Point(531, 107);
            this.btnParcourir1.Name = "btnParcourir1";
            this.btnParcourir1.Size = new System.Drawing.Size(79, 25);
            this.btnParcourir1.TabIndex = 23;
            this.btnParcourir1.Text = "Parcourir";
            this.btnParcourir1.UseVisualStyleBackColor = true;
            this.btnParcourir1.Click += new System.EventHandler(this.btnParcourir1_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(531, 275);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(79, 25);
            this.btnDestination.TabIndex = 24;
            this.btnDestination.Text = "Parcourir";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(823, 464);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.btnParcourir1);
            this.Controls.Add(this.listeDossiers);
            this.Controls.Add(this.txtchemin1);
            this.Controls.Add(this.lblresultat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSauvegarde);
            this.Controls.Add(this.txtdestination);
            this.Name = "Form1";
            this.Text = "Sauvegarde";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listeDossiers;
        private System.Windows.Forms.TextBox txtchemin1;
        private System.Windows.Forms.Label lblresultat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSauvegarde;
        private System.Windows.Forms.TextBox txtdestination;
        private System.Windows.Forms.Button btnParcourir1;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.FolderBrowserDialog folderFchier1;
        private System.Windows.Forms.FolderBrowserDialog FolderRepDest;
    }
}

