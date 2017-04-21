namespace ProjectABI
{
    partial class frmGestionContacts
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
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.grpAutre = new System.Windows.Forms.GroupBox();
            this.lblCommentaires = new System.Windows.Forms.Label();
            this.txtCommentaires = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.grpCoordonnees = new System.Windows.Forms.GroupBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblNomContact = new System.Windows.Forms.Label();
            this.txtNomContact = new System.Windows.Forms.TextBox();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.txtRaisonSociale = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.grdDataGridViewContact = new System.Windows.Forms.DataGridView();
            this.btnAgrandir = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agrandirListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSupprimerContact = new System.Windows.Forms.Button();
            this.grpControleClient.SuspendLayout();
            this.grpContact.SuspendLayout();
            this.grpAutre.SuspendLayout();
            this.grpCoordonnees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataGridViewContact)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAfficherContacts
            // 
            this.btnAfficherContacts.Text = "&Détail du contact";
            this.btnAfficherContacts.Visible = false;
            this.btnAfficherContacts.Click += new System.EventHandler(this.btnAfficherContacts_Click);
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.Text = "&Supprimer contact";
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Text = "&Ajouter contact";
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // grpControleClient
            // 
            this.grpControleClient.Controls.Add(this.btnSupprimerContact);
            this.grpControleClient.Controls.Add(this.btnAgrandir);
            this.grpControleClient.Location = new System.Drawing.Point(651, 86);
            this.grpControleClient.Size = new System.Drawing.Size(118, 202);
            this.grpControleClient.Controls.SetChildIndex(this.btnAfficherContacts, 0);
            this.grpControleClient.Controls.SetChildIndex(this.btnAjouterClient, 0);
            this.grpControleClient.Controls.SetChildIndex(this.btnSupprimerClient, 0);
            this.grpControleClient.Controls.SetChildIndex(this.btnAgrandir, 0);
            this.grpControleClient.Controls.SetChildIndex(this.btnSupprimerContact, 0);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnTous
            // 
            this.btnTous.Text = "&Tous";
            this.btnTous.Click += new System.EventHandler(this.btnTous_Click);
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.grpAutre);
            this.grpContact.Controls.Add(this.btnEnregistrer);
            this.grpContact.Controls.Add(this.grpCoordonnees);
            this.grpContact.Controls.Add(this.btnModifier);
            this.grpContact.Location = new System.Drawing.Point(12, 294);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(639, 284);
            this.grpContact.TabIndex = 27;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact";
            // 
            // grpAutre
            // 
            this.grpAutre.Controls.Add(this.lblCommentaires);
            this.grpAutre.Controls.Add(this.txtCommentaires);
            this.grpAutre.Location = new System.Drawing.Point(316, 19);
            this.grpAutre.Name = "grpAutre";
            this.grpAutre.Size = new System.Drawing.Size(317, 231);
            this.grpAutre.TabIndex = 56;
            this.grpAutre.TabStop = false;
            this.grpAutre.Text = "Autre";
            // 
            // lblCommentaires
            // 
            this.lblCommentaires.AutoSize = true;
            this.lblCommentaires.Location = new System.Drawing.Point(6, 25);
            this.lblCommentaires.Name = "lblCommentaires";
            this.lblCommentaires.Size = new System.Drawing.Size(73, 13);
            this.lblCommentaires.TabIndex = 48;
            this.lblCommentaires.Text = "Commentaires";
            // 
            // txtCommentaires
            // 
            this.txtCommentaires.Location = new System.Drawing.Point(6, 54);
            this.txtCommentaires.Multiline = true;
            this.txtCommentaires.Name = "txtCommentaires";
            this.txtCommentaires.Size = new System.Drawing.Size(295, 158);
            this.txtCommentaires.TabIndex = 49;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(531, 256);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(102, 23);
            this.btnEnregistrer.TabIndex = 61;
            this.btnEnregistrer.Text = "&Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // grpCoordonnees
            // 
            this.grpCoordonnees.Controls.Add(this.txtAdresse);
            this.grpCoordonnees.Controls.Add(this.txtTelephone);
            this.grpCoordonnees.Controls.Add(this.lblAdresse);
            this.grpCoordonnees.Controls.Add(this.lblTelephone);
            this.grpCoordonnees.Controls.Add(this.lblNomContact);
            this.grpCoordonnees.Controls.Add(this.txtNomContact);
            this.grpCoordonnees.Controls.Add(this.lblRaisonSociale);
            this.grpCoordonnees.Controls.Add(this.txtRaisonSociale);
            this.grpCoordonnees.Location = new System.Drawing.Point(3, 16);
            this.grpCoordonnees.Name = "grpCoordonnees";
            this.grpCoordonnees.Size = new System.Drawing.Size(307, 234);
            this.grpCoordonnees.TabIndex = 0;
            this.grpCoordonnees.TabStop = false;
            this.grpCoordonnees.Text = "Coordonnées du contact";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(128, 97);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(173, 77);
            this.txtAdresse.TabIndex = 45;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(128, 195);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(120, 20);
            this.txtTelephone.TabIndex = 55;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(6, 100);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(99, 13);
            this.lblAdresse.TabIndex = 44;
            this.lblAdresse.Text = "Adresse du contact";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(6, 202);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblTelephone.TabIndex = 54;
            this.lblTelephone.Text = "Téléphone";
            // 
            // lblNomContact
            // 
            this.lblNomContact.AutoSize = true;
            this.lblNomContact.Location = new System.Drawing.Point(7, 57);
            this.lblNomContact.Name = "lblNomContact";
            this.lblNomContact.Size = new System.Drawing.Size(83, 13);
            this.lblNomContact.TabIndex = 42;
            this.lblNomContact.Text = "Nom du contact";
            // 
            // txtNomContact
            // 
            this.txtNomContact.Location = new System.Drawing.Point(128, 57);
            this.txtNomContact.Name = "txtNomContact";
            this.txtNomContact.Size = new System.Drawing.Size(173, 20);
            this.txtNomContact.TabIndex = 43;
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(3, 24);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(119, 13);
            this.lblRaisonSociale.TabIndex = 13;
            this.lblRaisonSociale.Text = "Raison sociale du client";
            // 
            // txtRaisonSociale
            // 
            this.txtRaisonSociale.Location = new System.Drawing.Point(128, 21);
            this.txtRaisonSociale.Name = "txtRaisonSociale";
            this.txtRaisonSociale.Size = new System.Drawing.Size(173, 20);
            this.txtRaisonSociale.TabIndex = 12;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(423, 256);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(102, 23);
            this.btnModifier.TabIndex = 60;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // grdDataGridViewContact
            // 
            this.grdDataGridViewContact.AllowUserToAddRows = false;
            this.grdDataGridViewContact.AllowUserToDeleteRows = false;
            this.grdDataGridViewContact.AllowUserToResizeRows = false;
            this.grdDataGridViewContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDataGridViewContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataGridViewContact.Location = new System.Drawing.Point(15, 86);
            this.grdDataGridViewContact.Name = "grdDataGridViewContact";
            this.grdDataGridViewContact.ReadOnly = true;
            this.grdDataGridViewContact.RowHeadersVisible = false;
            this.grdDataGridViewContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDataGridViewContact.Size = new System.Drawing.Size(633, 202);
            this.grdDataGridViewContact.TabIndex = 62;
            this.grdDataGridViewContact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDataGridViewContact_CellContentClick);
            this.grdDataGridViewContact.SelectionChanged += new System.EventHandler(this.grdDataGridViewContact_SelectionChanged);
            this.grdDataGridViewContact.DoubleClick += new System.EventHandler(this.grdDataGridViewContact_DoubleClick);
            // 
            // btnAgrandir
            // 
            this.btnAgrandir.Location = new System.Drawing.Point(6, 127);
            this.btnAgrandir.Name = "btnAgrandir";
            this.btnAgrandir.Size = new System.Drawing.Size(102, 23);
            this.btnAgrandir.TabIndex = 63;
            this.btnAgrandir.Text = "Agrandir &Liste";
            this.btnAgrandir.UseVisualStyleBackColor = true;
            this.btnAgrandir.Click += new System.EventHandler(this.btnAgrandir_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem1,
            this.contactToolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(779, 24);
            this.menuStrip2.TabIndex = 63;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fichierToolStripMenuItem1
            // 
            this.fichierToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem1});
            this.fichierToolStripMenuItem1.Name = "fichierToolStripMenuItem1";
            this.fichierToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem1.Text = "Fichier";
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // contactToolStripMenuItem1
            // 
            this.contactToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterContactToolStripMenuItem,
            this.supprimerContactToolStripMenuItem,
            this.agrandirListeToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.enregistrerToolStripMenuItem});
            this.contactToolStripMenuItem1.Name = "contactToolStripMenuItem1";
            this.contactToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.contactToolStripMenuItem1.Text = "Contact";
            // 
            // ajouterContactToolStripMenuItem
            // 
            this.ajouterContactToolStripMenuItem.Name = "ajouterContactToolStripMenuItem";
            this.ajouterContactToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ajouterContactToolStripMenuItem.Text = "Ajouter contact";
            this.ajouterContactToolStripMenuItem.Click += new System.EventHandler(this.ajouterContactToolStripMenuItem_Click);
            // 
            // supprimerContactToolStripMenuItem
            // 
            this.supprimerContactToolStripMenuItem.Name = "supprimerContactToolStripMenuItem";
            this.supprimerContactToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.supprimerContactToolStripMenuItem.Text = "Supprimer contact";
            this.supprimerContactToolStripMenuItem.Click += new System.EventHandler(this.supprimerContactToolStripMenuItem_Click);
            // 
            // agrandirListeToolStripMenuItem
            // 
            this.agrandirListeToolStripMenuItem.Name = "agrandirListeToolStripMenuItem";
            this.agrandirListeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.agrandirListeToolStripMenuItem.Text = "Agrandir Liste";
            this.agrandirListeToolStripMenuItem.Click += new System.EventHandler(this.agrandirListeToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem1,
            this.aideToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem2.Text = "?";
            // 
            // aProposToolStripMenuItem1
            // 
            this.aProposToolStripMenuItem1.Name = "aProposToolStripMenuItem1";
            this.aProposToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.aProposToolStripMenuItem1.Text = "A propos...";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // btnSupprimerContact
            // 
            this.btnSupprimerContact.Location = new System.Drawing.Point(6, 69);
            this.btnSupprimerContact.Name = "btnSupprimerContact";
            this.btnSupprimerContact.Size = new System.Drawing.Size(102, 23);
            this.btnSupprimerContact.TabIndex = 64;
            this.btnSupprimerContact.Text = "&Supprimer contact";
            this.btnSupprimerContact.UseVisualStyleBackColor = true;
            this.btnSupprimerContact.Click += new System.EventHandler(this.btnSupprimerContact_Click);
            // 
            // frmGestionContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(779, 604);
            this.Controls.Add(this.grdDataGridViewContact);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmGestionContacts";
            this.Text = "Gestionnaire de contacts";
            this.Controls.SetChildIndex(this.menuStrip2, 0);
            this.Controls.SetChildIndex(this.btnTous, 0);
            this.Controls.SetChildIndex(this.lblConsignesClients, 0);
            this.Controls.SetChildIndex(this.grpControleClient, 0);
            this.Controls.SetChildIndex(this.txtRecherche, 0);
            this.Controls.SetChildIndex(this.btnRechercher, 0);
            this.Controls.SetChildIndex(this.grpContact, 0);
            this.Controls.SetChildIndex(this.grdDataGridViewContact, 0);
            this.grpControleClient.ResumeLayout(false);
            this.grpContact.ResumeLayout(false);
            this.grpAutre.ResumeLayout(false);
            this.grpAutre.PerformLayout();
            this.grpCoordonnees.ResumeLayout(false);
            this.grpCoordonnees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataGridViewContact)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.GroupBox grpCoordonnees;
        protected System.Windows.Forms.Label lblRaisonSociale;
        protected System.Windows.Forms.TextBox txtRaisonSociale;
        protected System.Windows.Forms.TextBox txtAdresse;
        protected System.Windows.Forms.Label lblAdresse;
        protected System.Windows.Forms.Label lblNomContact;
        protected System.Windows.Forms.TextBox txtNomContact;
        protected System.Windows.Forms.GroupBox grpAutre;
        protected System.Windows.Forms.Label lblCommentaires;
        protected System.Windows.Forms.TextBox txtCommentaires;
        protected System.Windows.Forms.TextBox txtTelephone;
        protected System.Windows.Forms.Label lblTelephone;
        protected System.Windows.Forms.Button btnEnregistrer;
        protected System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView grdDataGridViewContact;
        private System.Windows.Forms.Button btnAgrandir;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agrandirListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.Button btnSupprimerContact;
    }
}
