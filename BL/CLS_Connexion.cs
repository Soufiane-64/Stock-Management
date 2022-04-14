using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Stock.BL
{
    class CLS_Connexion
    {
        //Function pour verifier la connexion
        public bool ConnexionValide(dbStockContext db, string nom,string Mot_de_pass)
        {
            Utilisateur U = new Utilisateur();//Table utilisateur
            U.NomUtilisateur = nom;
            U.Mot_De_Passe = Mot_de_pass;
            if(db.Utilisateurs.SingleOrDefault(s=>s.NomUtilisateur == nom && s.Mot_De_Passe == Mot_de_pass)!= null) // Si le nom de l'utilisateur et lr mot de pass existent dans la base de données
            {
                return true;
            }
            else // Si le nom de l'utilisateur et lr mot de pass n'existent pas  dans la base de données
            {
                return false;
            }

        }
    }
}
