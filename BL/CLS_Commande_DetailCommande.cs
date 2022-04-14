using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Stock.BL
{
    class CLS_Commande_DetailCommande
    {
        private dbStockContext db = new dbStockContext();
        private Commande clscmd;
        private Details_Commande clsD;
        public int IDCommande;
        // la premiére chose qu'on doit faire c'est sauvgarder une commande

        public void Ajouter_Commande(DateTime datecommande, int idclient, string totalht, string tva, string totalttc)
        {
            clscmd = new Commande();
            clscmd.Date_Commande = datecommande;
            clscmd.ID_Client = idclient;
            clscmd.ToTaL_HT = totalht;
            clscmd.TVA = tva;
            clscmd.ToTaL_TTC = totalttc;
            db.Commandes.Add(clscmd);
            db.SaveChanges();
            IDCommande = clscmd.ID_Commande;// ID de Commande Ajouter 
        }
        // Puis on vas ajouter detail de commande

        public void Ajouter_Detail(int idproduit, string NomProduit, int quantite, string prix, string remise, string total)
        {
            clsD = new Details_Commande();
            clsD.ID_Commande = IDCommande;
            clsD.ID_Produit = idproduit;
            clsD.Nom_Produit = NomProduit;
            clsD.Quantite = quantite;
            clsD.Prix = prix;
            clsD.Remise = remise;
            clsD.ToTal = total;
            db.Details_Commande.Add(clsD);
            db.SaveChanges();
        }

    }
}
