using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ProjectABI
{
    public partial class frmGestionContacts : ProjectABI.frmGestionClient
    {
        /// <summary>
        /// attribut monClient
        /// </summary>
        private MClient monClient;

        /// <summary>
        /// accesseurs de monClient
        /// </summary>
        internal MClient MonClient
        {
            get
            {
                return monClient;
            }

            set
            {
                monClient = value;
            }
        }

        /// <summary>
        /// constructeur par defaut
        /// </summary>
        public frmGestionContacts()
        {
            InitializeComponent();
            init();
            grdDataGridViewClient.Visible = false;
            //   btnSupprimerContact.Enabled = false;

            
            menuStrip1.Visible = false;
            menuStrip1.Enabled = false;

            grdDataGridViewContact.Size = new Size(633, 486);
        }


        /// <summary>
        /// constructeur adapté qui mémorise le client à traiter
        /// </summary>
        /// <param name="clientATraiter"></param>
        internal frmGestionContacts(MClient clientATraiter)
        {
            this.MonClient = clientATraiter;
            InitializeComponent();
            init();
            grdDataGridViewClient.Visible = false;
        //    btnSupprimerContact.Enabled = false;
            menuStrip1.Visible = false;
            menuStrip1.Enabled = false;
           

            grdDataGridViewContact.Size = new Size(633, 486);


        }

        /// <summary>
        /// methode d'initialisation des éléments
        /// </summary>
        private void init()
        {
         //   ajoutContactTest();

            if (Donnees.Db.Table_Contact.ToList().Count >= 1)
            {
                btnSupprimerContact.Enabled = true;            
                supprimerContactToolStripMenuItem.Enabled = true;
                btnAfficherContacts.Enabled = true;
            }
            else
            {
                btnSupprimerContact.Enabled = false;
                supprimerContactToolStripMenuItem.Enabled = false;
                btnAfficherContacts.Enabled = false;
            }
            

            btnSupprimerClient.Visible = false;
            btnAfficherContacts.Visible = true;
            grpContact.Visible = false;
            btnModifier.Visible = false;
            modifierToolStripMenuItem.Visible = false;

            btnEnregistrer.Visible = false;
            enregistrerToolStripMenuItem.Visible = false;
            btnAfficherContacts.Visible = false;

            txtRaisonSociale.Enabled = false;
            btnAgrandir.Enabled = false;
            agrandirListeToolStripMenuItem.Enabled = false;

            btnEnregistrer.Enabled = false;
            enregistrerToolStripMenuItem.Enabled = false;
            txtRaisonSociale.Text = monClient.RaisonSociale;
            modifierToolStripMenuItem.Enabled = false;

            afficheContact();

        }

        /// <summary>
        /// affiche les détails du contact quand click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    /*    protected override void btnAfficherContacts_Click(object sender, EventArgs e)
        {
            grpContact.Text = "Détail contact";
            txtNomContact.Enabled = false;
            txtTelephone.Enabled = false;
            txtCommentaires.Enabled = false;
            txtAdresse.Enabled = false;
            grpContact.Visible = true;
            btnEnregistrer.Visible = true;
            btnEnregistrer.Enabled = false;
            enregistrerToolStripMenuItem.Visible = true;
            enregistrerToolStripMenuItem.Enabled = false;
            btnModifier.Visible = true;
            btnModifier.Enabled = true;
            modifierToolStripMenuItem.Visible = true;
            modifierToolStripMenuItem.Enabled = true;

            btnAgrandir.Enabled = true;
            agrandirListeToolStripMenuItem.Enabled = true;
            grdDataGridViewContact.Size = new Size(633, 202);

            Int32 iContact = this.grdDataGridViewContact.CurrentRow.Index;

            txtNomContact.Text = this.MonClient.ListContacts[iContact].NomContact;
            txtAdresse.Text = this.MonClient.ListContacts[iContact].AdresseContact;
            txtTelephone.Text = this.MonClient.ListContacts[iContact].TelephoneContact;
            txtCommentaires.Text = this.MonClient.ListContacts[iContact].CommentairesContact;
            txtRaisonSociale.Text = this.MonClient.RaisonSociale;
        }*/

        Boolean flagAjout = false;

        /// <summary>
        /// ajoute un client quand click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void btnAjouterClient_Click(object sender, EventArgs e)
        {
            grpContact.Visible = true;
            btnEnregistrer.Visible = true;
            btnEnregistrer.Enabled = true;
            enregistrerToolStripMenuItem.Visible = true;
            enregistrerToolStripMenuItem.Enabled = true;
            btnModifier.Visible = true;
            modifierToolStripMenuItem.Visible = true;

            grpContact.Text = "Ajout d'un contact";
            grdDataGridViewContact.Size = new Size(633, 202);

            txtNomContact.Enabled = true;
            txtTelephone.Enabled = true;
            txtCommentaires.Enabled = true;
            txtAdresse.Enabled = true;

            btnModifier.Enabled = false;
            modifierToolStripMenuItem.Enabled = false;
            btnAgrandir.Enabled = true;
            agrandirListeToolStripMenuItem.Enabled = true;
            modifierToolStripMenuItem.Enabled = false;

            txtNomContact.Text = null;
            txtAdresse.Text = null;
            txtTelephone.Text = null;
            txtCommentaires.Text = null;

            flagAjout = true;
        }


        /// <summary>
        /// méthode d'instanciation de l'objet client
        /// </summary>
        /// <returns></returns>
        private Boolean instancieContact()
        {

            MContact nouveauContact = new MContact();
            try
            {
                nouveauContact.NomContact = txtNomContact.Text;
                nouveauContact.AdresseContact = txtAdresse.Text.Trim();
                nouveauContact.TelephoneContact = txtTelephone.Text.Trim();
                nouveauContact.CommentairesContact = txtCommentaires.Text.Trim();
                nouveauContact.IdClient = Convert.ToInt32(monClient.IdClient);
            //  nouveauContact.RaisonSociale = this.MonClient.RaisonSociale;

                //      this.MonClient.ListContacts.Add(nouveauContact);

                // impact sur la BDD
                //----------------------------
                //création et renseignement Entity Stagiaire


                Table_Contact nouveauContactEF = new Table_Contact();

                //   Table_Contact nouveauContactEF = Donnees.Db.Table_Contact.Find(txtNomContact);

                //   Table_Contact nouveauContactEF = Donnees.Db.Table_Contact.ToList();


                nouveauContactEF.nomContact = nouveauContact.NomContact;
             
                nouveauContactEF.adresseContact = nouveauContact.AdresseContact;
              
                nouveauContactEF.telephoneContact = nouveauContact.TelephoneContact;
               
                nouveauContactEF.commentairesContact = nouveauContact.CommentairesContact;
                nouveauContactEF.idClient = nouveauContact.IdClient = Convert.ToInt32(monClient.IdClient); 


                /* Table_Contact nouveauContactEF = new Table_Contact();
                 nouveauContactEF.nomContact = nouveauContact.NomContact;
                 nouveauContactEF.adresseContact = nouveauContact.AdresseContact;
                 nouveauContactEF.telephoneContact = nouveauContact.TelephoneContact;
                 nouveauContactEF.adresseContact = nouveauContact.CommentairesContact;*/

                //insertion en dbcontext
                Donnees.Db.Table_Contact.Add(nouveauContactEF);             

                //Mise à jour de la BDD

                Donnees.Db.SaveChanges();

                MessageBox.Show("nom contactEF = " + nouveauContactEF.nomContact + " nom contact = " + nouveauContact.NomContact);

                var result = MessageBox.Show("Le nouveau contact " + nouveauContact.NomContact + " a été ajouté avec succès ! ", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;

            }
            catch (Exception ex)
            {
                nouveauContact = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Coucou");
                return false;
            }
        }

        /// <summary>
        /// affichage dans la dataGridView
        /// </summary>
        private void afficheContact()
        {
            //On utilise également une DataTable pour relié pour relier la liste de contact d'un client donné au dataGridView

            DataTable maDataTableContact = new DataTable();
            DataRow ligneDataTableContact;

            //il y a 4 colonnes sur cette DataGridView
            maDataTableContact.Columns.Add(new DataColumn("Nom du contact", typeof(System.String)));
            maDataTableContact.Columns.Add(new DataColumn("Adresse du contact", typeof(System.String)));
            maDataTableContact.Columns.Add(new DataColumn("Télephone du contact", typeof(System.String)));
            maDataTableContact.Columns.Add(new DataColumn("Commentaires ", typeof(System.String)));

            /*     //boucle de remplissage de la dataTAble à partie de la liste des contacts
                 for (int i = 0; i < this.MonClient.ListContacts.Count; i++)
                 {
                     ligneDataTableContact = maDataTableContact.NewRow();
                     ligneDataTableContact[0] = this.MonClient.ListContacts[i].NomContact;
                     ligneDataTableContact[1] = this.MonClient.ListContacts[i].AdresseContact;
                     ligneDataTableContact[2] = this.MonClient.ListContacts[i].TelephoneContact;
                     ligneDataTableContact[3] = this.MonClient.ListContacts[i].CommentairesContact;

                     maDataTableContact.Rows.Add(ligneDataTableContact);
                 }

                 this.grdDataGridViewContact.DataSource = maDataTableContact;

                 */

            foreach (Table_Contact unContactEF in Donnees.Db.Table_Contact.ToList())
            {

                //instanciation DataRow(= ligne du DataTable)
                ligneDataTableContact = maDataTableContact.NewRow();
                //affectation de 3 colonnes à partir de l'Entity
                ligneDataTableContact[0] = unContactEF.nomContact;
                ligneDataTableContact["Adresse du contact"] = unContactEF.nomContact;
                ligneDataTableContact["Télephone du contact"] = unContactEF.telephoneContact;        
                ligneDataTableContact["Commentaires "] = unContactEF.commentairesContact;

                //ajout de la ligne à la Datatable
                maDataTableContact.Rows.Add(ligneDataTableContact);

                // refraîchir l'affichage (même pas utile…) 
                this.grdDataGridViewContact.Refresh();

            }
            this.grdDataGridViewContact.DataSource = maDataTableContact;
    
            //rafraichir
            this.grdDataGridViewContact.Refresh();
          

            if (Donnees.Db.Table_Contact.ToList().Count < 1)
            {
                btnAfficherContacts.Enabled = false;

                btnSupprimerClient.Enabled = false;

                supprimerContactToolStripMenuItem.Enabled = false;

                contactToolStripMenuItem.Enabled = false;

            }

        }

        /// <summary>
        /// actions effectuées lors de l'appui sur le bouton Enregistrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
      //      Int32 iContact = this.grdDataGridViewContact.CurrentRow.Index;
            {
                MContact contactTemporaire = new MContact();
                if ((Donnees.Db.Table_Contact.ToList().Count >= 0))
                {

                    try
                    {
                       
                        contactTemporaire.NomContact = txtNomContact.Text;                   
                        contactTemporaire.AdresseContact = txtAdresse.Text.Trim();
                        contactTemporaire.TelephoneContact = txtTelephone.Text.Trim();
                        contactTemporaire.CommentairesContact = txtCommentaires.Text.Trim();

                   /*     if (contactTemporaire.Equals(this.MonClient.ListContacts[iContact]))
                        {
                            DialogResult result = MessageBox.Show("Aucune modification n'a été effectuée sur ce client !");
                        }*/
                     //   else
                    //    {
                            if(flagAjout == true)
                            {

                            /*    this.MonClient.ListContacts[iContact].NomContact = contactTemporaire.NomContact;
                                this.MonClient.ListContacts[iContact].AdresseContact = contactTemporaire.AdresseContact;
                                this.MonClient.ListContacts[iContact].TelephoneContact = contactTemporaire.TelephoneContact;
                                this.MonClient.ListContacts[iContact].CommentairesContact = contactTemporaire.CommentairesContact;*/

                            //     Table_Contact nouveauContactEF = Donnees.Db.Table_Contact.Find(Convert.ToInt32(txtNumeroClient.Text));
/*
                                Table_Contact nouveauContactEF = new Table_Contact();

                            //   Table_Contact nouveauContactEF = Donnees.Db.Table_Contact.Find(txtNomContact);

                            //   Table_Contact nouveauContactEF = Donnees.Db.Table_Contact.ToList();

                            
                            nouveauContactEF.nomContact = contactTemporaire.NomContact;


                            MessageBox.Show("nom contactEF = " + nouveauContactEF.nomContact + " nom contact = " + contactTemporaire.NomContact);

                            nouveauContactEF.adresseContact = contactTemporaire.AdresseContact;
                                nouveauContactEF.telephoneContact = contactTemporaire.TelephoneContact;
                                nouveauContactEF.commentairesContact = contactTemporaire.CommentairesContact;
                                */
                               this.instancieContact();

                        //       var result = MessageBox.Show("Le contact a été enregistré avec succès !", "Ajouter un contact", MessageBoxButtons.OK, MessageBoxIcon.Question);
                              flagAjout = false;

                        }

                            else
                            {
                                var result = MessageBox.Show("Modifier le client", "Voulez-vous vraiment modifier de façon définitive ce client ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                  /*  this.MonClient.ListContacts[iContact].NomContact = contactTemporaire.NomContact;
                                    this.MonClient.ListContacts[iContact].AdresseContact = contactTemporaire.AdresseContact;
                                    this.MonClient.ListContacts[iContact].TelephoneContact = contactTemporaire.TelephoneContact;
                                    this.MonClient.ListContacts[iContact].CommentairesContact = contactTemporaire.CommentairesContact;
                                    */

                                    //impact sur la BDD
                                    //-----------------------------------------
                                    //création et renseignement Entity Client

                                    Table_Contact nouveauContactEF = Donnees.Db.Table_Contact.Find(txtNomContact.Text);

                                    nouveauContactEF.nomContact = contactTemporaire.NomContact ;
                                    nouveauContactEF.adresseContact = contactTemporaire.AdresseContact;
                                    nouveauContactEF.telephoneContact = contactTemporaire.TelephoneContact;
                                    nouveauContactEF.commentairesContact = contactTemporaire.CommentairesContact;

                                    //mise à jour BDD
                                    Donnees.Db.SaveChanges();


                                    MessageBox.Show("Le client a été modifié avec succès !", "Modifier le client", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.Close();

                                }
                            }
                                                
                      //  }
                    }
                    catch (Exception ex)
                    {
                  
                        MessageBox.Show("Erreur d'ajout de client ");
                    }

                }
               
            }

            afficheContact();
        }



        /// <summary>
        /// jeux de test
        /// </summary>
        private void ajoutContactTest()
        {
            for (int i = 0; i < 10; i++)
            {
                MContact nouveauContact = new MContact();

                nouveauContact.AdresseContact = 1 + i + " avenue des moines";
                nouveauContact.TelephoneContact = "00005" + i;
                nouveauContact.NomContact = "Jean " + i;
                nouveauContact.CommentairesContact = i + " contact";

                this.MonClient.ListContacts.Add(nouveauContact);

                if (this.MonClient.ListContacts.Count > 0)
                {
                    btnSupprimerContact.Enabled = true;             
                    supprimerContactToolStripMenuItem.Enabled = true;
                }
                afficheContact();
            }

        }

        /// <summary>
        /// supprime le contact quand click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
   /*     protected override void btnSupprimerClient_Click(object sender, EventArgs e)
        {
        
            Int32 iContact = this.grdDataGridViewContact.CurrentRow.Index;

            DialogResult result = MessageBox.Show("Etes vous sûr de vouloir supprimer définitivement ce contact ?", "Supprimer un contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.MonClient.ListContacts.RemoveAt(iContact);
            }

            afficheContact();

        }*/


        /// <summary>
        /// quand click sur le bouton modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            txtNomContact.Enabled = true;
            txtTelephone.Enabled = true;
            txtCommentaires.Enabled = true;
            txtAdresse.Enabled = true;
            btnEnregistrer.Enabled = true;
            enregistrerToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// actions quand click sur la dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdDataGridViewContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDataGridViewContact.CurrentRow != null)
            {

                Int32 iContact = this.grdDataGridViewContact.CurrentRow.Index;

                txtNomContact.Text = this.MonClient.ListContacts[iContact].NomContact;
                txtAdresse.Text = this.MonClient.ListContacts[iContact].AdresseContact;
                txtTelephone.Text = this.MonClient.ListContacts[iContact].TelephoneContact;
                txtCommentaires.Text = this.MonClient.ListContacts[iContact].CommentairesContact;

                grpContact.Text = "Détail contact";
                txtNomContact.Enabled = false;
                txtTelephone.Enabled = false;
                txtCommentaires.Enabled = false;
                txtAdresse.Enabled = false;
                grpContact.Visible = true;
                btnEnregistrer.Visible = true;
                btnEnregistrer.Enabled = false;
                enregistrerToolStripMenuItem.Visible = true;
                enregistrerToolStripMenuItem.Enabled = false;
                btnModifier.Visible = true;
                btnModifier.Enabled = true;
                modifierToolStripMenuItem.Visible = true;
                modifierToolStripMenuItem.Enabled = true;
                btnAgrandir.Enabled = true;
                agrandirListeToolStripMenuItem.Enabled = true;
                grdDataGridViewContact.Size = new Size(633, 202);
            }
        }

        /// <summary>
        /// élargie la dataGridView quand click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgrandir_Click(object sender, EventArgs e)
        {
            grdDataGridViewContact.Size = new Size(633, 486);
            btnAgrandir.Enabled = false;
            agrandirListeToolStripMenuItem.Enabled = false;
            modifierToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// permet de lancer la recherche à partir d'un nom entré dans la barre de recherche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void btnRechercher_Click(object sender, EventArgs e)
        {
            if (this.txtRecherche.Text != null)
            {
                //filtrer
                ((DataTable)(this.grdDataGridViewContact.DataSource)).DefaultView.RowFilter = "[Nom contact] like '%" + this.txtRecherche.Text + "%'";
                btnTous.Enabled = true;
            }
        }

        /// <summary>
        /// enlève le filtre généré par le click sur le bouton recherché 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void btnTous_Click(object sender, EventArgs e)
        {
            this.txtRecherche.Text = null;
            ((DataTable)(this.grdDataGridViewContact.DataSource)).DefaultView.RowFilter = null;
            btnRechercher.Enabled = false;
            btnTous.Enabled = false;
        }

        /// <summary>
        /// gestion des événements double clicks sur la datagridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdDataGridViewContact_DoubleClick(object sender, EventArgs e)
        {

            Int32 iContact = this.grdDataGridViewContact.CurrentRow.Index;

            if (iContact >= 0 && iContact < this.MonClient.ListContacts.Count)
            {
                txtNomContact.Enabled = true;
                txtTelephone.Enabled = true;
                txtCommentaires.Enabled = true;
                txtAdresse.Enabled = true;
                btnEnregistrer.Enabled = true;
                enregistrerToolStripMenuItem.Enabled = true;

                txtNomContact.Text = this.MonClient.ListContacts[iContact].NomContact;
                txtAdresse.Text = this.MonClient.ListContacts[iContact].AdresseContact;
                txtTelephone.Text = this.MonClient.ListContacts[iContact].TelephoneContact;
                txtCommentaires.Text = this.MonClient.ListContacts[iContact].CommentairesContact;

                grpContact.Text = "Détail contact";
                grpContact.Visible = true;
                btnEnregistrer.Visible = true;
                enregistrerToolStripMenuItem.Visible = true;               
                btnModifier.Visible = true;
                btnModifier.Enabled = true;
                modifierToolStripMenuItem.Visible = true;
                modifierToolStripMenuItem.Enabled = true;
                btnAgrandir.Enabled = true;
                agrandirListeToolStripMenuItem.Enabled = true;
                grdDataGridViewContact.Size = new Size(633, 202);
            }

        }

        /// <summary>
        /// gestion des événements lors d'un changement de focus sur la datagridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdDataGridViewContact_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDataGridViewContact.CurrentRow != null)
            {
                Int32 iContact = this.grdDataGridViewContact.CurrentRow.Index;

                if (iContact >= 0 && iContact < this.MonClient.ListContacts.Count)
                {
                    txtNomContact.Text = this.MonClient.ListContacts[iContact].NomContact;
                    txtAdresse.Text = this.MonClient.ListContacts[iContact].AdresseContact;
                    txtTelephone.Text = this.MonClient.ListContacts[iContact].TelephoneContact;
                    txtCommentaires.Text = this.MonClient.ListContacts[iContact].CommentairesContact;

                    grpContact.Text = "Détail contact";
                    txtNomContact.Enabled = false;
                    txtTelephone.Enabled = false;
                    txtCommentaires.Enabled = false;
                    txtAdresse.Enabled = false;
                    grpContact.Visible = true;
                    btnEnregistrer.Visible = true;
                    btnEnregistrer.Enabled = false;
                    enregistrerToolStripMenuItem.Visible = true;
                    enregistrerToolStripMenuItem.Enabled = false;
                    btnModifier.Visible = true;
                    btnModifier.Enabled = true;
                    modifierToolStripMenuItem.Visible = true;
                    modifierToolStripMenuItem.Enabled = true;
                    btnAgrandir.Enabled = true;
                    agrandirListeToolStripMenuItem.Enabled = true;
                    grdDataGridViewContact.Size = new Size(633, 202);
                }

            }
        }




        /// <summary>
        /// ferme le gestionnaire de contact depuis le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Voulez-vous vraiment quitter le gestionnaire de contact ?", "Quitter le gestionnaire de contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }



        /// <summary>
        /// permet d'ajouter un contact depuis le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpContact.Visible = true;
            btnEnregistrer.Visible = true;
            btnEnregistrer.Enabled = true;
            enregistrerToolStripMenuItem.Visible = true;
            enregistrerToolStripMenuItem.Enabled = true;
            btnModifier.Visible = true;
            modifierToolStripMenuItem.Visible = true;

            grpContact.Text = "Ajout d'un contact";
            grdDataGridViewContact.Size = new Size(633, 202);

            txtNomContact.Enabled = true;
            txtTelephone.Enabled = true;
            txtCommentaires.Enabled = true;
            txtAdresse.Enabled = true;

            btnModifier.Enabled = false;
            modifierToolStripMenuItem.Enabled = false;
            btnAgrandir.Enabled = true;
            agrandirListeToolStripMenuItem.Enabled = true;

            txtNomContact.Text = null;
            txtAdresse.Text = null;
            txtTelephone.Text = null;
            txtCommentaires.Text = null;



        }

        /// <summary>
        /// permet de supprimer un contact depuis le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            btnSupprimerContact.Enabled = true;

            Int32 iStag = this.grdDataGridViewContact.CurrentRow.Index;


            Int32 idStag;// id du stagiaire dans la collection
                         //récupérer id du stagiaire cliqué en DataGridView
            idStag = (int)this.grdDataGridViewContact.CurrentRow.Cells[0].Value;

            //retrouver l'objet EF Stagiaire dans la collection dbContext 
            Table_Contact leContactEF = Donnees.Db.Table_Contact.Find(idStag);


            //  Int32 iContact = this.grdDataGridViewContact.CurrentRow.Index;

            DialogResult result = MessageBox.Show("Etes vous sûr de vouloir supprimer définitivement ce contact ?", "Supprimer un contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // this.MonClient.ListContacts.RemoveAt(iContact);

                //supprimer de la collection EF
                Donnees.Db.Table_Contact.Remove(leContactEF);
                //impacter en BDD
                Donnees.Db.SaveChanges();

            }

            afficheContact();
            if (this.MonClient.ListContacts.Count < 1)
            {
                btnSupprimerContact.Enabled = false;
            }
        }



        /// <summary>
        /// permet d'agrandir la datagridView depuis le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void agrandirListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grdDataGridViewContact.Size = new Size(633, 486);
            btnAgrandir.Enabled = false;
            agrandirListeToolStripMenuItem.Enabled = false;
        }



        /// <summary>
        /// permet de modifier le contact depuis le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNomContact.Enabled = true;
            txtTelephone.Enabled = true;
            txtCommentaires.Enabled = true;
            txtAdresse.Enabled = true;
            btnEnregistrer.Enabled = true;
            enregistrerToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// permet d'enregistrer le contact depuis le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Int32 iContact = this.grdDataGridViewContact.CurrentRow.Index;
            {
                MContact contactTemporaire = new MContact();

                if (this.MonClient.ListContacts != null)
                {
                    contactTemporaire.NomContact = txtNomContact.Text;
                    contactTemporaire.AdresseContact = txtAdresse.Text;
                    contactTemporaire.TelephoneContact = txtTelephone.Text;
                    contactTemporaire.CommentairesContact = txtCommentaires.Text;
                }

                if (contactTemporaire.Equals(this.MonClient.ListContacts[iContact]))
                {
                    MessageBox.Show("Aucune modification n'a été effectuée sur ce contact !");
                }
                else
                {
                    var result = MessageBox.Show("Modifier le client", "Voulez-vous vraiment modifier de façon définitive ce contact ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)

                    {
                        this.MonClient.ListContacts[iContact].NomContact = contactTemporaire.NomContact;
                        this.MonClient.ListContacts[iContact].AdresseContact = contactTemporaire.AdresseContact;
                        this.MonClient.ListContacts[iContact].TelephoneContact = contactTemporaire.TelephoneContact;
                        this.MonClient.ListContacts[iContact].CommentairesContact = contactTemporaire.CommentairesContact;

                   
                    }
                }
            }

            afficheContact();
        }

        /// <summary>
        /// supprime un contact quand click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerContact_Click(object sender, EventArgs e)
        {
           
            {
                btnSupprimerContact.Enabled = true;

                Int32 iStag = this.grdDataGridViewContact.CurrentRow.Index;


                Int32 idStag;// id du stagiaire dans la collection
                             //récupérer id du stagiaire cliqué en DataGridView
                idStag = Convert.ToInt32(this.grdDataGridViewContact.CurrentRow.Cells[0].Value);

                //retrouver l'objet EF Stagiaire dans la collection dbContext 
                Table_Contact leContactEF = Donnees.Db.Table_Contact.Find(idStag);


              //  Int32 iContact = this.grdDataGridViewContact.CurrentRow.Index;

                DialogResult result = MessageBox.Show("Etes vous sûr de vouloir supprimer définitivement ce contact ?", "Supprimer un contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // this.MonClient.ListContacts.RemoveAt(iContact);

                    //supprimer de la collection EF
                    Donnees.Db.Table_Contact.Remove(leContactEF);
                    //impacter en BDD
                    Donnees.Db.SaveChanges();

                }
               
                afficheContact();
                if (this.MonClient.ListContacts.Count < 1)
                {
                    btnSupprimerContact.Enabled = false;
                }
            }
          
        }


           
    }
}
