using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectABI
{
    public partial class frmGestionClient : Form
    {
        /// <summary>
        /// constructeur par defaut
        /// </summary>
        public frmGestionClient()
        {
            InitializeComponent();
            btnSupprimerClient.Enabled = false;
            btnAfficherContacts.Enabled = false;
            btnRechercher.Enabled = false;
            btnTous.Enabled = false;
            supprimerClientToolStripMenuItem.Enabled = false;
            contactToolStripMenuItem.Enabled = false;
            

            afficheClient();
        }

        /// <summary>
        /// quitter le programme par le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var result = MessageBox.Show("Quitter le programme", "Voulez-vous vraiment quitter le programme ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        /// <summary>
        /// créé et ouvre le formulaire d'ajout de client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnAjouterClient_Click(object sender, EventArgs e)
        {
            frmAjoutClient formulaireAjoutClient = new frmAjoutClient();
            formulaireAjoutClient.ShowDialog();
            afficheClient();
            /*   if (formulaireAjoutClient.ShowDialog() == DialogResult.OK)
               {
                   afficheClient();              
               }*/

        }

       
        /// <summary>
        /// créé et ouvre le gestionnaire de contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnAfficherContacts_Click(object sender, EventArgs e)
        {
            //ouvrir la feuille détail Afficher Client selon la ligne sélectionnée
            Int32 iClient; //rang/ligne du client dans la liste

            //récupérer l'index du client cliqué en DataGridView
            iClient = this.grdDataGridViewClient.CurrentRow.Index;

            //on pointe un objet client vers la liste d'origine
            //        MClient clientSelectionne = Donnees.ListClient[iClient];

            //rechercher le client correspondant à la ligne double-cliquée
            Int32 idClient;
            //id du client dans la collection
            // idClient = (int)this.grdDataGridViewClient.CurrentRow.Cells[0].Value;
            idClient = Convert.ToInt32(this.grdDataGridViewClient.CurrentRow.Cells[0].Value);

            Table_Client leClientEF = Donnees.Db.Table_Client.Find(idClient);

            //rechercher l'objet Entity
            MClient leClient = new MClient();
            leClient.RaisonSociale = leClientEF.raisonSociale;
            leClient.IdClient = (UInt32)leClientEF.idClient;
            leClient.AdresseClient = leClientEF.adresseClient;
            leClient.TelephoneClient = leClientEF.telephoneClient;
            leClient.DomaineActivite = leClientEF.domaineActivite;
            leClient.TypeClient = leClientEF.typeClient;
            leClient.NatureClient = leClientEF.natureClient;
            leClient.EffectifClient = (UInt32)leClientEF.effectifClient;
            leClient.ChiffreAffaireClient = (UInt32)leClientEF.chiffreAffaireClient;
            leClient.CommentairesClient = leClientEF.commentairesClient;


            frmGestionContacts formulaireGestionContacts = new frmGestionContacts(leClient);
            formulaireGestionContacts.ShowDialog();
             
        }



        /// <summary>
        /// affichage des clients dans la dataGridView
        /// </summary>
        public void afficheClient()
        {
            //DataTable : recopie les clients qui sont stockés dans la liste ListClient
            DataTable maDataTable = new DataTable();
            DataRow ligneDataTable; //une ligne de la dataTable

            //ajout des 4 colonnes
            maDataTable.Columns.Add(new DataColumn("Numero", typeof(System.UInt32)));
            maDataTable.Columns.Add(new DataColumn("Raison sociale", typeof(System.String)));            
            maDataTable.Columns.Add(new DataColumn("Nature", typeof(System.String)));
            maDataTable.Columns.Add(new DataColumn("Chiffre d'affaire", typeof(System.UInt32)));
            maDataTable.Columns.Add(new DataColumn("Effectif", typeof(System.UInt32)));


            //boucle de remplissage de Data Table à partir de la collection en dbContext
            //le dbContext peut générer une liste typée d'objet Entity Client

            foreach (Table_Client unClientEF in Donnees.Db.Table_Client.ToList())
            {
                //instanciation DataRow (=ligne du Data Table)
                ligneDataTable = maDataTable.NewRow();

                //affectation de 5 colonnes à partir de l'Entity              
                ligneDataTable[0] = unClientEF.idClient;
                ligneDataTable["Raison sociale"] = unClientEF.raisonSociale;
                ligneDataTable["Nature"] = unClientEF.natureClient;
                ligneDataTable["Chiffre d'affaire"] = unClientEF.chiffreAffaireClient;
                ligneDataTable["Effectif"] = unClientEF.effectifClient;

                maDataTable.Rows.Add(ligneDataTable);

                this.grdDataGridViewClient.Refresh();
            }

            this.grdDataGridViewClient.DataSource = maDataTable;
            this.grdDataGridViewClient.Refresh();


            if ((Donnees.Db.Table_Client.ToList().Count < 1))
            {
                btnAfficherContacts.Enabled = false;

                btnSupprimerClient.Enabled = false;

                supprimerClientToolStripMenuItem.Enabled = false;

                contactToolStripMenuItem.Enabled = false;



            }

        }


        /// <summary>
        /// gestion des événements double clicks sur la datagridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdDataGridViewClient_DoubleClick(object sender, EventArgs e)
        {
           
            //ouvrir la feuille détail Afficher Client selon la ligne sélectionnée
            Int32 iClient; //rang/ligne du client dans la liste

            //récupérer l'index du client cliqué en DataGridView
            iClient = this.grdDataGridViewClient.CurrentRow.Index;

       
            //rechercher le client correspondant à la ligne double-cliquée
            Int32 idClient;          
            //id du client dans la collection
             // idClient = (int)this.grdDataGridViewClient.CurrentRow.Cells[0].Value;
            idClient = Convert.ToInt32(this.grdDataGridViewClient.CurrentRow.Cells[0].Value);

            Table_Client leClientEF = Donnees.Db.Table_Client.Find(idClient);

            //rechercher l'objet Entity
            MClient leClient = new MClient();
            leClient.RaisonSociale = leClientEF.raisonSociale;
            leClient.IdClient = (UInt32)leClientEF.idClient;
            leClient.AdresseClient = leClientEF.adresseClient;
            leClient.TelephoneClient = leClientEF.telephoneClient;
            leClient.DomaineActivite = leClientEF.domaineActivite;
            leClient.TypeClient = leClientEF.typeClient;
            leClient.NatureClient = leClientEF.natureClient;
            leClient.EffectifClient = (UInt32)leClientEF.effectifClient;
            leClient.ChiffreAffaireClient = (UInt32)leClientEF.chiffreAffaireClient;
            leClient.CommentairesClient = leClientEF.commentairesClient;

            //on instancie un formulaire afficher client pour le client sélectionné
         //   frmAfficherClient formulaireAfficherClient = new frmAfficherClient(clientSelectionne);

            frmAfficherClient formulaireAfficherClient = new frmAfficherClient(leClient);


            //on afficher le formulaire afficher client en modal
            formulaireAfficherClient.ShowDialog();

            //on rafraichi la dataGridView
            this.afficheClient();
        }

        /// <summary>
        /// suppression d'un client quand click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnSupprimerClient_Click(object sender, EventArgs e)
        {

         //   Int32 iClient = this.grdDataGridViewClient.CurrentRow.Index;

            Int32 idClient; //id du client dans la collection
            //récupérer id du client cliqué en DataGridView
          //  idClient = (int)this.grdDataGridViewClient.CurrentRow.Cells[0].Value;

            idClient = Convert.ToInt32(this.grdDataGridViewClient.CurrentRow.Cells[0].Value);

            //retrouver l'objet EF Client dans la collection dbContext
            Table_Client leClientEF = Donnees.Db.Table_Client.Find(idClient);


            //confirmer la suppresion
            var result = MessageBox.Show( "Etes vous sûr de vouloir supprimer définitivement ce client ?", "Supprimer un client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //supprimer de la collection EF
                Donnees.Db.Table_Client.Remove(leClientEF);

                //impacter sur la BDD
                Donnees.Db.SaveChanges();
            

    //            Donnees.ListClient.RemoveAt(iClient);
           }
            
            afficheClient();
        }

        

        /// <summary>
        /// gestion des événements changement de focus sur la datagridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdDataGridViewClient_SelectionChanged(object sender, EventArgs e)
        {
            //on débloque le bouton supprimer
            btnSupprimerClient.Enabled = true;
            btnAfficherContacts.Enabled = true;
            supprimerClientToolStripMenuItem.Enabled = true;
            contactToolStripMenuItem.Enabled = true;

        }

        /// <summary>
        /// rechercher un client en fonction d'un nom rentré dans la txtBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnRechercher_Click(object sender, EventArgs e)
        {
            if(this.txtRecherche.Text != null)
            {
                //filtrer
                  ((DataTable)(this.grdDataGridViewClient.DataSource)).DefaultView.RowFilter = "[Raison sociale] like '%" + this.txtRecherche.Text + "%'";
               
                btnTous.Enabled = true;
            }
        }


        /// <summary>
        /// supprime le filtre et affiche toute la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnTous_Click(object sender, EventArgs e)
        {
            this.txtRecherche.Text = null;
            ((DataTable)(this.grdDataGridViewClient.DataSource)).DefaultView.RowFilter = null;
            btnRechercher.Enabled = false;
            btnTous.Enabled = false;
        }


        /// <summary>
        /// dévérouille la barre de recherche si click sur ladite barre de recherhce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRecherche_MouseClick(object sender, MouseEventArgs e)
        {
            btnRechercher.Enabled = true;
        }

        /// <summary>
        /// ajoute un nouveau client depuis le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutClient formulaireAjoutClient = new frmAjoutClient();

            if (formulaireAjoutClient.ShowDialog() == DialogResult.OK)
            {
                afficheClient();
            }
        }

        /// <summary>
        /// supprime un client depuis le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 iClient = this.grdDataGridViewClient.CurrentRow.Index;

            var result = MessageBox.Show( "Etes vous sûr de vouloir supprimer définitivement ce client ?", "Supprimer un client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
              //  Donnees.ListClient.RemoveAt(iClient);
           }
            
            afficheClient();
        }

        /// <summary>
        /// créé et ouvre le gestionnaire de contact depuis le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gestionContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            //ouvrir la feuille détail Afficher Client selon la ligne sélectionnée
            Int32 iClient; //rang/ligne du client dans la liste

            //récupérer l'index du client cliqué en DataGridView
            iClient = this.grdDataGridViewClient.CurrentRow.Index;

            //on pointe un objet client vers la liste d'origine
            //        MClient clientSelectionne = Donnees.ListClient[iClient];

            //rechercher le client correspondant à la ligne double-cliquée
            Int32 idClient;
            //id du client dans la collection
            // idClient = (int)this.grdDataGridViewClient.CurrentRow.Cells[0].Value;
            idClient = Convert.ToInt32(this.grdDataGridViewClient.CurrentRow.Cells[0].Value);

            Table_Client leClientEF = Donnees.Db.Table_Client.Find(idClient);

            //rechercher l'objet Entity
            MClient leClient = new MClient();
            leClient.RaisonSociale = leClientEF.raisonSociale;
            leClient.IdClient = (UInt32)leClientEF.idClient;
            leClient.AdresseClient = leClientEF.adresseClient;
            leClient.TelephoneClient = leClientEF.telephoneClient;
            leClient.DomaineActivite = leClientEF.domaineActivite;
            leClient.TypeClient = leClientEF.typeClient;
            leClient.NatureClient = leClientEF.natureClient;
            leClient.EffectifClient = (UInt32)leClientEF.effectifClient;
            leClient.ChiffreAffaireClient = (UInt32)leClientEF.chiffreAffaireClient;
            leClient.CommentairesClient = leClientEF.commentairesClient;

            frmGestionContacts formulaireGestionContacts = new frmGestionContacts(leClient);
            formulaireGestionContacts.ShowDialog();

        }
    }
}
