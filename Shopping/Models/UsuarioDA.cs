using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shopping.Services;
using System.Data.SqlClient;
using Shopping.DataBase;
using System.Data;
using Dapper;

namespace Shopping.Models
{
    public class UsuarioDA : IUsuario<Cliente>
    {
        public Cliente Login(string user, string pass)
        {
            using (var cadena = AccesoBD.getConnection())
            {

                var parameter = new DynamicParameters();
                parameter.Add("@user", user);
                parameter.Add("@pass", pass);

                return cadena.QueryFirst<Cliente>("sp_login", parameter, commandType: CommandType.StoredProcedure);

                 }

            }

        /*public List<Producto> ProductoNombre(string prod)
        {
            List<Producto> lista = new List<Producto>();
            SqlConnection cn = AccesoDB.getConnection();
            SqlCommand cmd = new SqlCommand("usp_ProductoNombre", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prod", prod);

            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Producto pro = new Producto()
                    {
                        IdProducto = Convert.ToInt32(dr[0]),
                        NombreProducto = dr[1].ToString(),
                        umedida = dr[2].ToString(),
                        Precio = Convert.ToDecimal(dr[3]),
                        Stock = Convert.ToInt32(dr[4]),
                    };
                    lista.Add(pro);
                }
                dr.Close();
                cn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return lista;
        }*/
    }
}
 