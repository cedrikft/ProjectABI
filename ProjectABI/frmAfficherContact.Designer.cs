namespace ProjectABI
{
    partial class frmAfficherContact
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
            this.grpCoordonnéesClient = new System.Windows.Forms.GroupBox();
            this.txtTelephoneContact = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.txtRaisonSociale = new System.Windows.Forms.TextBox();
            this.lblNomContact = new System.Windows.Forms.Label();
            this.txtNomContact = new System.Windows.Forms.TextBox();
            this.grpAutre = new System.Windows.Forms.GroupBox();
            this.lblCommentaires = new System.Windows.Forms.Label();
            this.txtCommentaires = new System.Windows.Forms.TextBox();
            this.lblInformationsContact = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouterContact = new System.Windows.Forms.Button();
            this.lblInformationsClient = new System.Windows.Forms.Label();
            this.grpCoordonnéesClient.SuspendLayout();
            this.grpAutre.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCoordonnéesClient
            // 
            this.grpCoordonnéesClient.Controls.Add(this.txtTelephoneContact);
            this.grpCoordonnéesClient.Controls.Add(this.lblTelephone);
            this.grpCoordonnéesClient.Controls.Add(this.txtAdresse);
            this.grpCoordonnéesClient.Controls.Add(this.lblAdresse);
            this.grpCoordonnéesClient.Controls.Add(this.lblRaisonSociale);
            this.grpCoordonnéesClient.Controls.Add(this.txtRaisonSociale);
            this.grpCoordonnéesClient.Controls.Add(this.lblNomContact);
            this.grpCoordonnéesClient.Controls.Add(this.txtNomContact);
            this.grpCoordonnéesClient.Location = new System.Drawing.Point(11, 37);
            this.grpCoordonnéesClient.Name = "grpCoordonnéesClient";
            this.grpCoordonnéesClient.Size = new System.Drawing.Size(428, 224);
            this.grpCoordonnéesClient.TabIndex = 51;
            this.grpCoordonnéesClient.TabStop = false;
            this.grpCoordonnéesClient.Text = "Coordonnées contact";
            // 
            // txtTelephoneContact
            // 
            this.txtTelephoneContact.Location = new System.Drawing.Point(129, 174);
            this.txtTelephoneContact.Name = "txtTelephoneContact";
            this.txtTelephoneContact.Size = new System.Drawing.Size(120, 20);
            this.txtTelephoneContact.TabIndex = 43;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(6, 174);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblTelephone.TabIndex = 42;
            this.lblTelephone.Text = "Téléphone";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(128, 97);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(264, 56);
            this.txtAdresse.TabIndex = 41;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(6, 100);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(99, 13);
            this.lblAdresse.TabIndex = 40;
            this.lblAdresse.Text = "Adresse du contact";
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(6, 30);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(119, 13);
            this.lblRaisonSociale.TabIndex = 11;
            this.lblRaisonSociale.Text = "Raison sociale du client";
            // 
            // txtRaisonSociale
            // 
            this.txtRaisonSociale.Location = new System.Drawing.Point(131, 27);
            this.txtRaisonSociale.Name = "txtRaisonSociale";
            this.txtRaisonSociale.Size = new System.Drawing.Size(264, 20);
            this.txtRaisonSociale.TabIndex = 10;
            // 
            // lblNomContact
            // 
            this.lblNomContact.AutoSize = true;
            this.lblNomContact.Location = new System.Drawing.Point(7, 57);
            this.lblNomContact.Name = "lblNomContact";
            this.lblNomContact.Size = new System.Drawing.Size(83, 13);
            this.lblNomContact.TabIndex = 3;
            this.lblNomContact.Text = "Nom du contact";
            // 
            // txtNomContact
            // 
            this.txtNomContact.Location = new System.Drawing.Point(130, 57);
            this.txtNomContact.Name = "txtNomContact";
            this.txtNomContact.Size = new System.Drawing.Size(262, 20);
            this.txtNomContact.TabIndex = 9;
            // 
            // grpAutre
            // 
            this.grpAutre.Controls.Add(this.lblCommentaires);
            this.grpAutre.Controls.Add(this.txtCommentaires);
            this.grpAutre.Location = new System.Drawing.Point(12, 267);
            this.grpAutre.Name = "grpAutre";
            this.grpAutre.Size = new System.Drawing.Size(427, 96);
            this.grpAutre.TabIndex = 53;
            this.grpAutre.TabStop = false;
            this.grpAutre.Text = "Autre";
            // 
            // lblCommentaires
            // 
            this.lblCommentaires.AutoSize = true;
            this.lblCommentaires.Location = new System.Drawing.Point(7, 16);
            this.lblCommentaires.Name = "lblCommentaires";
            this.lblCommentaires.Size = new System.Drawing.Size(73, 13);
            this.lblCommentaires.TabIndex = 48;
            this.lblCommentaires.Text = "Commentaires";
            // 
            // txtCommentaires
            // 
            this.txtCommentaires.Location = new System.Drawing.Point(6, 32);
            this.txtCommentaires.Multiline = true;
            this.txtCommentaires.Name = "txtCommentaires";
            this.txtCommentaires.Size = new System.Drawing.Size(406, 56);
            this.txtCommentaires.TabIndex = 49;
            // 
            // lblInformationsContact
            // 
            this.lblInformationsContact.AutoSize = true;
            this.lblInformationsContact.Location = new System.Drawing.Point(8, 9);
            this.lblInformationsContact.Name = "lblInformationsContact";
            this.lblInformationsContact.Size = new System.Drawing.Size(136, 13);
            this.lblInformationsContact.TabIndex = 54;
            this.lblInformationsContact.Text = "Informations contacts client";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(338, 372);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(102, 23);
            this.btnEnregistrer.TabIndex = 59;
            this.btnEnregistrer.Text = "Enregister";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(230, 372);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(102, 23);
            this.btnModifier.TabIndex = 58;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouterContact
            // 
            this.btnAjouterContact.Location = new System.Drawing.Point(122, 372);
            this.btnAjouterContact.Name = "btnAjouterContact";
            this.btnAjouterContact.Size = new System.Drawing.Size(102, 23);
            this.btnAjouterContact.TabIndex = 56;
            this.btnAjouterContact.Text = "Ajouter un contact";
            this.btnAjouterContact.UseVisualStyleBackColor = true;
            this.btnAjouterContact.Click += new System.EventHandler(this.btnAjouterContact_Click);
            // 
            // lblInformationsClient
            // 
            this.lblInformationsClient.AutoSize = true;
            this.lblInformationsClient.Location = new System.Drawing.Point(11, -240);
            this.lblInformationsClient.Name = "lblInformationsClient";
            this.lblInformationsClient.Size = new System.Drawing.Size(92, 13);
            this.lblInformationsClient.TabIndex = 57;
            this.lblInformationsClient.Text = "Informations client";
            // 
            // frmAfficherContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 407);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouterContact);
            this.Controls.Add(this.lblInformationsClient);
            this.Controls.Add(this.lblInformationsContact);
            this.Controls.Add(this.grpAutre);
            this.Controls.Add(this.grpCoordonnéesClient);
            this.Name = "frmAfficherContact";
            this.Text = "Informations contacts client";
            this.grpCoordonnéesClient.ResumeLayout(false);
            this.grpCoordonnéesClient.PerformLayout();
            this.grpAutre.ResumeLayout(false);
            this.grpAutre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Label lblInformationsContact;
        protected internal System.Windows.Forms.Button btnModifier;
        protected internal System.Windows.Forms.Label lblInformationsClient;
        protected internal System.Windows.Forms.Button btnAjouterContact;
        protected internal System.Windows.Forms.GroupBox grpCoordonnéesClient;
        protected internal System.Windows.Forms.TextBox txtTelephoneContact;
        protected internal System.Windows.Forms.Label lblTelephone;
        protected internal System.Windows.Forms.TextBox txtAdresse;
        protected internal System.Windows.Forms.Label lblAdresse;
        protected internal System.Windows.Forms.Label lblRaisonSociale;
        protected internal System.Windows.Forms.TextBox txtRaisonSociale;
        protected internal System.Windows.Forms.Label lblNomContact;
        protected internal System.Windows.Forms.TextBox txtNomContact;
        protected internal System.Windows.Forms.GroupBox grpAutre;
        protected internal System.Windows.Forms.Label lblCommentaires;
        protected internal System.Windows.Forms.TextBox txtCommentaires;
        protected internal System.Windows.Forms.Button btnEnregistrer;
    }
}