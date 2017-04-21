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
    public partial class frmAfficherClient : Form
    {
        //référence du client à afficher ou modifier
        private MClient clientSelectionne;

        /// <summary>
        /// accesseurs de l'attribut clientSelectionné
        /// </summary>
        internal MClient ClientSelectionne
        {
            get
            {
                return clientSelectionne;
            }

            set
            {
                clientSelectionne = value;
            }
        }

        /// <summary>
        /// constructeur par défaut
        /// </summary>
        public frmAfficherClient()
        {
            InitializeComponent();
            init();
        }

        /// <summary>
        /// constructeur : on mémorise le client sélectionné
        /// </summary>
        internal frmAfficherClient(MClient clientATraiter)
        {
            this.ClientSelectionne = clientATraiter;

            InitializeComponent();
            init();
        }

        /// <summary>
        /// méthode d'initialisation des éléments
        /// </summary>
        protected virtual void init()
        {
            txtRaisonSociale.Enabled = false;
            txtNumeroClient.Enabled = false;
            txtNumeroClient.Enabled = false;
            txtAdresse.Enabled = false;
            txtTelephone.Enabled = false;
            txtDomaine.Enabled = false;
            cbnTypeClient.Enabled = false;
            cbnNatureClient.Enabled = false;
            txtChiffreAffaire.Enabled = false;
            txtEffectif.Enabled = false;
            txtCommentaires.Enabled = false;
            //boutons enregistrer
            btnModifier.Enabled = true;
            btnEnregistrer.Visible = false;
            btnEnregisterModification.Enabled = false;

        }


        /// <summary>
        /// permet la modification quand click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            txtRaisonSociale.Enabled = true;
            txtNumeroClient.Enabled = false;
            txtAdresse.Enabled = true;
            txtTelephone.Enabled = true;
            txtDomaine.Enabled = true;
            cbnTypeClient.Enabled = true;
            cbnNatureClient.Enabled = true;
            txtChiffreAffaire.Enabled = true;
            txtEffectif.Enabled = true;
            txtCommentaires.Enabled = true;
            btnEnregistrer.Visible = false;
            btnEnregisterModification.Enabled = true;
        }

        /// <summary>
        /// Contrôle divers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAfficherClient_Load(object sender, EventArgs e)
        {
            //afficher le client
            if (this.ClientSelectionne != null)
            {
                this.afficheClient(this.ClientSelectionne);
            }


        }


        /// <summary>
        /// assigne les valeurs aux txtBox
        /// </summary>
        /// <param name="clientATraiter"></param>
        private void afficheClient(MClient clientATraiter)
        {
            //on affecte les textBoxs
            this.txtRaisonSociale.Text = clientATraiter.RaisonSociale;
      
                this.txtAdresse.Text = clientATraiter.AdresseClient.Trim();
            
          
            this.txtCommentaires.Text = clientATraiter.CommentairesClient.Trim();
            this.txtDomaine.Text = clientATraiter.DomaineActivite.Trim();
            this.txtNumeroClient.Text = clientATraiter.IdClient.ToString();
            this.txtTelephone.Text = clientATraiter.TelephoneClient.Trim();
            this.txtEffectif.Text = clientATraiter.EffectifClient.ToString();
            this.txtChiffreAffaire.Text = clientATraiter.ChiffreAffaireClient.ToString();

            if (clientATraiter.TypeClient != null)
            {
                this.cbnTypeClient.Text = clientATraiter.TypeClient;
            }

            if (clientATraiter.NatureClient != null)
            {
                this.cbnNatureClient.Text = clientATraiter.NatureClient;
            }
        }


        /// <summary>
        /// ouvre le gestionnaire de contacts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetailsContact_Click(object sender, EventArgs e)
        {


            frmGestionContacts monFormulaireGestionContacts = new frmGestionContacts(ClientSelectionne);
            monFormulaireGestionContacts.Show();

        }

        /// <summary>
        /// enregistrement d'un client modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MClient clientTemporaire = new MClient();          

            if (this.ClientSelectionne != null)
            {
                try
                {
                    //modification d'un client
                    clientTemporaire.RaisonSociale = txtRaisonSociale.Text;
                    clientTemporaire.IdClient = UInt32.Parse(txtNumeroClient.Text);         
                    clientTemporaire.AdresseClient = txtAdresse.Text;
                    clientTemporaire.TelephoneClient = txtTelephone.Text;
                    clientTemporaire.DomaineActivite = txtDomaine.Text;
                  

                    if (txtEffectif.Text == "")
                    {
                        MessageBox.Show("Veuilez entrer l'effectif de la société cliente !", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Exception ex = new Exception();
                        throw ex;
                    }
                    else
                    {
                        clientTemporaire.EffectifClient = UInt32.Parse(txtEffectif.Text);
                    }


                    if (txtChiffreAffaire.Text == "")
                    {
                        DialogResult resultat = MessageBox.Show("Veuilez entrer le chiffre d'affaire de la société cliente !", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        Exception ex = new Exception();
                        throw ex;
                    }
                    else
                    {
                        clientTemporaire.ChiffreAffaireClient = UInt32.Parse(txtEffectif.Text);
                    }
     

                    clientTemporaire.CommentairesClient = txtCommentaires.Text;
    

                    //comboBox
                    if (this.cbnTypeClient.SelectedIndex >= 0)
                    {
                        clientTemporaire.TypeClient = this.cbnTypeClient.SelectedItem.ToString();
                    }

                    if (this.cbnNatureClient.SelectedIndex >= 0)
                    {
                        clientTemporaire.NatureClient = this.cbnNatureClient.SelectedItem.ToString();
                    }

       
                       var result = MessageBox.Show("Modifier le client", "Voulez-vous vraiment modifier de façon définitive ce client ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {

                       
                           //impact sur la BDD
                            //-----------------------------------------
                            //création et renseignement Entity Client
                
                             Table_Client nouveauClientEF = Donnees.Db.Table_Client.Find(Convert.ToInt32(txtNumeroClient.Text));
                                
                             nouveauClientEF.raisonSociale = clientTemporaire.RaisonSociale;                      
                             nouveauClientEF.adresseClient = clientTemporaire.AdresseClient;
                             nouveauClientEF.telephoneClient = clientTemporaire.TelephoneClient;
                             nouveauClientEF.domaineActivite = clientTemporaire.DomaineActivite;

                             if (this.cbnTypeClient.SelectedIndex >= 0)
                             {
                                 nouveauClientEF.typeClient = this.cbnTypeClient.SelectedItem.ToString();
                             }

                             if (this.cbnNatureClient.SelectedIndex >= 0)
                             {
                                 nouveauClientEF.natureClient = this.cbnNatureClient.SelectedItem.ToString();
                             }

                             nouveauClientEF.effectifClient = Convert.ToInt32(clientTemporaire.EffectifClient);
                             nouveauClientEF.chiffreAffaireClient = Convert.ToInt32(clientTemporaire.ChiffreAffaireClient);
                             nouveauClientEF.commentairesClient = clientTemporaire.CommentairesClient;
                                
                            //mise à jour BDD
                            Donnees.Db.SaveChanges();


                            MessageBox.Show( "Le client a été modifié avec succès !", "Modifier le client", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
          
                }

                catch (Exception ex)
                {
                    var result = MessageBox.Show("Erreur !", "Non ! Catch !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    clientTemporaire = null;
                    if(result == DialogResult.No)
                    {
                        this.Close();
                    }
                    
                }


              

            }

        }
    
    
           
        

       private void cbnTypeClient_DropDown(object sender, EventArgs e)
        {
        
            if(this.cbnTypeClient.SelectedIndex >= 0)
            {
                this.ClientSelectionne.TypeClient = this.cbnTypeClient.SelectedItem.ToString();
            }
            
        }

        private void cbnNatureClient_DropDown(object sender, EventArgs e)
        {
            if (this.cbnNatureClient.SelectedIndex >= 0)
            {
                this.ClientSelectionne.NatureClient = this.cbnNatureClient.SelectedItem.ToString();
            }
        }

    }
}
