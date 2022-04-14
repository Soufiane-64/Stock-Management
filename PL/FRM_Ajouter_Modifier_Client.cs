using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Gestion_De_Stock.PL
{
    public partial class FRM_Ajouter_Modifier_Client : Form
    {
        private UserControl usclinet;
        public FRM_Ajouter_Modifier_Client(UserControl userC)
        {
            InitializeComponent();
            this.usclinet = userC;
        }

        // les champs Obligatoire
        string testeObligatoire()
        {
           if(textBox_nomcl.Text == "" || textBox_nomcl.Text == "Nom de Client")
            {
                return "Entrer Nom de Client ! ";
            }
            if (textBox_prnmcl.Text == "" || textBox_prnmcl.Text == "Prenom de Client")
            {
                return "Entrer Prenom de Client ! ";
            }
            if (textBox_addcl.Text == "" || textBox_addcl.Text == "Adresse de Client")
            {
                return "Entrer Adresse de Client ! ";
            }
            if (textBox_payscl.Text == "" || textBox_payscl.Text == "Pays de Client")
            {
                return "Entrer Pays de Client ! ";
            }
            if (textBox_telecl.Text == "" || textBox_telecl.Text == "Telephone de Client")
            {
                return "Entrer Telephone de Client ! ";
            }
            if (textBox_emailcl.Text == "" || textBox_emailcl.Text == "Email de Client")
            {
                return "Entrer Email de Client ! ";
            }
            if (textBox_villecl.Text == "" || textBox_villecl.Text == "Ville de Client")
            {
                return "Entrer Ville de Client ! ";
            }
            //verification d'Eamil
            if (textBox_emailcl.Text != "" && textBox_emailcl.Text != "Ville de Client")
            {
                try
                {
                    new MailAddress(textBox_emailcl.Text); //Pour verifier si l'Email est valide ou Non

                }catch(Exception)
                {
                    return "Email Invalide ! ";
                }
            }

            return null;
        }
        private void textBox_nomcl_Enter(object sender, EventArgs e)
        {
            //Pour vider Le TextBox
            if (textBox_nomcl.Text == "Nom de Client")
            {
                textBox_nomcl.Text = "";
                textBox_nomcl.ForeColor = Color.White;
            }
        }

        private void textBox_prnmcl_Enter(object sender, EventArgs e)
        {
            if (textBox_prnmcl.Text == "Prenom de Client")
            {
                textBox_prnmcl.Text = "";
                textBox_prnmcl.ForeColor = Color.White;
            }

        }

        private void textBox_addcl_Enter(object sender, EventArgs e)
        {
            if (textBox_addcl.Text == "Adresse de Client")
            {
                textBox_addcl.Text = "";
                textBox_addcl.ForeColor = Color.White;
            }

        }

        private void textBox_payscl_Enter(object sender, EventArgs e)
        {
            if (textBox_payscl.Text == "Pays de Client")
            {
                textBox_payscl.Text = "";
                textBox_payscl.ForeColor = Color.White;
            }

        }

        private void textBox_telecl_Enter(object sender, EventArgs e)
        {
            if (textBox_telecl.Text == "Telephone de Client")
            {
                textBox_telecl.Text = "";
                textBox_telecl.ForeColor = Color.White;
            }

        }

        private void textBox_emailcl_Enter(object sender, EventArgs e)
        {
            if (textBox_emailcl.Text == "Email de Client")
            {
                textBox_emailcl.Text = "";
                textBox_emailcl.ForeColor = Color.White;
            }

        }

        private void textBox_villecl_Enter(object sender, EventArgs e)
        {
            if (textBox_villecl.Text == "Ville de Client")
            {
                textBox_villecl.Text = "";
                textBox_villecl.ForeColor = Color.White;
            }
        }

        private void textBox_nomcl_Leave(object sender, EventArgs e)
        {

            if (textBox_nomcl.Text == "")
            {
                textBox_nomcl.Text = "Nom de Client";
                textBox_nomcl.ForeColor = Color.Silver;
            }
        }

        private void textBox_prnmcl_Leave(object sender, EventArgs e)
        {
            if (textBox_prnmcl.Text == "")
            {
                textBox_prnmcl.Text = "Prenom de Client";
                textBox_prnmcl.ForeColor = Color.Silver;
            }
        }

        private void textBox_addcl_Leave(object sender, EventArgs e)
        {
            if (textBox_addcl.Text == "")
            {
                textBox_addcl.Text = "Adresse de Client";
                textBox_addcl.ForeColor = Color.Silver;
            }
        }

        private void textBox_payscl_Leave(object sender, EventArgs e)
        {
            if (textBox_payscl.Text == "")
            {
                textBox_payscl.Text = "Pays de Client";
                textBox_payscl.ForeColor = Color.Silver;
            }
        }

        private void textBox_telecl_Leave(object sender, EventArgs e)
        {
            if (textBox_telecl.Text == "")
            {
                textBox_telecl.Text = "Telephone de Client";
                textBox_telecl.ForeColor = Color.Silver;
            }
        }

        private void textBox_emailcl_Leave(object sender, EventArgs e)
        {
            if (textBox_emailcl.Text == "")
            {
                textBox_emailcl.Text = "Email de Client";
                textBox_emailcl.ForeColor = Color.Silver;
            }
        }

        private void textBox_villecl_Leave(object sender, EventArgs e)
        {
            if (textBox_villecl.Text == "")
            {
                textBox_villecl.Text = "Ville de Client";
                textBox_villecl.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();//fermer le form
            
        }

        private void textBox_telecl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void FRM_Ajouter_Modifier_Client_Load(object sender, EventArgs e)
        {

        }
        public int IDselect;
        private void button3_Click(object sender, EventArgs e)
        {
            if(testeObligatoire() != null)
            {
                MessageBox.Show(testeObligatoire(),"Obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else
             if(lblTitre.Text == "Ajouter Client")
            {
                BL.CLS_Client clclient = new BL.CLS_Client();
                if(clclient.Ajouter_Client(textBox_nomcl.Text,textBox_prnmcl.Text,textBox_addcl.Text,textBox_telecl.Text, textBox_emailcl.Text,textBox_payscl.Text,textBox_villecl.Text)==true)
                {
                    MessageBox.Show("Client ajouté avec succès ! ", "Ajouté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    (usclinet as USER_List_Client).actualiserdatgrid();
                }
                else
                {
                    MessageBox.Show("Client est déja éxiste ! ", "Ajouté", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // si lbltitre.Text == Modifier Client
            {
                BL.CLS_Client clclient = new BL.CLS_Client();
                DialogResult R = MessageBox.Show("Voulez-vous vraiment modifier ce client ?","Modification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(R == DialogResult.Yes)
                {
                    clclient.modifier_Client(IDselect, textBox_nomcl.Text, textBox_prnmcl.Text, textBox_addcl.Text, textBox_telecl.Text, textBox_emailcl.Text, textBox_payscl.Text, textBox_villecl.Text);
                    //pour actualiser datagridview
                    (usclinet as USER_List_Client).actualiserdatgrid();
                    MessageBox.Show("Client Modifié avec succée ! ", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 

                }
                else
                {
                    MessageBox.Show("Modification est annulée ! ", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                }
    
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_nomcl.Text = "Nom de Client"; textBox_nomcl.ForeColor = Color.Silver;

            textBox_prnmcl.Text = "Prenom de Client"; textBox_prnmcl.ForeColor = Color.Silver;

            textBox_addcl.Text = "Adresse de Client"; textBox_addcl.ForeColor = Color.Silver;

            textBox_telecl.Text = "Telephone de Client"; textBox_telecl.ForeColor = Color.Silver;

            textBox_emailcl.Text = "Email de Client"; textBox_emailcl.ForeColor = Color.Silver;

            textBox_payscl.Text = "Pays de Client"; textBox_payscl.ForeColor = Color.Silver;

            textBox_villecl.Text = "Ville de Client"; textBox_villecl.ForeColor = Color.Silver;
        }

        private void textBox_telecl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
