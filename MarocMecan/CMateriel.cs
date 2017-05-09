using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarocMecan
{
    class CMateriel
    {

        private string Id_Materiel; 
        private string Description_Mat;
        private string  NSerie  ;
        private string id_modele;
        private  float PrixAchat;
        private string  Id_Lot ;
        private string Id_Etat;


        // Getters and Setters 
        public string Id_Materiel1
        {
            get
            {
                return Id_Materiel;
            }
            set
            {
                Id_Materiel = value;
            }
        }

        public string Description_Mat1
        {
            get
            {
                return Description_Mat;
            }
            set
            {
                Description_Mat = value;
            }
        }

        public string NSerie1
        {
            get
            {
                return NSerie;
            }
            set
            {
                NSerie = value;
            }
        }
        public string Id_modele
        {
            get
            {
                return id_modele;
            }
            set
            {
                id_modele = value;
            }
        }
        public float PrixAchat1
        {
            get
            {
                return PrixAchat;
            }
            set
            {
                PrixAchat = value;
            }
        }

        public string Id_Lot1
        {
            get
            {
                return Id_Lot;
            }
            set
            {
                Id_Lot = value;
            }
        }

        public string Id_Etat1
        {
            get
            {
                return Id_Etat;
            }
            set
            {
                Id_Etat = value;
            }
        }
        // -- Constructor -----------
        // Constructeru 1
        public CMateriel()
        {
        }
        // Constructeru 2
        public CMateriel(string Imat)
        {
            this.Id_Materiel = Imat;
        }
        // Constructeru 3
        // 
        public CMateriel( string Id_Materiel,string Description_Mat,string NSerie,string id_modele,float PrixAchat,string Id_Lot,string Id_Etat)
        {
            this.Id_Materiel = Id_Materiel;
            this.Description_Mat = Description_Mat;
            this.NSerie = NSerie;
            this.id_modele =  id_modele;
            this.PrixAchat = PrixAchat;
            this.Id_Lot =   Id_Lot;
            this.Id_Etat =   Id_Etat;
    }

        // 
        public bool Ajouter()
        {

            using (SqlCommand cmd = new SqlCommand("insert into Materiel values('" + Id_Materiel + "','" + Description_Mat + "','"+ NSerie + "','" + id_modele + "','" + PrixAchat.ToString() + "','" + Id_Lot + "','"+ Id_Etat+"')",Provider.cnx))
            {
                Provider.cnx.Open();
                int x= cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    return true;
                }
                else return false;
            }
        }
        public bool Supprimer()
        {
            using (SqlCommand cmd = new SqlCommand(" delete from Materiel where Id_Materiel ='" + Id_Materiel + "'", Provider.cnx))
            {
                Provider.cnx.Open();
                int x = cmd.ExecuteNonQuery();
                Provider.cnx.Close();
                if (x > 0)
                {
                    return true;
                }
                else return false;
            }

        }

        public CMateriel Rechercher()
        {

            CMateriel cm2 = new CMateriel();
            SqlCommand cmd = new SqlCommand("select *from Materiel where Id_Materiel='"+this.Id_Materiel+"'",Provider.cnx);

            Provider.cnx.Open();
            SqlDataReader dr = cmd.ExecuteReader();
           
            if (dr.HasRows)
            {
                dr.Read();
                cm2.Id_Materiel = dr[0].ToString();
                cm2.Description_Mat = dr[1].ToString();
                cm2.NSerie = dr[2].ToString();
                cm2.id_modele = dr[3].ToString();
                cm2.PrixAchat = float.Parse(dr[4].ToString());
                cm2.Id_Lot = dr[5].ToString();
                cm2.Id_Etat = dr[6].ToString();
            }
            Provider.cnx.Close();
            return cm2;

        }

        public SqlDataReader  Affichage()
        {
            SqlCommand cmd = new SqlCommand("select *from Materiel", Provider.cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        }
}
