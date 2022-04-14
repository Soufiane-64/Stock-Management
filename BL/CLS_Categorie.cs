 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Stock.BL
{
    class CLS_Categorie
    {
        private dbStockContext db = new dbStockContext();
        private Categorie cat;

        // Ajouter un categorie
        public bool Ajouter_Categorie(string NomCat)
        {
            cat = new Categorie();
            cat.Nom_Categorie = NomCat;

            // Verifier si lacategorie existe déja
            if (db.Categories.SingleOrDefault(a => a.Nom_Categorie == NomCat) == null)//n'existe pas
            {
                db.Categories.Add(cat);
                db.SaveChanges();
                return true;
            }
            else// categorie existe déja
            {
                return false;
            }

        }

        // Modifier un categorie
        public void Modifier_Categorie(int idCat, string NomCat)
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(a => a.ID_CATEGORIE == idCat);

            if(cat != null)
            {
                cat.Nom_Categorie = NomCat;
                db.SaveChanges();
            }


        }

        // Supprimer un categorie
        public void Supprimer_Categorie(int idCat )
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(a => a.ID_CATEGORIE == idCat);

            if (cat != null)
            {
                db.Categories.Remove(cat);
                db.SaveChanges();
            }


        }
    }
}
