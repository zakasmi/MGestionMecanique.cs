using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarocMecan
{
    public partial class Materiel : Form
    {
        public Materiel()
        {
            InitializeComponent();
        }

        private void BTN_Ajouter_Materiel_Click(object sender, EventArgs e)
        {
            try
            {
                CMateriel cm = new CMateriel();

                cm.Id_Materiel1 = TB_ID_Materiel.Text;
                cm.Description_Mat1 = TB_Description.Text;
                cm.NSerie1 = TB_NSerie.Text;
                cm.Id_modele = TB_ID_Modele.Text;
                cm.PrixAchat1 = float.Parse(TB_PrixAchat.Text);
                cm.Id_Lot1 = TB_ID_Lot.Text;
                cm.Id_Etat1 = TB_ID_Etat.Text;
                bool resultat = cm.Ajouter();
                if (resultat)
                {
                    MessageBox.Show("Le Materiel est Ajouté avec succès");
                    Materiel_Load(sender, e);
                }
                else MessageBox.Show("n'esp Pas aJouté");
            }
            catch (Exception e2)
            {

                MessageBox.Show(e2.Message);
            }
        }

        private void Materiel_Load(object sender, EventArgs e)
        {
            CMateriel cm1 = new CMateriel();

            DataTable dt = new DataTable();
            Provider.cnx.Open();
            SqlDataReader dr = cm1.Affichage();
            dt.Load(dr);
            Provider.cnx.Close();
            DGV1_Materiel.DataSource = dt;
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TB_ID_Materiel.Text))
                {
                    CMateriel cm = new CMateriel(TB_ID_Materiel.Text);
                    if (cm.Supprimer())
                    {

                        MessageBox.Show("Supprimer");
                        Materiel_Load(sender, e);
                    }
                    else MessageBox.Show("n'est pas supprimer");
                }
                else MessageBox.Show("Entrer Un Id Materiel");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);

            }

        }

        private void BTN_Rechercher_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TB_ID_Materiel.Text))
            {
              
                CMateriel cm1 = new CMateriel(TB_ID_Materiel.Text);
                CMateriel cm2 = cm1.Rechercher();
                int i = 0;
                foreach (Control T in groupBox1.Controls)
                {
                    i++;
                    if (i==1)
                    {
                        continue;
                    }
                   
                    if (T is TextBox) { T.Text = ""; }
                    
                }
                if (string.IsNullOrEmpty(cm2.Id_Materiel1))
                {
                    MessageBox.Show("ce Materiel n'existe Pas ");
                }
                else
                {
                    
                    TB_ID_Materiel.Text = cm2.Id_Materiel1;
                    TB_Description.Text = cm2.Description_Mat1;
                    TB_NSerie.Text = cm2.NSerie1;
                    TB_ID_Modele.Text = cm2.Id_modele;
                    TB_PrixAchat.Text = cm2.PrixAchat1.ToString();
                    TB_ID_Lot.Text = cm2.Id_Lot1;
                    TB_ID_Etat.Text = cm2.Id_Etat1;

                }

            }
            else MessageBox.Show("Entrer un ID Materiel");
        }
    }
}
