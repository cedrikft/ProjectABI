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
    public partial class frmAfficherContact : Form
    {
        public frmAfficherContact()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            txtRaisonSociale.Enabled = false;
            txtNomContact.Enabled = false;
            txtAdresse.Enabled = false;
            txtTelephoneContact.Enabled = false;
            txtCommentaires.Enabled = false;

            //boutons
            btnModifier.Enabled = true;
            btnEnregistrer.Enabled = false;
        }

        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            frmAjoutContact formulaireAjouterContact = new frmAjoutContact();
            formulaireAjouterContact.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            btnEnregistrer.Enabled = true;
            txtRaisonSociale.Enabled = true;
            txtNomContact.Enabled = true;
            txtAdresse.Enabled = true;
            txtTelephoneContact.Enabled = true;
            txtCommentaires.Enabled = true;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
           
        }
    }
}
