namespace ProjectABI
{
    partial class frmAjoutClient
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
            this.grpCaracteristique.SuspendLayout();
            this.grpAutre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInformationsClient
            // 
            this.lblInformationsClient.Size = new System.Drawing.Size(128, 13);
            this.lblInformationsClient.Text = "Ajouter un nouveau client";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(536, 569);
            this.btnModifier.Visible = false;
            // 
            // txtRaisonSociale
            // 
            this.txtRaisonSociale.Size = new System.Drawing.Size(220, 20);
            // 
            // txtCommentaires
            // 
            this.txtCommentaires.Size = new System.Drawing.Size(738, 275);
            // 
            // grpCoordonnéesClient
            // 
            this.grpCoordonnéesClient.Location = new System.Drawing.Point(405, 25);
            this.grpCoordonnéesClient.Size = new System.Drawing.Size(362, 224);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Size = new System.Drawing.Size(223, 56);
            // 
            // grpCaracteristique
            // 
            this.grpCaracteristique.Size = new System.Drawing.Size(388, 224);
            // 
            // txtDomaine
            // 
            this.txtDomaine.Size = new System.Drawing.Size(263, 20);
            // 
            // grpAutre
            // 
            this.grpAutre.Size = new System.Drawing.Size(759, 313);
            // 
            // btnDetailsContact
            // 
            this.btnDetailsContact.Location = new System.Drawing.Point(428, 569);
            // 
            // btnEnregisterModification
            // 
            this.btnEnregisterModification.Location = new System.Drawing.Point(650, 569);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(654, 569);
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // cbnTypeClient
            // 
            this.cbnTypeClient.DropDown += new System.EventHandler(this.cbnTypeClient_DropDown);
            // 
            // cbnNatureClient
            // 
            this.cbnNatureClient.DropDown += new System.EventHandler(this.cbnNatureClient_DropDown);
            // 
            // frmAjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(779, 604);
            this.Name = "frmAjoutClient";
            this.Text = "Ajouter un nouveau client";
            this.grpCoordonnéesClient.ResumeLayout(false);
            this.grpCoordonnéesClient.PerformLayout();
            this.grpCaracteristique.ResumeLayout(false);
            this.grpCaracteristique.PerformLayout();
            this.grpAutre.ResumeLayout(false);
            this.grpAutre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
