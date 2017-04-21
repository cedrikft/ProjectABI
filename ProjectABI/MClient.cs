using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectABI
{
    /// <summary>
    /// classe des clients
    /// comporte les attibuts des clients
    /// </summary>
    class MClient
    {
        /// <summary>
        /// classe static
        /// on utilise un int non signé
        /// </summary>
        public static UInt32 numeroClient = 1;

        /// <summary>
        /// attributs du contact
        /// </summary>
        private UInt32 idClient;
        private String raisonSociale;
        private String typeClient;
        private String domaineActivite;
        private String adresseClient;
        private String telephoneClient;
        private String natureClient;
        private UInt32 chiffreAffaireClient;
        private UInt32 effectifClient;
        private String commentairesClient;
        private List<MContact> listContacts = new List<MContact>();


        /// <summary>
        /// attribut static numeroClient
        /// </summary>
        public UInt32 NumeroClient
        {
            get
            {
                return numeroClient;
            }

        }

        /// <summary>
        /// attribut raisonSocial
        /// lecture en majuscule
        /// </summary>  
        public String RaisonSociale
        {
            get
            {
                return raisonSociale.Trim().ToUpper();
            }

            set
            {

                // un client a obligatoirement une raison sociale
                if (value == "")
                {
                   DialogResult result = MessageBox.Show(
                        "Erreur ! Le client doit avoir obligatoirement un nom.", "Erreur de saisie !",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Exception ex = new Exception();
                    throw ex;
             
                    
                }


                else
                {
                    raisonSociale = value;
                }

               
            }
        }


        /// <summary>
        /// attribut type Client
        /// aucun contrôle
        /// </summary>
        public String TypeClient
        {
            get
            {
                return typeClient;
            }

            set
            {
                typeClient = value;
            }
        }


        /// <summary>
        /// attribut domaine Activité Client
        /// aucun contrôle
        /// </summary>    
        public String DomaineActivite
        {
            get
            {
                return domaineActivite;
            }

            set
            {
                domaineActivite = value;
            }
        }



        /// <summary>
        /// attribut adresse Client
        /// aucun contrôle
        /// </summary>      
        public String AdresseClient
        {
            get
            {
                return adresseClient;
            }

            set
            {
                adresseClient = value;
            }
        }


        /// <summary>
        /// attribut téléphone Client
        /// </summary>
        public String TelephoneClient
        {
            get
            {
                return telephoneClient;
            }

            set
            {
                telephoneClient = value;
            }
        }


        /// <summary>
        /// attribut chiffre Affaire Client
        /// aucun contrôle
        /// </summary>      
        public String NatureClient
        {
            get
            {
                return natureClient;
            }

            set
            {

                natureClient = value;
            }
        }



        /// <summary>
        /// attribut chiffre Affaire Client
        /// on utilise un int non signé
        /// </summary>      
        public UInt32 ChiffreAffaireClient
        {
            get
            {
                return chiffreAffaireClient;
            }

            set
            {
                if(value < 1)
                {
                    MessageBox.Show("Erreur ! Le chiffre d'affaire ne peut pas être inférieur à 1 M€ !", "Erreur de saisie",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Exception ex = new Exception();
                    throw ex;
                }
               else if (value / effectifClient > 1)
                {
                    //envoi messageBox erreur
                    MessageBox.Show(
                        "Erreur ! Ce chiffre d'affaire est incohérent ! Le chiffre d'affaire ne peut pas dépassé 1M€ par membre de l'effectif !", "Erreur de saisie",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Exception ex = new Exception();
                    throw ex;
                }
        
                else
                {
                    chiffreAffaireClient = value;
                }
                

              
            }
        }

        /// <summary>
        /// attribut effectif
        /// on utilise un int non signé
        /// </summary>      
        public UInt32 EffectifClient
        {
            get
            {
                return effectifClient;
            }

            set
            {
               
                // un client étant au minimum consitué d'un personne, ce champs doit être supérieur à 0
               if(value <= 0)
                {
                    //envoi messageBox erreur
                    MessageBox.Show(
                        "Erreur ! L'effectif ne peut pas être inférieur à 1 !", "Erreur de saisie !",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Exception ex = new Exception();
                    throw ex;
                }

               
                else
                { 
                
                        effectifClient = value; 
                }

             }
        }



        /// <summary>
        /// attribut commentaires Client
        /// aucun contrôle
        /// </summary>     
        public String CommentairesClient
        {
            get
            {
                return commentairesClient;
            }

            set
            {
                commentairesClient = value;
            }
        }

        /// <summary>
        /// attribut de liste des contacts du clients
        /// </summary>      
        public List<MContact> ListContacts
        {
            get
            {
                return listContacts;
            }

            set
            {
                listContacts = value;
            }
        }

        /// <summary>
        /// attribut idClient
        /// </summary>
        public uint IdClient
        {
            get
            {
                return idClient;
            }

            set
            {
                idClient = value;
            }
        }

        /// <summary>
        /// constructeur par defaut
        /// </summary>
        public MClient()
        {
          //  numeroClient++;

        }

    }
}
