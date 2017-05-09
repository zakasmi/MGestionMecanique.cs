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
    public partial class Reparation : Form
    {
        public Reparation()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        int pos = 0;
        private void BTN_Ajouter_Reparation_Click(object sender, EventArgs e)
        {

            DataRow dr = ds.Tables["Reparation"].NewRow();

            dr[0] = TB_Id_Preparation.Text;
            dr[1] = TB_id_piece.Text;
            dr[2] = TB_id_materiel.Text;
            dr[3] = DTP_Dtae_Envoie_Reparation.Value;
            dr[4] = DTP_Date_Retour_Reparation.Value;
            dr[5] = TB_Montant_Reparation.Text;
            dr[6] = TB_Observation_Reparation.Text;

            ds.Tables["Reparation"].Rows.Add(dr);
            if (MiseAjour()) { MessageBox.Show("Ajouter Avec Succes"); }


        }

        private void Reparation_Load(object sender, EventArgs e)
        {
            List_ID_Materiel.BindingContext = new BindingContext();
            List_ID_Materiel.ValueMember = "ID_Materiel";
            List_ID_Materiel.DisplayMember = "ID_Materiel";
            List_ID_Materiel.DataSource = RemplirList();

            if (ds.Tables.Contains("Reparation")) { ds.Tables["Reparation"].Rows.Clear(); }
            SqlDataAdapter da = new SqlDataAdapter("select *from Reparation", Provider.cnx);
            da.Fill(ds, "Reparation");
            ds.Tables["Reparation"].PrimaryKey = new DataColumn[] { ds.Tables["Reparation"].Columns[0] };

            DGV1_Reparation.DataSource = ds.Tables["Reparation"];
        }






        public DataTable RemplirList()
        {
            CMateriel cm = new CMateriel();
            Provider.cnx.Open();

            SqlDataReader dr = cm.Affichage();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Materiel");
            while (dr.Read())
            {

                dt.Rows.Add(dr[0]);
            }
           
            Provider.cnx.Close();
            return dt;

        }
        public bool MiseAjour()
        {

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select *from Reparation", Provider.cnx);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["Reparation"]);
                return true;
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
                return false;
            }

        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_Id_Preparation.Text))
            {

                ds.Tables["Reparation"].Rows.Find(TB_Id_Preparation.Text).Delete();
                if (MiseAjour()) { MessageBox.Show("Supprimer Avec Succes"); }

            }
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["Reparation"].Rows.Find(TB_Id_Preparation.Text);

            dr[0] = TB_Id_Preparation.Text;
            dr[1] = TB_id_piece.Text;
            dr[2] = TB_id_materiel.Text;
            dr[3] = DTP_Dtae_Envoie_Reparation.Value;
            dr[4] = DTP_Date_Retour_Reparation.Value;
            dr[5] = TB_Montant_Reparation.Text;
            dr[6] = TB_Observation_Reparation.Text;

            if (MiseAjour()) { MessageBox.Show("Modifié avec succes"); }


        }

        private void BTN_Suivant_Click(object sender, EventArgs e)
        {

            if ((pos < DGV1_Reparation.Rows.Count-1) && DGV1_Reparation.Rows.Count > 0)
            {
                pos++;
                move(pos);
            }

        }

        public void move(int x)
        {
            
            TB_Id_Preparation.Text = DGV1_Reparation.Rows[x].Cells[0].Value.ToString();
            TB_id_piece.Text = DGV1_Reparation.Rows[x].Cells[1].Value.ToString();
            TB_id_materiel.Text = DGV1_Reparation.Rows[x].Cells[2].Value.ToString();
            DTP_Dtae_Envoie_Reparation.Value = DateTime.Parse(DGV1_Reparation.Rows[x].Cells[3].Value.ToString());
            DTP_Date_Retour_Reparation.Value = DateTime.Parse(DGV1_Reparation.Rows[x].Cells[4].Value.ToString());
            TB_Montant_Reparation.Text = DGV1_Reparation.Rows[x].Cells[5].Value.ToString();
            TB_Observation_Reparation.Text = DGV1_Reparation.Rows[x].Cells[6].Value.ToString();
            
        }

        private void BTN_Debut_Click(object sender, EventArgs e)
        {
            if (DGV1_Reparation.Rows.Count > 0)
            {
                pos = 0;
                move(pos);
            }
        }

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            pos = 0;
            DGV1_Reparation.DataSource = null;

            if (List_ID_Materiel.SelectedIndex != -1)
            {
                MessageBox.Show(List_ID_Materiel.SelectedValue.ToString());
                DataTable dt = ds.Tables["Reparation"].Clone();
                DataRow[] dr = ds.Tables["Reparation"].Select("id_materiel ='"+ List_ID_Materiel.SelectedValue.ToString() + "'");
                foreach (DataRow D in dr) {
                    dt.ImportRow(D);
                }


                DGV1_Reparation.DataSource = dt;
            }
            else MessageBox.Show("Selectionnés un id depuis la liste");


        }

        private void BTN_Rechercher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_Id_Preparation.Text))
            {

                DataRow dr = ds.Tables["Reparation"].Rows.Find(TB_Id_Preparation.Text);

                if (dr !=null)
                {
                    TB_Id_Preparation.Text = dr[0].ToString();
                    TB_id_piece.Text = dr[1].ToString();
                    TB_id_materiel.Text = dr[2].ToString();
                    DTP_Dtae_Envoie_Reparation.Value = DateTime.Parse(dr[3].ToString());
                    DTP_Date_Retour_Reparation.Value = DateTime.Parse(dr[4].ToString());
                    TB_Montant_Reparation.Text = dr[5].ToString();
                    TB_Observation_Reparation.Text = dr[6].ToString();

               
                } else MessageBox.Show("n'existe Pas");
            }
            else MessageBox.Show("Entrer un ID reparation");
        }

        private void Afficher_2date_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("PS_ListeMateriel", Provider.cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Date1", DTP1.Value.ToString());
            cmd.Parameters.AddWithValue("@Date2", DTP2.Value.ToString());
            Provider.cnx.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(dr);
            DGV1_Reparation.DataSource = dt;

            Provider.cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Histogramme H = new Histogramme();
            H.ShowDialog();
        }

        private void BTN_ExportHTMl_Click(object sender, EventArgs e)
        {
            StringBuilder HtmlBody = new StringBuilder();
            HtmlBody.Append("<!doctype html><html><head><title>Reparation</title></head><body>");
            HtmlBody.Append("<table border=1>");
            HtmlBody.Append("<tr>");
            foreach (DataColumn C in ds.Tables["Reparation"].Columns)
            {


                HtmlBody.Append("<td>");
                HtmlBody.Append(C.ColumnName);
                HtmlBody.Append("</td>");

            }
            HtmlBody.Append("</tr>");
            foreach (DataRow dr in ds.Tables["Reparation"].Rows)
            {
                HtmlBody.Append("<tr>");
                foreach (DataColumn dc in ds.Tables["Reparation"].Columns)
                {

                    HtmlBody.Append("<td>");
                    HtmlBody.Append(dr[dc.ColumnName].ToString());
                    HtmlBody.Append("</td>");

                }
                HtmlBody.Append("</tr>");
            }
            HtmlBody.Append("</table>");
            HtmlBody.Append("</body></html>");
            string htmlpage = HtmlBody.ToString();
            System.IO.File.WriteAllText(@"Reparation.HTML", htmlpage);
         
            MessageBox.Show("Le Fichier Html est creer avec succes \\MarocMecan\bin\\Reparation.HTML");


        }
    }
}
