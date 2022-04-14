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
    public partial class User_Liste_commande : UserControl
    {
        private static User_Liste_commande UserCommande;
        private dbStockContext db;

        // Creer un instance pour le UserControle 
        public static User_Liste_commande Instance
        {
            get
            {
                if (UserCommande == null)
                {
                    UserCommande = new User_Liste_commande();
                }
                return UserCommande;
            }

        }
        public User_Liste_commande()
        {
            InitializeComponent();
            db = new dbStockContext();
        }
        //Remplir DataGridView Commandes
        public void replirdata()
        {
            dataGridcommande.Rows.Clear();
            Client c = new Client();
            string NomPrenom;
            foreach(var LC in db.Commandes)
            {
                //Afficher nom et prenom du client dans Datagridview
                c = db.Clients.Single(s => s.ID_Client == LC.ID_Client);
                NomPrenom = c.Nom_Client + " " + c.Prenom_Client;
                dataGridcommande.Rows.Add(LC.ID_Commande, LC.Date_Commande, NomPrenom, LC.ToTaL_HT, LC.TVA, LC.ToTaL_TTC);
            }
        }

        private void User_Liste_commande_Load(object sender, EventArgs e)
        {
            replirdata();
        }

        private void button_ajoutercommande_Click(object sender, EventArgs e)
        {
            PL.FRM_Detail_Commande frmC = new FRM_Detail_Commande(this);
            frmC.ShowDialog();
        }

        private void button_cherche_Click(object sender, EventArgs e)
        {
            //Recherche entre deux date 
            var listecommande = db.Commandes.ToList();//Liste des Commandes 
            if( dataGridcommande.Rows.Count != 0 )
            {
                listecommande = listecommande.Where(s => s.Date_Commande.Date >= dated.Value.Date && s.Date_Commande.Date <= datef.Value.Date).ToList();
                //Remplir datagridview
                dataGridcommande.Rows.Clear();
                Client c = new Client();
                string NomPrenom;
                foreach (var LC in listecommande)
                {
                    //Afficher nom et prenom du client dans Datagridview
                    c = db.Clients.Single(s => s.ID_Client == LC.ID_Client);
                    NomPrenom = c.Nom_Client + " " + c.Prenom_Client;
                    dataGridcommande.Rows.Add(LC.ID_Commande, LC.Date_Commande, NomPrenom, LC.ToTaL_HT, LC.TVA, LC.ToTaL_TTC);
                }
            }

        }
    }
}
