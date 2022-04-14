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
    public partial class FRM_Produit_Commande : Form
    {
        public Form frmdetail;
        public FRM_Produit_Commande(Form frm)
        {
            InitializeComponent();
            frmdetail = frm;
            
        }

        private void textBox_quantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            //N'accepte que les nombres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void textBox_remise_KeyPress(object sender, KeyPressEventArgs e)
        {
            //N'accepte que les nombres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void groupBox_vendreproduit_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_quantite_TextChanged(object sender, EventArgs e)
        {
            if (textBox_quantite.Text !="")
            {
                int quantite = int.Parse(textBox_quantite.Text);
                float prix = float.Parse(label_prix.Text);
                if (int.Parse(textBox_quantite.Text) > int.Parse(label_stock.Text))
                {
                    MessageBox.Show("I l y a seulement "+int.Parse(label_stock.Text)+" piéces dans le stock","Stock",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    //Vider textBox Quantite 
                    textBox_quantite.Text = "";
                    textBox_total.Text = label_prix.Text;

                }
                else
                {
                    //Calcule Total
                    textBox_total.Text = (quantite * prix).ToString("0.00");
                }

            }
            else
            {
                textBox_total.Text = label_prix.Text;
            }


        }

        private void textBox_remise_TextChanged(object sender, EventArgs e)
        {
            if (textBox_remise.Text != "")
            {
                int quantite;
                if (textBox_quantite.Text != "")
                {
                    quantite = int.Parse(textBox_quantite.Text);

                }
                else
                {
                    quantite = 1;
                }
                float prix = float.Parse(label_prix.Text);
                float total = quantite * prix;
                int remise = int.Parse(textBox_remise.Text);
                textBox_total.Text = (total - (total * remise / 100)).ToString("0.00");


            }
            else
            {
                int quantite;
                if (textBox_quantite.Text != "")
                {
                    quantite = int.Parse(textBox_quantite.Text);

                }
                else
                {
                    quantite = 1;
                } 
                float prix = float.Parse(label_prix.Text);
                textBox_total.Text = (quantite * prix).ToString("0.00");
            }
        }

        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            //si le text box quantite et le textbox quantite sont vides
            int quant, re;
            if(textBox_quantite.Text != "")
            {
                quant = int.Parse(textBox_quantite.Text);
            }
            else
            {
                quant = 1;
            }

            if (textBox_remise.Text != "")
            {
                re = int.Parse(textBox_remise.Text);
            }
            else
            {
                re = 0;
            }
            //Ajouter produit dans Commande
            BL.D_Commande DETAIL = new BL.D_Commande
                {

                    Id = int.Parse(label__id.Text),
                    Nom = label_nom.Text,
                    Quantite = quant,
                    Prix = label_prix.Text,
                    Remise = re.ToString(),
                    Total = textBox_total.Text,
                };

            // Ajouter dans la liste
            if (groupBox_vendreproduit.Text == "Vendre Produit")
            {
                if (BL.D_Commande.listedetail.SingleOrDefault(s => s.Id == DETAIL.Id) != null)
                {
                    MessageBox.Show("produit existe déja dans la commande", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    BL.D_Commande.listedetail.Add(DETAIL);
                }

            }
            else
            { //Modifier
                DialogResult dr = MessageBox.Show("Vouler-vous vraiment modifier ?","Modification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    // trouver index de produit Modifier
                    int index = BL.D_Commande.listedetail.FindIndex(s => s.Id == int.Parse(label__id.Text));
                    BL.D_Commande.listedetail[index] = DETAIL;
                    MessageBox.Show("modifié avec succé", "modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                }
                else
                {
                    MessageBox.Show("Modification Annulé !", "modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


            // Actualiser datagrid view
            (frmdetail as FRM_Detail_Commande).Actualiser_detail_commande();
        }

        private void FRM_Produit_Commande_Load(object sender, EventArgs e)
        {

        }

        private void groupBox_detailproduit_Enter(object sender, EventArgs e)
        {

        }
    }
}
