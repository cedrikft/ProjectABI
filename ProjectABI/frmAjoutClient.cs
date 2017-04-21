using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace ProjectABI
{
    public partial class frmAjoutClient : ProjectABI.frmAfficherClient
    {
        /// <summary>
        /// constructeur par defaut
        /// </summary>
        public frmAjoutClient()
        {
            InitializeComponent();
            init();
        }

        /// <summary>
        /// méthode d'initialisation des éléments
        /// </summary>
        protected override void init()
        {

            txtRaisonSociale.Enabled = true;
            txtNumeroClient.Enabled = false;
            txtNumeroClient.Text = (Tools.getMaxIDClient()+1).ToString();
            txtAdresse.Enabled = true;
            txtTelephone.Enabled = true;
            txtDomaine.Enabled = true;

            txtChiffreAffaire.Enabled = true;
            txtEffectif.Enabled = true;
            txtCommentaires.Enabled = true;
            btnDetailsContact.Visible = false;

            //boutons enregistrer
            btnEnregistrer.Visible = true;
            btnEnregisterModification.Visible = false;

            


            //       ajoutClientTest();

        }

        /// <summary>
        /// enregistrer un nouveau client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //appels de la méthode instancie
            instancie();
         
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// récupère le numéro de client le plus grand
        /// </summary>
        /// <returns></returns>
       /* private Int32 getMaxIDClient()
        {
            Int32 maxIdClient = 0;
            foreach (Table_Client unautreClient in Donnees.Db.Table_Client.ToList())
            {
                if (maxIdClient < unautreClient.idClient)
                {
                    maxIdClient = unautreClient.idClient;
                }
            }

            return maxIdClient;
        }*/

        /// <summary>
        /// méthode d'instanciation de l'ojet client
        /// </summary>
        /// <returns></returns>
        private Boolean instancie()
        {
            // créer un nouveau client
            MClient nouveauClient = new MClient();
            try
            {
                
                nouveauClient.RaisonSociale = txtRaisonSociale.Text;
/*
                Int32 maxIdClient = 0;
                foreach (Table_Client unautreClient in Donnees.Db.Table_Client.ToList()) {
                    if(maxIdClient < unautreClient.idClient)
                    {
                        maxIdClient = unautreClient.idClient;
                    }
                }
                */
                nouveauClient.IdClient = Convert.ToUInt32(Tools.getMaxIDClient()+1);


                nouveauClient.AdresseClient = txtAdresse.Text;
                nouveauClient.TelephoneClient = txtTelephone.Text;
                nouveauClient.DomaineActivite = txtDomaine.Text;

                if (this.cbnTypeClient.SelectedIndex >= 0)
                {
                    nouveauClient.TypeClient = this.cbnTypeClient.SelectedItem.ToString();
                }

                if (this.cbnNatureClient.SelectedIndex >= 0)
                {
                    nouveauClient.NatureClient = this.cbnNatureClient.SelectedItem.ToString();
                }

                          

                if(txtEffectif.Text == "")
                {
                    MessageBox.Show("Veuilez entrer l'effectif de la société cliente !", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Exception ex = new Exception();
                    throw ex;
                }
                else
                {
                    nouveauClient.EffectifClient = UInt32.Parse(txtEffectif.Text);
                }


                if (txtChiffreAffaire.Text == "")
                {
                   DialogResult resultat = MessageBox.Show("Veuilez entrer le chiffre d'affaire de la société cliente !", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  
                        Exception ex = new Exception();
                        throw ex;                                                  
                }
                else
                {
                    nouveauClient.ChiffreAffaireClient = UInt32.Parse(txtChiffreAffaire.Text);
                }

           
                nouveauClient.CommentairesClient = txtCommentaires.Text;


                //impact sur la BDD
                //-----------------------------------------
                //création et renseignement Entity Client
                Table_Client nouveauClientEF = new Table_Client();
                nouveauClientEF.raisonSociale = nouveauClient.RaisonSociale;
                

                nouveauClientEF.idClient = Convert.ToInt32(nouveauClient.IdClient);


                nouveauClientEF.adresseClient = nouveauClient.AdresseClient;
                nouveauClientEF.telephoneClient = nouveauClient.TelephoneClient;
                nouveauClientEF.domaineActivite = nouveauClient.DomaineActivite;

                if (this.cbnTypeClient.SelectedIndex >= 0)
                {
                    nouveauClientEF.typeClient = this.cbnTypeClient.SelectedItem.ToString();
                }

                if (this.cbnNatureClient.SelectedIndex >= 0)
                {
                    nouveauClientEF.natureClient = this.cbnNatureClient.SelectedItem.ToString();
                }
            
                nouveauClientEF.effectifClient = (Int32)nouveauClient.EffectifClient;
                nouveauClientEF.chiffreAffaireClient = (Int32)nouveauClient.ChiffreAffaireClient;
                nouveauClientEF.commentairesClient = nouveauClient.CommentairesClient;

                //insertion en dbcontext
                Donnees.Db.Table_Client.Add(nouveauClientEF);

                //mise à jour BDD
                Donnees.Db.SaveChanges();


                MClient.numeroClient++;

            //    Donnees.ListClient.Add(nouveauClient);

                var result = MessageBox.Show("Le nouveau client " + nouveauClient.RaisonSociale + " a été ajouté avec succès ! ", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;

            }
           
            catch (Exception ex)
            {
                nouveauClient = null;
                   MessageBox.Show("Erreur ajout de client" , "Ajout de client");
            
                return false;
            }


        }

        /// <summary>
        /// jeux d'essais
        /// </summary>
        private void ajoutClientTest()
        {
           /* for (int i = 0; i < 10; i++)
            {
                MClient nouveauClient = new MClient();

                this.cbnTypeClient.SelectedItem = "Public";
                                   
                nouveauClient.RaisonSociale = "toto" + i;         
                nouveauClient.IdClient = (UInt32)(MClient.numeroClient + i);
                nouveauClient.AdresseClient = 7 + i + " rue des miches";
                nouveauClient.TelephoneClient = "0000" + i;
                nouveauClient.DomaineActivite = "sdf";
                nouveauClient.TypeClient = this.cbnTypeClient.SelectedItem.ToString(); 
                nouveauClient.NatureClient = "Rien";
                nouveauClient.EffectifClient = (UInt32)(100 + i);
                nouveauClient.ChiffreAffaireClient = (UInt32)(3 + i);               
                nouveauClient.CommentairesClient = i + " de QI";

                Donnees.ListClient.Add(nouveauClient);
            }
            */
        }

  

        private void cbnTypeClient_DropDown(object sender, EventArgs e)
        {
            if (this.cbnTypeClient.SelectedIndex >= 0)
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
