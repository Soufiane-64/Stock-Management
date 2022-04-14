using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Gestion_De_Stock.PL
{
    public partial class USER_Liste_Categorie : UserControl
    {
        private static USER_Liste_Categorie usercategorie;
        private dbStockContext db;
        // creer un instanse pour le usercontrol

        public static USER_Liste_Categorie Instance
        {
            get
            {
                if(usercategorie == null)
                {
                    usercategorie = new USER_Liste_Categorie();
                }
                return usercategorie;
            }
        }

        public USER_Liste_Categorie()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        public void remplirdatagrid()// remplir datagridview de categorie
        {
            db = new dbStockContext();
            dataGridCategorie.Rows.Clear();
            foreach(var cat in db.Categories)
            {
                dataGridCategorie.Rows.Add(false,cat.ID_CATEGORIE,cat.Nom_Categorie);
            }
        }

        public string selectverif()
        {
            int nombreligneselect = 0;
            for (int i = 0; i < dataGridCategorie.Rows.Count; i++)
            {
                if ((bool)dataGridCategorie.Rows[i].Cells[0].Value == true) // si la ligne est selectionnée
                {
                    nombreligneselect++; //nombre de lignes va augmanter avec 1
                }
            }
            if (nombreligneselect == 0)
            {
                return "Séléctionner un categorie";
            }
            if (nombreligneselect > 1)
            {
                return "Séléctionner seulement une seul categorie ";
            }
            return null;
        }

        private void USER_Liste_Categorie_Load(object sender, EventArgs e)
        {
            remplirdatagrid();
        }

        private void textBox_recherche_Enter(object sender, EventArgs e)
        {
            if (textBox_recherche.Text == "Rechercher")
            {
                textBox_recherche.Text = "";
                textBox_recherche.ForeColor = Color.Black;
            }
        }

        private void button_ajouterProduit_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Categorie frmcat = new PL.FRM_Ajouter_Modifier_Categorie(this);
            frmcat.ShowDialog();
        }

        private void dataGridCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Categorie frmcat = new PL.FRM_Ajouter_Modifier_Categorie(this);
            if (dataGridCategorie.Columns[e.ColumnIndex].Name == "Modifier")// si je click sur le button modifier dans datagridview
            {
                //id categorie
                frmcat.idcategorie = (int)dataGridCategorie.Rows[e.RowIndex].Cells[1].Value;
                //Afficher nom de categorie dans le form avant de le modifier 
                frmcat.lblTitre_cat.Text = "Modifier Catégorie";
                frmcat.textBox_nomcat.Text = dataGridCategorie.Rows[e.RowIndex].Cells[2].Value.ToString();// e.RowIndex c'est lindex de nom qu'on veut afficher
                frmcat.ShowDialog();
            }
            //supprimer Categorie
            if (dataGridCategorie.Columns[e.ColumnIndex].Name == "Supprimer")// si je click sur le button supprimer dans datagridview
            {
                BL.CLS_Categorie clscat = new BL.CLS_Categorie();
                DialogResult dr = MessageBox.Show("Voulez-vous vraimenet supprimer cette catégorie", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    //Verifier si il ya des produits dans cette categorie
                    int idcat = (int)dataGridCategorie.Rows[e.RowIndex].Cells[1].Value;
                    int p = db.Produits.Count(s => s.ID_CATEGORIE == idcat);// count : pour savoir combien de produit se trouve dans cette categorie
                    if(p==0)//aucun produit dans cette categorie
                    {
                        clscat.Supprimer_Categorie(idcat);
                        MessageBox.Show("Catégorie Supprimée avec succes", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //actualiser datagridview apres la suppression
                        remplirdatagrid();

                    }
                    else//il ya des produits dans cette categorie
                    {
                        DialogResult rpd = MessageBox.Show("il y a "+p+ " produit dans cette catégorie Voulez-vous vraimenet la supprimer", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rpd == DialogResult.Yes)
                        {
                            clscat.Supprimer_Categorie(idcat);
                            MessageBox.Show("Catégorie Supprimée avec succes", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            //actualiser datagridview apres la suppression
                            remplirdatagrid();
                        }
                        else
                        {
                            MessageBox.Show("Suppression annulée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Suppression annulée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBox_recherche_TextChanged(object sender, EventArgs e)
        {
            var maliste = db.Categories.ToList();
            maliste = maliste.Where(s => s.Nom_Categorie.IndexOf(textBox_recherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dataGridCategorie.Rows.Clear();
            foreach(var l in maliste)
            {
                dataGridCategorie.Rows.Add(false, l.ID_CATEGORIE, l.Nom_Categorie);
            }
        }

        private void button_excel_Click(object sender, EventArgs e)
        {
            db = new dbStockContext();
            string NomCategorie = "";
            int IdCategorie = 0;
            if(selectverif() != null)
            {
                MessageBox.Show(selectverif(), "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                using (SaveFileDialog sf = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })//filter seuelement fichier Excel
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet ws = (Worksheet)app.ActiveSheet;
                        app.Visible = false;
                        // Nom de categorie et id de categorie
                        for (int j = 0; j < dataGridCategorie.Rows.Count; j++)
                        {
                            if ((bool)dataGridCategorie.Rows[j].Cells[0].Value == true)
                            {
                                IdCategorie = (int)dataGridCategorie.Rows[j].Cells[1].Value;
                                NomCategorie = dataGridCategorie.Rows[j].Cells[2].Value.ToString();
                            }
                        }
                        // Ecrire Nom de Categorie dans le fichier excel
                        ws.Range["A1:D1"].Merge();
                        ws.Range["A1:D1"].Value = NomCategorie;
                        // Ajouter cells de produit
                        ws.Cells[2, 1] = "Id Produit";
                        ws.Cells[2, 2] = "Nom Produit";
                        ws.Cells[2, 3] = "Quantité";
                        ws.Cells[2, 4] = "Prix";
                        // Liste produit dans cette Categorie
                        var listeproduit = db.Produits.Where(s => s.ID_CATEGORIE == IdCategorie).ToList();
                        int i = 3;
                        foreach (var lp in listeproduit)
                        {
                            ws.Cells[i, 1] = lp.ID_Produit;
                            ws.Cells[i, 2] = lp.Nom_Produit;
                            ws.Cells[i, 3] = lp.Quantite_Produit;
                            ws.Cells[i, 4] = lp.Prix_Produit;
                            i++;
                        }
                        // Style de fichier excel
                        //  : Produit
                        ws.Range["A2:D2"].Interior.Color = Color.Teal;
                        ws.Range["A2:D2"].Font.Color = Color.White;
                        ws.Range["A2:D2"].Font.Size = 15;

                        //  : categorie
                        ws.Range["A1:D1"].Interior.Color = Color.DarkGreen;
                        ws.Range["A1:D1"].Font.Color = Color.White;
                        ws.Range["A1:D1"].Font.Size = 15;

                        // Centre texte
                        ws.Range["A:D"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        ws.Range["A2:D2"].ColumnWidth = 16;

                        // Sauvgarder dans Excel
                        wb.SaveAs(sf.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false);
                        app.Quit();
                        MessageBox.Show("Sauvgardé dans excel avec succé","Sauvgarder",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                    }
                }

            }


        }
    }
}
