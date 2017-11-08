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
    public class ProductoDA : IProductos<Producto>
    {

        public Producto nombrefoto(string id_pro)
        {
            Producto obj = new Producto();
            SqlConnection cn = AccesoBD.getConnection();
            SqlCommand cmd = new SqlCommand("sp_traerfoto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@id", id_pro);

            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
               
                    obj.foto1 = (byte[])(dr[0]);
                }
                dr.Close();
                cn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return obj;

        }

        public List<Producto> ListProductos()
        {
            List<Producto> lista = new List<Producto>();
            SqlConnection cn = AccesoBD.getConnection();
            SqlCommand cmd = new SqlCommand("sp_Productos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
           // cmd.Parameters.AddWithValue("@prod", prod);

            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Producto pro = new Producto()
                    {
                        cod_producto = dr[0].ToString(),
                        nombre = dr[1].ToString(),
                        precio_compra =Convert.ToDouble( dr[2]),
                        precio_venta = Convert.ToDouble(dr[3]),
                        stock = Convert.ToInt32(dr[4]),
                        descripcion = dr[5].ToString(),
                        id_marca = dr[6].ToString(),
                        id_cat = dr[7].ToString()
                        
                        
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
        }
    }
}