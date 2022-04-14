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
    
    public partial class Frm_Client_Commande : Form
    {
        private dbStockContext db;
        public Frm_Client_Commande()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        private void dataGridClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void Frm_Client_Commande_Load(object sender, EventArgs e)
        {
            // remplir datagridview par lise des clients
             foreach(var lc  in db.Clients)
            {
                dataGridClient.Rows.Add(lc.ID_Client, lc.Nom_Client, lc.Prenom_Client, lc.Adresse_Client, lc.telephone_Client, lc.Email_Client, lc.Ville_Client, lc.Pays_Client);
            }
        }

        private void dataGridClient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Quitter le formuliare
            this.Close();
        }

        private void dataGridClient_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            this.Close();
        }
        private void dataGridClient_RowDividerClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            this.Close();
        }
    }
}
