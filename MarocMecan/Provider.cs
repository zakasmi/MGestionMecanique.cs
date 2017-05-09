using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarocMecan
{
    class Provider
    {

       public static SqlConnection cnx = new SqlConnection(@"Data Source = DELL; Initial Catalog = MarocMecan; Integrated Security = True");
        public static DataSet ds = new DataSet();


    }
}
