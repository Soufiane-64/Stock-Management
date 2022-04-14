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
using Microsoft.Reporting.WinForms;
using Microsoft.Office.Interop.Excel; 

namespace Gestion_De_Stock.PL
{
    public partial class USER_Liste_Produit : UserControl
    {
        private static USER_Liste_Produit UserProduit;
        private dbStockContext db;
        // Creer un instance pour le UserControle 
        public static USER_Liste_Produit Instance
        {
            get
            {
                if (UserProduit == null)
                {
                    UserProduit = new USER_Liste_Produit();
                }
                return UserProduit;
            }

        }
        public USER_Liste_Produit()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        // Actualiser dataGridProduit 
        public void actualiserDGV()
        {
            db = new dbStockContext();
            dataGridProduit.Rows.Clear();
            // Pour afficher le nom de categorie a partir de ID_categorie
            Categorie Cat = new Categorie();
            foreach(var lis in db.Produits)
            {
                Cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == lis.ID_CATEGORIE);// si le idcategorie dans produit = idcategorie dans categorie 
                if(Cat != null) //Si  Existe
                {
                    dataGridProduit.Rows.Add(false, lis.ID_Produit, lis.Nom_Produit, lis.Quantite_Produit, lis.Prix_Produit, Cat.Nom_Categorie);//Cat.Nom_Categorie pour afficher le nom de categorie
                }
            }
            // Colorer stock vide en rouge

            for(int i = 0; i<dataGridProduit.Rows.Count;i++)
            {
                if((int)dataGridProduit.Rows[i].Cells[3].Value == 0) // si le stock est vide
                {
                    dataGridProduit.Rows[i].Cells[3].Style.BackColor = Color.Red; //colorer en rouge
                }else
                {
                    dataGridProduit.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;//colorer en vert
                }
            }

        }

        public string selectverif()
        {
            int nombreligneselect = 0;
            for (int i = 0; i < dataGridProduit.Rows.Count; i++)
            {
                if ((bool)dataGridProduit.Rows[i].Cells[0].Value == true) // si la ligne est selectionnée
                {
                    nombreligneselect++; //nombre de lignes va augmanter avec 1
                }
            }
            if (nombreligneselect == 0)
            {
                return "Séléctionner un produit";
            }
            if (nombreligneselect > 1)
            {
                return "Séléctionner seulement un seul produit ";
            }
            return null;
        }
        private void USER_Liste_Produit_Load(object sender, EventArgs e)
        {
            actualiserDGV();
        }

        private void textBox_rechercher_Enter(object sender, EventArgs e)
        {
            if (textBox_recherche.Text == "Rechercher")
            {
                textBox_recherche.Text = "";
                textBox_recherche.ForeColor = Color.Black;
            }
        }

        private void button_ajouterProduit_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Produit frmproduit = new PL.FRM_Ajouter_Modifier_Produit(this);
            frmproduit.ShowDialog();
        }

        private void button_modifierProduit_Click(object sender, EventArgs e)
        {
            Produit pr = new Produit();
            if(selectverif() != null)
            {
                MessageBox.Show(selectverif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PL.FRM_Ajouter_Modifier_Produit frmproduit = new PL.FRM_Ajouter_Modifier_Produit(this);
                frmproduit.lblTitre.Text = "Modifier Produit";
                frmproduit.button_actualiser.Visible = false;
                for (int i = 0; i < dataGridProduit.Rows.Count; i++)//verifier les lignes selectionées
                {
                    if ((bool)dataGridProduit.Rows[i].Cells[0].Value == true)
                    {
                        int MyIdSelect = (int)dataGridProduit.Rows[i].Cells[1].Value; // MyIdSelect est le ID de l'élément séléctionné
                        pr = db.Produits.SingleOrDefault(s => s.ID_Produit == MyIdSelect);// verifier si le id_produit = id selectionné dans datagrid view
                        if (pr != null) // if existe
                        {
                            frmproduit.idProduit = (int)dataGridProduit.Rows[i].Cells[1].Value;
                            frmproduit.textBox_nomproduit.Text = dataGridProduit.Rows[i].Cells[2].Value.ToString();
                            frmproduit.textBox_quantite.Text = dataGridProduit.Rows[i].Cells[3].Value.ToString();
                            frmproduit.textBox_prix.Text = dataGridProduit.Rows[i].Cells[4].Value.ToString();
                            frmproduit.comboBox_categorie.Text = dataGridProduit.Rows[i].Cells[5].Value.ToString();
                            //Afficher l'image de produit qu'on veut modifier
                            MemoryStream ms = new MemoryStream(pr.Image_Produit); // pour convertit l'image de produit et l afficher dans le pic box
                            frmproduit.pictureBox1.Image = Image.FromStream(ms);
                        }


                    }
                }
                
                frmproduit.ShowDialog();

            }
        }

        private void button_afficherPhoto_Click(object sender, EventArgs e)
        {
            Produit pr = new Produit();
            if(selectverif() != null)
            {
                MessageBox.Show(selectverif(), "Séléctionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i=0; i<dataGridProduit.Rows.Count ; i++)//verifier les lignes selectionées
                {
                    if((bool)dataGridProduit.Rows[i].Cells[0].Value == true)
                    {
                        int MyIdSelect = (int)dataGridProduit.Rows[i].Cells[1].Value; // MyIdSelect est le ID de l'élément séléctionné
                        pr = db.Produits.SingleOrDefault(s=>s.ID_Produit == MyIdSelect);// verifier si le id_produit = id selectionné dans datagrid view
                        if(pr != null) // existe
                        {
                            FRM_Photo_Produit frmphoto = new FRM_Photo_Produit();
                            // declarer system.IO
                            MemoryStream ms = new MemoryStream(pr.Image_Produit); // pour convertit l'image de produit et l afficher dans le pic box
                            frmphoto.produit_Image.Image = Image.FromStream(ms);
                            frmphoto.Produit_Nom.Text = dataGridProduit.Rows[i].Cells[2].Value.ToString();
                            // Afficher le formulaire
                            frmphoto.ShowDialog();


                        }
                    }
                }
            }
        }

        private void button_supprimerProduit_Click(object sender, EventArgs e)
        {
            BL.CLS_Produit clproduit = new BL.CLS_Produit();
            //pour supprimer tout les clients séléctionnés
            int select = 0;
            for (int i = 0; i < dataGridProduit.Rows.Count; i++)
            {
                if ((bool)dataGridProduit.Rows[i].Cells[0].Value == true)
                {
                    select++; //nombre de lignes selectionnées
                }
            }
            if (select == 0)
            {
                MessageBox.Show("Aucun Produit selectonnée", "suppressoin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer ce Produit ?", "suppressoin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    //pour supprimer tout les clients selectionnés
                    for (int i = 0; i < dataGridProduit.Rows.Count; i++)
                    {
                        if ((bool)dataGridProduit.Rows[i].Cells[0].Value == true)
                        {
                            clproduit.Supprimer_Produit(int.Parse(dataGridProduit.Rows[i].Cells[1].Value.ToString()));// ID Client
                        }
                    }
                    // Actualiser datagridview
                    actualiserDGV();
                    MessageBox.Show("Produit supprimé avec succées", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Suppression est annulée", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBox_rechercher_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listrecherche = db.Produits.ToList(); //listercherche = liste des clients
            //Recherche  seulement par  Nom de Produit 
            listrecherche = listrecherche.Where(s => s.Nom_Produit.IndexOf(textBox_recherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            // StringComparison.CurrentCultureIgnoreCase : soit j ecrit en minuscule ou majescule il n' ya pas de differnce
            // -1 : exsite dans la base de donnée

            dataGridProduit.Rows.Clear();// pour vider data grid view
            //ajouter listerecherche dans datagridview
            Categorie cat = new Categorie();
            foreach (var l in listrecherche)
            {
                cat = db.Categories.SingleOrDefault(s=>s.ID_CATEGORIE == l.ID_CATEGORIE);// pour afficher nom de categorie
                dataGridProduit.Rows.Add(false, l.ID_Produit, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit, cat.Nom_Categorie);
            }
        }

        private void textBox_recherche_Leave(object sender, EventArgs e)
        {

        }

        private void button_ImpProdSel_Click(object sender, EventArgs e)
        {

        }

        private void button_impTout_Click(object sender, EventArgs e)
        {
           
        }

        private void button_excel_Click(object sender, EventArgs e)
        {
            db = new dbStockContext();
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx",ValidateNames=true})//filter seuelement fichier Excel
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    // Ajouter les lignes de fichier Excel
                    ws.Cells[1, 1] = "ID Produit";
                    ws.Cells[1, 2] = "Nom Produit";
                    ws.Cells[1, 3] = "Quantité";
                    ws.Cells[1, 4] = "Prix";
                    //Ajouter liste de produit de base de donnée dans fichier excel 
                    var listeproduit = db.Produits.ToList();
                    int i = 2;
                    foreach (var l in listeproduit)
                    {
                        ws.Cells[i, 1] = l.ID_Produit;
                        ws.Cells[i, 2] = l.Nom_Produit;
                        ws.Cells[i, 3] = l.Quantite_Produit;
                        ws.Cells[i, 4] = l.Prix_Produit;
                        i++;
                    }
                    // changer style de fichier-------------------------------

                    ws.Range["A1:D1"].Interior.Color = Color.Teal; // Background color
                    ws.Range["A1:D1"].Font.Color = Color.White; // text color
                    ws.Range["A1:D1"].Font.Size = 15; // text size
                    //centrer le text
                    ws.Range["A:D"].HorizontalAlignment = XlHAlign.xlHAlignCenter; // text size
                    ws.Range["A1:D1"].ColumnWidth= 16; // text size

                    //--------------------------------------------------------
                    wb.SaveAs(sfd.FileName);//savgarder dans le fichier excel
                    app.Quit();
                    MessageBox.Show("Sauvgarder avec succés dans excel", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }


            }
        }

        private void button_actualiser_Click(object sender, EventArgs e)
        {
            //pour actualiser datagridview
            actualiserDGV();
        }
    }  
}
