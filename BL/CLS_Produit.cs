using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Stock.BL
{
    class CLS_Produit
    {
        private dbStockContext db = new dbStockContext();
        private Produit PR;
         // Ajouter Produit
         public bool Ajouter_Produit(string NomP, int QuantiteP, string PrixP, byte[] image, int idcategorie) //pour sauvgarder une image dans la base de donnée il faut qu'elle soit sous format Byte
        {
            PR = new Produit();
            PR.Nom_Produit = NomP;
            PR.Quantite_Produit = QuantiteP;
            PR.Prix_Produit = PrixP;
            PR.Image_Produit = image;
            PR.ID_CATEGORIE = idcategorie;
            // Verifier si le produit existe déja
            if(db.Produits.SingleOrDefault(a=>a.Nom_Produit == NomP) == null)//n'existe pas
            {
                db.Produits.Add(PR);
                db.SaveChanges();
                return true;
            }else
            {
                return false;
            }

        }
         // Modifier Produit
        public void Modifier_Produit(int IDP, string NomP, int QuantiteP, string PrixP, byte[] image, int idcategorie)
        {
            PR = new Produit();
            PR = db.Produits.SingleOrDefault(s => s.ID_Produit == IDP); // si ID produit = mon ID
            if(PR != null) // Si Existe
            {
                PR.Nom_Produit = NomP;
                PR.Quantite_Produit = QuantiteP;
                PR.Prix_Produit = PrixP;
                PR.Image_Produit = image;
                PR.ID_CATEGORIE = idcategorie;
                db.SaveChanges();
            }
        }
        // Supprimer Produit  
        public void Supprimer_Produit(int id)
        {
            PR = new Produit();
            PR = db.Produits.SingleOrDefault(s => s.ID_Produit == id); // si ID produit = mon ID
            if (PR != null) // Si Existe
            {
                db.Produits.Remove(PR);
                db.SaveChanges();
            }
        }

    }
}
