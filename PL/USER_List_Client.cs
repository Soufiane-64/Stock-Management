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
    public partial class USER_List_Client : UserControl
    {
        private static USER_List_Client UserClient;
        private dbStockContext db;
        // Creer un instance pour le UserControle 
        public static USER_List_Client Instance
        {
            get
            {
                if(UserClient == null)
                {
                    UserClient = new USER_List_Client();
                }
                return UserClient;
            }

        }
        
        public USER_List_Client()
        {
            InitializeComponent();
            db = new dbStockContext();
            //Desactiver textBox de recherche 
            textBox_recherch.Enabled = false;
        }

        // Ajouter dans datagridview
        public void actualiserdatgrid()
        {
            db = new dbStockContext(); 
            dataGridClient.Rows.Clear();//vider datagridview
            foreach(var s in db.Clients)
            {
                // Ajouter les lignes dans datagridview
                dataGridClient.Rows.Add(false,s.ID_Client,s.Nom_Client,s.Prenom_Client,s.Adresse_Client,s.telephone_Client,s.Email_Client,s.Ville_Client,s.Pays_Client);

            }
        }
        // Verifier combien de lignes est selectionnée
        public string selectverif()
        {
            int nombreligneselect = 0;
            for(int i=0; i<dataGridClient.Rows.Count; i++)
            {
                if((bool)dataGridClient.Rows[i].Cells[0].Value == true) // si la ligne est selectionnée
                {
                    nombreligneselect++; //nombre de lignes va augmanter avec 1
                }
            }
            if(nombreligneselect == 0)
            {
                return "Séléctionner le client que vous voulez modifier";
            }
            if (nombreligneselect > 1)
            {
                return "Séléctionner seulement un seul client pour le modifier ";
            }
            return null;
        }
        private void USER_List_Client_Load(object sender, EventArgs e)
        {
            actualiserdatgrid();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBox_recherch.Text == "Rechercher")
            {
                textBox_recherch.Text = "";
                textBox_recherch.ForeColor = Color.Black;
            }
        }

        private void button_ajouterClient_Click(object sender, EventArgs e)
        {
            // Afficher le form de saisie
            PL.FRM_Ajouter_Modifier_Client frmclient = new FRM_Ajouter_Modifier_Client(this);
            frmclient.ShowDialog();
        }

        private void button_modifierClient_Click(object sender, EventArgs e)
        {

            PL.FRM_Ajouter_Modifier_Client frmclient = new FRM_Ajouter_Modifier_Client(this);
            if (selectverif() == null)
            {
                for (int i = 0 ; i < dataGridClient.Rows.Count ; i++)
                {
                    if ((bool)dataGridClient.Rows[i].Cells[0].Value == true) // si le chekbox est vrais  (cochée) afficher les informations dans le formulaire Client
                    {
                        frmclient.IDselect = (int)dataGridClient.Rows[i].Cells[1].Value;
                        frmclient.textBox_nomcl.Text = dataGridClient.Rows[i].Cells[2].Value.ToString();
                        frmclient.textBox_prnmcl.Text = dataGridClient.Rows[i].Cells[3].Value.ToString();
                        frmclient.textBox_addcl.Text = dataGridClient.Rows[i].Cells[4].Value.ToString();
                        frmclient.textBox_telecl.Text = dataGridClient.Rows[i].Cells[5].Value.ToString();
                        frmclient.textBox_emailcl.Text = dataGridClient.Rows[i].Cells[6].Value.ToString();
                        frmclient.textBox_villecl.Text = dataGridClient.Rows[i].Cells[7].Value.ToString();
                        frmclient.textBox_payscl.Text = dataGridClient.Rows[i].Cells[8].Value.ToString();
                    }

                }
                frmclient.lblTitre.Text = "Modifier Client";
                frmclient.button_actualiser.Visible = false;
                frmclient.ShowDialog();
            }else
            {
                MessageBox.Show(selectverif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        private void button_supprimerClient_Click(object sender, EventArgs e)
        {
            BL.CLS_Client clclient = new BL.CLS_Client();
            //pour supprimer tout les clients séléctionnés
            int select = 0;
            for (int i = 0; i < dataGridClient.Rows.Count; i++)
            {
                if((bool)dataGridClient.Rows[i].Cells[0].Value == true)
                {
                    select++; //nombre de lignes selectionnées
                }
            }
            if(select == 0)
            {
                MessageBox.Show("Aucun Client selectonnée", "suppressoin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer ce client ?", "suppressoin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(R==DialogResult.Yes)
                {
                    //pour supprimer tout les clients selectionnés
                    for (int i = 0; i < dataGridClient.Rows.Count; i++)
                    {
                        if ((bool)dataGridClient.Rows[i].Cells[0].Value == true)
                        {
                            clclient.supprimer_Client(int.Parse(dataGridClient.Rows[i].Cells[1].Value.ToString()));// ID Client
                        }
                    }
                    // Actualiser datagridview
                    actualiserdatgrid();
                    MessageBox.Show("Client supprimé avec succées","suppression",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Suppression est annulée", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }

        private void comboBox_recherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            // activer le textBox de recherche quand je choisie un element dans le comboBox
            textBox_recherch.Enabled = true;
            textBox_recherch.Text = "";
        }


        private void textBox_rechercher_Enter(object sender, EventArgs e)
        {
            if (textBox_recherch.Text == "Recherche")
            {
                textBox_recherch.Text = "";
                textBox_recherch.ForeColor = Color.Black;
            }
        }

        private void comboBox_recherche_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // activer le textbox recherche
            textBox_recherch.Enabled = true;
            textBox_recherch.Text = "";
        }

        private void textBox_recherch_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listrcherche = db.Clients.ToList();// listrcherche = liste des client
            if(textBox_recherch.Text != "")//pas vide
            {
                switch(comboBox_recherche.Text)
                {
                    case "Nom":
                        listrcherche = listrcherche.Where(s => s.Nom_Client.IndexOf(textBox_recherch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        // StringComparison.CurrentCultureIgnoreCase : soit j ecrit en minuscule ou majescule il n' ya pas de differnce
                        // -1 : exsite dans la base de donnée
                        break;
                    case "Prenom":
                        listrcherche = listrcherche.Where(s => s.Prenom_Client.IndexOf(textBox_recherch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Telephone":
                        listrcherche = listrcherche.Where(s => s.telephone_Client.IndexOf(textBox_recherch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Email":
                        listrcherche = listrcherche.Where(s => s.Email_Client.IndexOf(textBox_recherch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Ville":
                        listrcherche = listrcherche.Where(s => s.Ville_Client.IndexOf(textBox_recherch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Pays":
                        listrcherche = listrcherche.Where(s => s.Pays_Client.IndexOf(textBox_recherch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;

                }
            }
            // vider datagridview
            dataGridClient.Rows.Clear();
            // ajouter listrecherche dans datagrid view 
            foreach(var l in listrcherche )
            {
                dataGridClient.Rows.Add(false, l.ID_Client, l.Nom_Client, l.Prenom_Client, l.Adresse_Client, l.telephone_Client, l.Email_Client, l.Ville_Client, l.Pays_Client);
            }
        }

        private void textBox_recherch_Leave(object sender, EventArgs e)
        {

        }
    }
}
