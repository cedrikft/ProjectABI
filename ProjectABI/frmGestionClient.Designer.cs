namespace ProjectABI
{
    partial class frmGestionClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblConsignesClients = new System.Windows.Forms.Label();
            this.btnAfficherContacts = new System.Windows.Forms.Button();
            this.grpControleClient = new System.Windows.Forms.GroupBox();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.grdDataGridViewClient = new System.Windows.Forms.DataGridView();
            this.btnTous = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpControleClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterClientToolStripMenuItem,
            this.supprimerClientToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // ajouterClientToolStripMenuItem
            // 
            this.ajouterClientToolStripMenuItem.Name = "ajouterClientToolStripMenuItem";
            this.ajouterClientToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ajouterClientToolStripMenuItem.Text = "Ajouter client";
            this.ajouterClientToolStripMenuItem.Click += new System.EventHandler(this.ajouterClientToolStripMenuItem_Click);
            // 
            // supprimerClientToolStripMenuItem
            // 
            this.supprimerClientToolStripMenuItem.Name = "supprimerClientToolStripMenuItem";
            this.supprimerClientToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.supprimerClientToolStripMenuItem.Text = "Supprimer client";
            this.supprimerClientToolStripMenuItem.Click += new System.EventHandler(this.supprimerClientToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionContactsToolStripMenuItem});
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // gestionContactsToolStripMenuItem
            // 
            this.gestionContactsToolStripMenuItem.Name = "gestionContactsToolStripMenuItem";
            this.gestionContactsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gestionContactsToolStripMenuItem.Text = "Gestion contact(s)";
            this.gestionContactsToolStripMenuItem.Click += new System.EventHandler(this.gestionContactsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aProposToolStripMenuItem.Text = "A propos...";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // lblConsignesClients
            // 
            this.lblConsignesClients.AutoSize = true;
            this.lblConsignesClients.Location = new System.Drawing.Point(12, 35);
            this.lblConsignesClients.Name = "lblConsignesClients";
            this.lblConsignesClients.Size = new System.Drawing.Size(563, 13);
            this.lblConsignesClients.TabIndex = 1;
            this.lblConsignesClients.Text = "Cliquez sur un élément de la liste pour consulter ses informations ou entrez la r" +
    "aison sociale dans la barre de recherche";
            // 
            // btnAfficherContacts
            // 
            this.btnAfficherContacts.Location = new System.Drawing.Point(6, 98);
            this.btnAfficherContacts.Name = "btnAfficherContacts";
            this.btnAfficherContacts.Size = new System.Drawing.Size(102, 23);
            this.btnAfficherContacts.TabIndex = 22;
            this.btnAfficherContacts.Text = "&Gestion contact(s)";
            this.btnAfficherContacts.UseVisualStyleBackColor = true;
            this.btnAfficherContacts.Click += new System.EventHandler(this.btnAfficherContacts_Click);
            // 
            // grpControleClient
            // 
            this.grpControleClient.Controls.Add(this.btnSupprimerClient);
            this.grpControleClient.Controls.Add(this.btnAjouterClient);
            this.grpControleClient.Controls.Add(this.btnAfficherContacts);
            this.grpControleClient.Location = new System.Drawing.Point(649, 86);
            this.grpControleClient.Name = "grpControleClient";
            this.grpControleClient.Size = new System.Drawing.Size(118, 179);
            this.grpControleClient.TabIndex = 23;
            this.grpControleClient.TabStop = false;
            this.grpControleClient.Text = "Que voulez-vous faire ?";
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.Location = new System.Drawing.Point(6, 69);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(102, 23);
            this.btnSupprimerClient.TabIndex = 25;
            this.btnSupprimerClient.Text = "&Supprimer client";
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(6, 40);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(102, 23);
            this.btnAjouterClient.TabIndex = 23;
            this.btnAjouterClient.Text = "&Ajouter client";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(15, 60);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(264, 20);
            this.txtRecherche.TabIndex = 24;
            this.txtRecherche.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRecherche_MouseClick);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(285, 57);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(102, 23);
            this.btnRechercher.TabIndex = 25;
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // grdDataGridViewClient
            // 
            this.grdDataGridViewClient.AllowUserToAddRows = false;
            this.grdDataGridViewClient.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdDataGridViewClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataGridViewClient.Location = new System.Drawing.Point(15, 86);
            this.grdDataGridViewClient.Name = "grdDataGridViewClient";
            this.grdDataGridViewClient.ReadOnly = true;
            this.grdDataGridViewClient.RowHeadersVisible = false;
            this.grdDataGridViewClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDataGridViewClient.Size = new System.Drawing.Size(622, 506);
            this.grdDataGridViewClient.TabIndex = 26;
            this.grdDataGridViewClient.SelectionChanged += new System.EventHandler(this.grdDataGridViewClient_SelectionChanged);
            this.grdDataGridViewClient.DoubleClick += new System.EventHandler(this.grdDataGridViewClient_DoubleClick);
            // 
            // btnTous
            // 
            this.btnTous.Location = new System.Drawing.Point(393, 57);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(102, 23);
            this.btnTous.TabIndex = 27;
            this.btnTous.Text = "&Tous afficher";
            this.btnTous.UseVisualStyleBackColor = true;
            this.btnTous.Click += new System.EventHandler(this.btnTous_Click);
            // 
            // frmGestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 604);
            this.Controls.Add(this.btnTous);
            this.Controls.Add(this.grdDataGridViewClient);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.grpControleClient);
            this.Controls.Add(this.lblConsignesClients);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGestionClient";
            this.Text = "Gestionnaire de clients";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpControleClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDataGridViewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button btnAfficherContacts;
        protected System.Windows.Forms.Button btnSupprimerClient;
        protected System.Windows.Forms.Button btnAjouterClient;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        protected System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        protected System.Windows.Forms.Label lblConsignesClients;
        protected System.Windows.Forms.GroupBox grpControleClient;
        protected System.Windows.Forms.TextBox txtRecherche;
        protected System.Windows.Forms.Button btnRechercher;
        protected System.Windows.Forms.DataGridView grdDataGridViewClient;
        protected System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.ToolStripMenuItem supprimerClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
    }
}

