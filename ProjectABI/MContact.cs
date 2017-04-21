using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectABI
{
    /// <summary>
    /// classe des contacts clients
    /// comporte les attibuts des contacts
    /// </summary>

    class MContact
    {
       
        /// <summary>
        /// attributs du contact
        /// </summary>
        private String adresseContact;
        private String commentairesContact;
        private String telephoneContact;
        private String nomContact;
        private Int32 idClient;      
      //private String raisonSociale;

        public Int32 IdClient
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


    /* public String RaisonSociale
        {
            get
            {
                return raisonSociale;
            }
            set
            {
                raisonSociale = value;
            }
        }
        */
        


    

        /// <summary>
        /// attribut adresse Client
        /// aucun contrôle
        /// </summary>       
        public String AdresseContact
        {
            get
            {
                return adresseContact;
            }

            set
            {
                adresseContact = value;
            }
        }

        /// <summary>
        /// attribut commentaires Contact
        /// aucun contrôle
        /// </summary>        
        public String CommentairesContact
        {
            get
            {
                return commentairesContact;
            }

            set
            {
                commentairesContact = value;
            }
        }

        /// <summary>
        /// attribut téléphone Contact
        /// </summary>     
        public String TelephoneContact
        {
            get
            {
                return telephoneContact;
            }

            set
            {
                telephoneContact = value;
            }
        }

        /// <summary>
        /// attribut nom du contact
        /// </summary>     
        public string NomContact
        {
            get
            {
                return nomContact;
            }

            set
            {
                if(value == "")
                {
                    //envoi messageBox erreur
                    MessageBox.Show(
                        "Erreur ! Le contact doit obligatoirement avoir un nom !", "Erreur de saisie",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Exception ex = new Exception();
                    throw ex;
                }
                else
                {
                     nomContact = value;
                }
               
            }
        }

       
    }
}
