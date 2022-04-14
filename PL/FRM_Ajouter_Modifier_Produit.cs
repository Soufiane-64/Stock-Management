using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gestion_De_Stock.PL
{
    public partial class FRM_Ajouter_Modifier_Produit : Form
    {
        private dbStockContext db;
        private UserControl userProduit;
        public FRM_Ajouter_Modifier_Produit(UserControl User)
        {
            InitializeComponent();
            db = new dbStockContext();
            this.userProduit = User;
            // Afficher les catregories dans le combobox_categorie
            comboBox_categorie.DataSource = db.Categories.ToList();
            // et pour afficher seulement la nom de categorie 
            comboBox_categorie.DisplayMember = "Nom_Categorie";
            comboBox_categorie.ValueMember = "ID_Categorie";
        }

        public string testeObligatoire()
        {
            if (textBox_nomproduit.Text == "Nom Produit" || textBox_nomproduit.Text == "")
            {
                return "Entrer Nom du Produit ! ";
            }
            if (textBox_quantite.Text == "Quantité" || textBox_quantite.Text == "")
            {
                return "Entrer la Quantité ! ";
            }
            if (textBox_prix.Text == "Prix" || textBox_prix.Text == "" )
            {
                return "Entrer le prix ! ";
            }
            if (pictureBox1.Image == null)
            {
                return "Entrer l'image du produit ! ";
            }
            if (comboBox_categorie.Text == "")
            {
                return "choisir une catégorie !";
            }


           return null;
        }

        private void textBox_nomproduit_Enter(object sender, EventArgs e)
        {
            if (textBox_nomproduit.Text == "Nom Produit")
            {
                textBox_nomproduit.Text = "";
                textBox_nomproduit.ForeColor = Color.White;
            }
        }

        private void textBox_nomproduit_Leave(object sender, EventArgs e)
        {
            if (textBox_nomproduit.Text == "")
            {
                textBox_nomproduit.Text = "Nom Produit";
                textBox_nomproduit.ForeColor = Color.Silver;
            }
        }

        private void textBox_quantite_Enter(object sender, EventArgs e)
        {
            if (textBox_quantite.Text == "Quantité")
            {
                textBox_quantite.Text = "";
                textBox_quantite.ForeColor = Color.White;
            }
        }

        private void textBox_quantite_Leave(object sender, EventArgs e)
        {
            if (textBox_quantite.Text == "")
            {
                textBox_quantite.Text = "Quantité";
                textBox_quantite.ForeColor = Color.Silver;
            }
        }

        private void textBox_prix_Enter(object sender, EventArgs e)
        {
            if (textBox_prix.Text == "Prix")
            {
                textBox_prix.Text = "";
                textBox_prix.ForeColor = Color.White;
            }
        }

        private void textBox_prix_Leave(object sender, EventArgs e)
        {
            if (textBox_prix.Text == "")
            {
                textBox_prix.Text = "Prix";
                textBox_prix.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_Ajouter_Modifier_Produit_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Afficher fichier Image
            OpenFileDialog op = new OpenFileDialog();
            op.FileName = "|*.BMP;*.PNG;*.GIF;*.JPG"; // pour Afficher que les images
            if(op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
            }
        }

        private void button_actualiser_Click(object sender, EventArgs e)
        {
            // Vider le formualiare
            textBox_nomproduit.Text = "Nom Produit"; textBox_nomproduit.ForeColor = Color.Silver;
            textBox_quantite.Text = "Quantité"; textBox_quantite.ForeColor = Color.Silver;
            textBox_prix.Text = "Prix"; textBox_prix.ForeColor = Color.Silver;
            comboBox_categorie.Text = "";
            pictureBox1.Image = null;

        }

        private void textBox_quantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void FRM_Ajouter_Modifier_Produit_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_prix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        public int  idProduit;// le id qu'on va donner a la fonction modifier pour chercher le produit qu'on veut modifier
        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            if(testeObligatoire() != null)
            {
                MessageBox.Show(testeObligatoire(),"Obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else
            {
                if(lblTitre.Text =="Ajouter Produit")
                {
                    BL.CLS_Produit clproduit = new BL.CLS_Produit();
                    // convertir l'image au format byte
                    // ajouter system.IO
                    MemoryStream MR = new MemoryStream();
                    pictureBox1.Image.Save(MR, pictureBox1.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();//Convertir image en format  byte[]
                    if (clproduit.Ajouter_Produit( textBox_nomproduit.Text , int.Parse(textBox_quantite.Text) , textBox_prix.Text , byteimageP ,Convert.ToInt32(comboBox_categorie.SelectedValue)) == true)
                    {
                        MessageBox.Show("Produit ajouté avec succé ! ","Ajouter",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        (userProduit as USER_Liste_Produit).actualiserDGV();
                    }else
                    {
                        MessageBox.Show("Produit existe déja ! ", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else // Modification
                {
                    MemoryStream MR = new MemoryStream();
                    pictureBox1.Image.Save(MR, pictureBox1.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();//Convertir image en format  byte[]
                    BL.CLS_Produit clsProduit = new BL.CLS_Produit();
                    DialogResult RS = MessageBox.Show("Voulez-vous vraimenet modifier ce produit ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (RS == DialogResult.Yes)
                    {
                        clsProduit.Modifier_Produit(idProduit, textBox_nomproduit.Text, int.Parse(textBox_quantite.Text), textBox_prix.Text, byteimageP, Convert.ToInt32(comboBox_categorie.SelectedValue));
                        MessageBox.Show("Produit Modifié avec succés !", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //Actualiser datagridview
                        (userProduit as USER_Liste_Produit).actualiserDGV();
                        Close();// pour quitter le formulaire apres la modification de produit

                    }else
                    {
                        MessageBox.Show("Modification annulé !", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                }
            }
        }
    }
}
