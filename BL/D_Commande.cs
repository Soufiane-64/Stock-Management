using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Stock.BL
{
    class D_Commande
    {
        private dbStockContext db = new dbStockContext();
        private Details_Commande dc;
        //sauvgarder les ptoduits commandés dans une liste

        public static List<D_Commande> listedetail = new List<D_Commande>();

        public int Id { get; set; }
        public string Nom { get; set; }
        public int Quantite { get; set; }
        public string Prix { get; set; }
        public string Remise { get; set; }
        public string Total { get; set; }



    }
}
