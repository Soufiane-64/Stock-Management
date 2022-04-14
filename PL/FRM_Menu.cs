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
    public partial class FRM_Menu : Form
    {
        public FRM_Menu() 
        {
            InitializeComponent();
            panel1.Size = new Size(228, 582);
            pnlparamettre.Visible = false;
        }

        //Désactiver Formulaire
        public void DesactiverFormulaire()
        {
            button_client.Enabled = false;
            button_Produit.Enabled = false;
            button_Categorie.Enabled = false;
            button_Commande.Enabled = false;
            button_deconnecter.Enabled = false;
            // Activer button Connecter
            button_connecter.Enabled = true;

        }
        //Activer Formulaire
        public void ActiverFormulaire()
        {
            button_client.Enabled = true;
            button_Produit.Enabled = true;
            button_Categorie.Enabled = true;
            button_Commande.Enabled = true;
            button_deconnecter.Enabled = true;
            // Desactiver button Connecter
            button_connecter.Enabled = false;
            pnlparamettre.Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(panel1.Width == 228)
            {
                panel1.Size = new Size(81, 582);
            }
            else
            {
                panel1.Size = new Size(228, 582);
            }
        }

        private void button_Produit_Click(object sender, EventArgs e)
        {
            pnlBtn.Top = button_Produit.Top;
            if (!panel_affiche.Controls.Contains(USER_Liste_Produit.Instance))
            {
                panel_affiche.Controls.Add(USER_Liste_Produit.Instance);
                USER_Liste_Produit.Instance.Dock = DockStyle.Fill;
                USER_Liste_Produit.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Produit.Instance.BringToFront();
            }
        }

        private void button_Categorie_Click(object sender, EventArgs e)
        {
            pnlBtn.Top = button_Categorie.Top;
            if (!panel_affiche.Controls.Contains(USER_Liste_Categorie.Instance))
            {
                panel_affiche.Controls.Add(USER_Liste_Categorie.Instance);
                USER_Liste_Categorie.Instance.Dock = DockStyle.Fill;
                USER_Liste_Categorie.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Categorie.Instance.BringToFront();
            }

        }

        private void button_Commande_Click(object sender, EventArgs e)
        {


        }

        private void button_Utilisateur_Click(object sender, EventArgs e)
        {

        }

        private void button_client_Click(object sender, EventArgs e)
        {
            pnlBtn.Top = button_client.Top;
            if(!panel_affiche.Controls.Contains(USER_List_Client.Instance))
            {
                panel_affiche.Controls.Add(USER_List_Client.Instance);
                USER_List_Client.Instance.Dock = DockStyle.Fill;
                USER_List_Client.Instance.BringToFront();
            }else
            {
                USER_List_Client.Instance.BringToFront();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_paramettre_Click(object sender, EventArgs e)
        {
            pnlparamettre.Size = new Size(224, 114);
            pnlparamettre.Visible = !pnlparamettre.Visible;
        }

        private void button_connecter_Click(object sender, EventArgs e)
        {
            FRM_Connexion frmcnx = new FRM_Connexion(this); //  this : ce form
            frmcnx.ShowDialog();
        }

        private void FRM_Menu_Load(object sender, EventArgs e)
        {
            DesactiverFormulaire();
        }

        private void button_deconnecter_Click(object sender, EventArgs e)
        {
            DesactiverFormulaire();
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_affiche_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Commande_Click_1(object sender, EventArgs e)
        {

            pnlBtn.Top = button_Commande.Top;
            if (!panel_affiche.Controls.Contains(User_Liste_commande.Instance))
            {
                panel_affiche.Controls.Add(User_Liste_commande.Instance);
                User_Liste_commande.Instance.Dock = DockStyle.Fill;
                User_Liste_commande.Instance.BringToFront();
            }
            else
            {
                User_Liste_commande.Instance.BringToFront();
            }
        }
    }
 }

