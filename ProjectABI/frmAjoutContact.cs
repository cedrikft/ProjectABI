using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectABI
{
    public partial class frmAjoutContact : ProjectABI.frmAfficherContact
    {
        //on a ajouter une propriété client
        private MClient clientSelectionne;

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

        //constructeur par defaut
        internal frmAjoutContact()
        {
       //     this.ClientSelectionne = clientATraiter;
            InitializeComponent();
            init();
        }

        //on a ajouté un parametre au constructeur, et la portée de public à internal
        internal frmAjoutContact(MClient clientATraiter)
        {
            this.ClientSelectionne = clientATraiter;
            InitializeComponent();
            init();
        }



        private void init()
        {
            lblInformationsContact.Text = "Ajouter un contat à " + Donnees.ListClient[MClient.IDClient].RaisonSociale;

            btnModifier.Visible = false;
            txtRaisonSociale.Visible = false;
            lblRaisonSociale.Visible = false;
            btnEnregistrer.Enabled = true;
            txtRaisonSociale.Enabled = false;
            txtNomContact.Enabled = true;
            txtAdresse.Enabled = true;
            txtTelephoneContact.Enabled = true;
            txtCommentaires.Enabled = true;
        }

   

        private Boolean instancieContact()
        {
            // créer un nouveau client
            MContact nouveauContact = new MContact();
            try
            {
               // DialogResult test = MessageBox.Show(Donnees.ListClient[MClient.IDClient].RaisonSociale);

                
           //     nouveauContact.RaisonSociale = Donnees.ListClient[MClient.IDClient].RaisonSociale; 
                nouveauContact.AdresseContact = txtAdresse.Text;
                nouveauContact.CommentairesContact = txtCommentaires.Text;
                nouveauContact.TelephoneContact = UInt32.Parse(txtTelephoneContact.Text);
                nouveauContact.NomContact = txtNomContact.Text;


          //    DialogResult resulta5 = MessageBox.Show("client " + Donnees.ListClient[0].RaisonSociale + " contact " + nouveauContact.RaisonSociale);


              //  DialogResult resulta3= MessageBox.Show("client " + MClient.IDClient + " contact " + nouveauContact.RaisonSociale);


          //      DialogResult resulta = MessageBox.Show("try1");
                //fonctionne peut être. On essaye de mettre un contact dans l'attribut du client selectionner.
             // Donnees.ListClient[0].ContactDuClients.Add(nouveauContact);
             //   ClientSelectionne.ContactDuClients.Add(nouveauContact);
                

                Donnees.ListClient[MClient.IDClient].ContactDuClients.Add(nouveauContact);

     

                DialogResult result = MessageBox.Show("Le nouveau contact " + nouveauContact.NomContact + " a été ajouté avec succès ! ", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                return true;
            }

            catch (Exception ex)
            {

                nouveauContact = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de contact");
                return false;
            }


        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            //appels de la méthode instancie
            instancieContact();
            DialogResult = DialogResult.OK;
          //  btnAjouterContact.Enabled = false;
            btnEnregistrer.Enabled = false;
            this.Close();
        }
    }
}
