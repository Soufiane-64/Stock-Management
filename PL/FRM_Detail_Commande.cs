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
    public partial class FRM_Detail_Commande : Form
    {
        private UserControl userCommande;
        private dbStockContext db;

        public FRM_Detail_Commande(UserControl user) 
        {
            InitializeComponent();
            db = new dbStockContext();
            userCommande = user;
        }
        // Remplir datagridview  de Commande par liste 
        public void Actualiser_detail_commande()
        {
            // calculer total tth,tva,total ttc
            float totalht = 0, TVA = 0 , totalttc = 0;
            if(textBox_TVA.Text != "")
            {
                TVA = float.Parse(textBox_TVA.Text);
            }
            dataGridcommande.Rows.Clear();
            foreach(var l in BL.D_Commande.listedetail)
            {
                dataGridcommande.Rows.Add(l.Id, l.Nom, l.Quantite, l.Prix, l.Remise, l.Total);
                totalht = totalht + float.Parse(l.Total);
            }
            textBox_totaltth.Text = totalht.ToString();
            // Calculer total ttc
            totalttc = (totalht + (totalht * TVA / 100));
            // Afficher ToTal ttc dans le textbox 
            textBox_totalTTC.Text = totalttc.ToString();



        }

        // Function Remplirdatagridview de produit
        public void remplirdatagrid()
        {
            db = new dbStockContext();
            foreach (var l in db.Produits)
            {
                dataGridProduit.Rows.Add(l.ID_Produit, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit);
            }
            for (int i = 0; i < dataGridProduit.Rows.Count; i++)
            {
                if ((int)dataGridProduit.Rows[i].Cells[2].Value == 0) // si le stock est vide
                {
                    dataGridProduit.Rows[i].Cells[2].Style.BackColor = Color.Red; //colorer en rouge
                }
                else
                {
                    dataGridProduit.Rows[i].Cells[2].Style.BackColor = Color.LightGreen;//colorer en vert
                }
            }
            //Vider ligne selectionnée
            dataGridProduit.ClearSelection();

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {
              
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_emailcl_Enter(object sender, EventArgs e)
        {
            if(textBox_recherche.Text == "Recherche")
            {
                textBox_recherche.Text = "";
                textBox_recherche.ForeColor = Color.White;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            // Vider la liste des produits commandées
            BL.D_Commande.listedetail.Clear();
        }

        private void FRM_Detail_Commande_Load(object sender, EventArgs e)
        {
            remplirdatagrid(); 
        }

        private void textBox_recherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listrecherche = db.Produits.ToList();
 
            listrecherche = listrecherche.Where(s => s.Nom_Produit.IndexOf(textBox_recherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
             dataGridProduit.Rows.Clear();
            foreach (var l in listrecherche)
            {

                dataGridProduit.Rows.Add(l.ID_Produit, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit);
            }
        }

        private void button_client_Click(object sender, EventArgs e)
        {
            PL.Frm_Client_Commande frmc = new Frm_Client_Commande();
            frmc.ShowDialog();
            //Afficher les finformations des Clients
            IDCLIENT = (int) frmc.dataGridClient.CurrentRow.Cells[0].Value;
            textBox_nom.Text = frmc.dataGridClient.CurrentRow.Cells[1].Value.ToString();
            textBox_prenom.Text = frmc.dataGridClient.CurrentRow.Cells[2].Value.ToString();
            textBox_telephone.Text = frmc.dataGridClient.CurrentRow.Cells[4].Value.ToString();
            textBox_email.Text = frmc.dataGridClient.CurrentRow.Cells[5].Value.ToString();
            textBox_ville.Text = frmc.dataGridClient.CurrentRow.Cells[6].Value.ToString();
            textBox_pays.Text = frmc.dataGridClient.CurrentRow.Cells[7].Value.ToString();

        }

        private void dataGridProduit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Produit_Commande frmp = new FRM_Produit_Commande(this);
            // si le stock est vide
            if((int)dataGridProduit.CurrentRow.Cells[2].Value == 0)
            {
                MessageBox.Show("le Stock est vide", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else
            {
                //Afficher les informations de produits
                frmp.label__id.Text = dataGridProduit.CurrentRow.Cells[0].Value.ToString();
                frmp.label_nom.Text = dataGridProduit.CurrentRow.Cells[1].Value.ToString();
                frmp.label_stock.Text = dataGridProduit.CurrentRow.Cells[2].Value.ToString();
                frmp.label_prix.Text = dataGridProduit.CurrentRow.Cells[3].Value.ToString();
                frmp.textBox_total.Text = dataGridProduit.CurrentRow.Cells[3].Value.ToString();

                frmp.ShowDialog();
            }
            
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Produit_Commande frmp = new FRM_Produit_Commande(this);
            Produit pr = new Produit();

            if(dataGridcommande.CurrentRow != null)
            {
                frmp.groupBox_vendreproduit.Text = "Modifier Produit";
                // Afficher les informations de produit  modifier
                frmp.label__id.Text = dataGridcommande.CurrentRow.Cells[0].Value.ToString();
                frmp.label_nom.Text = dataGridcommande.CurrentRow.Cells[1].Value.ToString();
                // importer la valeur de stock disponible
                int ID = int.Parse(dataGridcommande.CurrentRow.Cells[0].Value.ToString());
                pr = db.Produits.SingleOrDefault(s => s.ID_Produit == ID);
                frmp.label_stock.Text = pr.Quantite_Produit.ToString();
                ////////////////////////////////////////////////////////////////////////////
                frmp.label_prix.Text = dataGridcommande.CurrentRow.Cells[3].Value.ToString();
                frmp.textBox_quantite.Text = dataGridcommande.CurrentRow.Cells[2].Value.ToString();
                frmp.textBox_remise.Text = dataGridcommande.CurrentRow.Cells[4].Value.ToString();
                frmp.textBox_total.Text = dataGridcommande.CurrentRow.Cells[5].Value.ToString();


                frmp.ShowDialog();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridcommande.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show("Vouler-vous vraiment spprimer ?", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // Supprimer produit commondé dans la liste
                    
                    int ID1 = int.Parse(dataGridcommande.CurrentRow.Cells[0].Value.ToString());
                    int index = BL.D_Commande.listedetail.FindIndex(s => s.Id == ID1);
                    BL.D_Commande.listedetail.RemoveAt(index);
                   // Actualiser datagridview
                    Actualiser_detail_commande();
                    MessageBox.Show("Supprimé avec succé", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression Annulé !", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox_TVA_TextChanged(object sender, EventArgs e)
        {
            // Calculer le TTC
            Actualiser_detail_commande();
        }
        // ID client 
        public int IDCLIENT; 
        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            BL.CLS_Commande_DetailCommande clscommande = new BL.CLS_Commande_DetailCommande();
            if(dataGridcommande.Rows.Count == 0)//si datagrid est Vide
            {
                MessageBox.Show("Ajouter des produits !", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(textBox_nom.Text == "")
                {
                    MessageBox.Show("Ajouter un client","Client",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    // Enregistrer Commande
                    clscommande.Ajouter_Commande(dateTimePicker1.Value, IDCLIENT, textBox_totaltth.Text, textBox_TVA.Text, textBox_totalTTC.Text);
                    // Enregistrer liste detail commande dans  la base de donnée 
                    foreach(var LD in BL.D_Commande.listedetail)
                    {
                        clscommande.Ajouter_Detail(LD.Id, LD.Nom, LD.Quantite, LD.Prix, LD.Remise, LD.Total);
                    }
                    (userCommande as User_Liste_commande).replirdata();
                    //Vider la liste des Commandes
                    BL.D_Commande.listedetail.Clear();
                    //Quitter Form 
                    Close();
                    MessageBox.Show("Commande Ajoutée avec Succes !", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);



                }
            }
        }
    }
}
