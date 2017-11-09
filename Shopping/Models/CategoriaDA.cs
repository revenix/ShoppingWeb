using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shopping.Models;
using Shopping.Services;
using System.Data.SqlClient;
using Shopping.DataBase;
using System.Data;

namespace Shopping.Models
{
    public class CategoriaDA : ICategoria<Categoria>
    {

        public List<Categoria> ListCategoria()
        {
            List<Categoria> lista = new List<Categoria>();
            SqlConnection cn = AccesoBD.getConnection();
            SqlCommand cmd = new SqlCommand("sp_ListCategorias", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@prod", prod);

            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Categoria cat = new Categoria()
                    {
                        
                        id_cat = dr[0].ToString(),
                        nombre = dr[1].ToString()

                    };
                    lista.Add(cat);
                }
                dr.Close();
                cn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return lista;
        }
    }
}