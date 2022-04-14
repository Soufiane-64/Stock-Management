using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Stock.PL
{
    public partial class FRM_Connexion : Form
    {
        private dbStockContext db;
        private Form frmmenu;
        //class connexion
        BL.CLS_Connexion C = new BL.CLS_Connexion();
        public FRM_Connexion( Form Menu)
        {
            this.frmmenu = Menu;
            InitializeComponent();
            // initialize la base de donnée
            db = new dbStockContext();
        }

        //Verifier les champs obligatoire
        string testObligatoire()
        {
            if (textBox_nom.Text == "" || textBox_nom.Text == "Nom d'utilisateur")
            {
                return "Entrer votre Nom";
            }
            if (textBox_motdepass.Text == "" || textBox_motdepass.Text == "Mot de Passe")
            {
                return "Entrer votre Mot de Passe";
            }
            //Dans le cas ou l'utilisateur a remplis tout les champs
            return null;
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            //Quitter le form
            this.Close();
        }

        private void textBox_nom_Enter(object sender, EventArgs e)
        {
            //Pour vider Le TextBox
            if (textBox_nom.Text == "Nom d'utilisateur")
            {
                textBox_nom.Text = "";
                textBox_nom.ForeColor = Color.White;
            }
        }

        private void textBox_motdepass_Enter(object sender, EventArgs e)
        {
            //Pour vider Le TextBox
            if (textBox_motdepass.Text == "Mot de Passe")
            {
                textBox_motdepass.Text = "";
                textBox_motdepass.UseSystemPasswordChar = false;
                textBox_motdepass.PasswordChar = '*';
                textBox_nom.ForeColor = Color.White;
            }
        }

        private void textBox_nom_Leave(object sender, EventArgs e)
        {
            if (textBox_nom.Text == "")
            {
                textBox_nom.Text = "Nom d'utilisateur";
                textBox_nom.ForeColor = Color.Silver;
            }
        }

        private void textBox_motdepass_Leave(object sender, EventArgs e)
        {
            if (textBox_motdepass.Text == "")
            {
                textBox_motdepass.Text = "Mot de Passe";
                textBox_motdepass.UseSystemPasswordChar = true;
                textBox_nom.ForeColor = Color.Silver;
            }
        }

        private void FRM_Connexion_Load(object sender, EventArgs e)
        {

        }

        private void button_connexion_Click(object sender, EventArgs e)
        {
            if (testObligatoire() == null)
            {
                if (C.ConnexionValide(db, textBox_nom.Text, textBox_motdepass.Text) == true) // Utilisateur Existe
                {
                    MessageBox.Show("Connexion Réussie !", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frmmenu as FRM_Menu).ActiverFormulaire();
                    this.Close(); // Quitter Formulaire Connexion
                    
                }
                else // flse n'existe pas
                {
                    MessageBox.Show("Connexion Echouée !", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(testObligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    


