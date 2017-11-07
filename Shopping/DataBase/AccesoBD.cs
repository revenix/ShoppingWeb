using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Shopping.DataBase
{
    public class AccesoBD
    {

        public static SqlConnection getConnection()
        {
            SqlConnection cnx = new SqlConnection(
              ConfigurationManager.ConnectionStrings["Shopping"].ConnectionString);
            return cnx;
        }

    }
}