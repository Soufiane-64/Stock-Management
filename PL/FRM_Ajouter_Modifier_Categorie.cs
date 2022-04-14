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
    public partial class FRM_Ajouter_Modifier_Categorie : Form
    {
        private UserControl usercat;
        public FRM_Ajouter_Modifier_Categorie(UserControl usercategorie)
        {
            InitializeComponent();
            this.usercat = usercategorie;
        }

        private void textBox_nomcat_Enter(object sender, EventArgs e)
        {
            if (textBox_nomcat.Text == "Nom de Catégorie")
            {
                textBox_nomcat.Text = "";
                textBox_nomcat.ForeColor = Color.White;
            }
        }

        private void textBox_nomcat_Leave(object sender, EventArgs e)
        {
            if (textBox_nomcat.Text == "")
            {
                textBox_nomcat.Text = "Nom de Catégorie";
                textBox_nomcat.ForeColor = Color.Silver;
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        public int idcategorie;

        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            BL.CLS_Categorie clcat = new BL.CLS_Categorie();
            if(lblTitre_cat.Text == "Ajouter Catégorie")
            {
                if(textBox_nomcat.Text == "Nom de Catégorie" || textBox_nomcat.Text == "")
                {
                    MessageBox.Show("Entrer le nom de catégorie que vous voulez ajouter", "Ajouter Catégorie", MessageBoxButtons.OK, MessageBoxIcon.Error);// si le textbox est vide
                }
                else
                {
                    if (clcat.Ajouter_Categorie(textBox_nomcat.Text) == false)
                    {
                        MessageBox.Show("La catégorie que vous voulez ajouter existe déja !", "Ajouter Catégorie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Catégorie ajoutée avex succes !", "Ajouter Catégorie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                         (usercat as USER_Liste_Categorie).remplirdatagrid();
                    }

                }
            }
            if(lblTitre_cat.Text == "Modifier Catégorie")
            {
                
                DialogResult dr = MessageBox.Show("Voulez-vous modifier cette catégorie ?","Modifier catégorie",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clcat.Modifier_Categorie(idcategorie, textBox_nomcat.Text);
                    MessageBox.Show("Catégorie Modifier avec succes !", "Modifier catégorie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //Actualiser datagridview
                    (usercat as USER_Liste_Categorie).remplirdatagrid();
                }
                else
                {
                    MessageBox.Show("Modification annulée !", "Modifier catégorie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
                
            
        }

        private void FRM_Ajouter_Modifier_Categorie_Load(object sender, EventArgs e)
        {
            
        }
    }
}
