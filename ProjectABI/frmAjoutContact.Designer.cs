namespace ProjectABI
{
    partial class frmAjoutContact
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
            this.grpCoordonnéesClient.SuspendLayout();
            this.grpAutre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInformationsContact
            // 
            this.lblInformationsContact.Size = new System.Drawing.Size(122, 13);
            this.lblInformationsContact.Text = "Ajouter un contact client";
            // 
            // btnModifier
            // 
            this.btnModifier.Visible = false;
            // 
            // btnAjouterContact
            // 
            this.btnAjouterContact.Visible = false;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click_1);
            // 
            // frmAjoutContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(455, 407);
            this.Name = "frmAjoutContact";
            this.Text = "Ajouter un contact client";
            this.grpCoordonnéesClient.ResumeLayout(false);
            this.grpCoordonnéesClient.PerformLayout();
            this.grpAutre.ResumeLayout(false);
            this.grpAutre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
