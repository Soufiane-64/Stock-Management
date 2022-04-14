using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Stock.BL
{
    class CLS_Client
    {
        private dbStockContext db = new dbStockContext();
        private Client C; // Table Client

        //Fonction pour ajouter client dans la base de donnée
        public bool Ajouter_Client(string Nom, string Prenom, string Adresse, string Telephone, string Email, string Pays, string Ville)
        {
            C = new Client(); //Nouveau client
            C.Nom_Client = Nom;
            C.Prenom_Client = Prenom;
            C.Adresse_Client = Adresse;
            C.telephone_Client = Telephone;
            C.Email_Client = Email;
            C.Pays_Client = Pays;
            C.Ville_Client = Ville;

            // erifier si le nom et prenom existe deja dans la base de donnée
            if(db.Clients.SingleOrDefault(s=>s.Nom_Client==Nom && s.Prenom_Client==Prenom)== null)
            {
                db.Clients.Add(C);// Ajouter dans la table client
                db.SaveChanges();//enregistrer dans la base de donnée
                return true;

            }else // si existe deja dans la base de donnée
            {
                return false;
            }
        }
        
        
        //Fonction pour ajouter client dans la base de donnée
        public void modifier_Client(int ID, string Nom, string Prenom, string Adresse, string Telephone, string Email, string Pays, string Ville)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == ID); // Verifier si le client est existe avant de le modifier
            if(C!=null )// Existe
            {
                // des nouveaux données
                C.Nom_Client = Nom;
                C.Prenom_Client = Prenom;
                C.Adresse_Client = Adresse;
                C.telephone_Client = Telephone;
                C.Email_Client = Email;
                C.Pays_Client = Pays;
                C.Ville_Client = Ville;
                db.SaveChanges(); //sauvgarder les nouveaux données

            }
        }

        //Fonction pour supprimer client dans la base de donnée
        public void supprimer_Client(int ID)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == ID);
            if (C != null)// Existe
            {
                db.Clients.Remove(C);//pour supprimer le client
                db.SaveChanges();
            }

        }
    }
}
