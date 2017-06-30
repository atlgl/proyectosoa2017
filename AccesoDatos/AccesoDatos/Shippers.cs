using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EjemploNorthWindEmpleados;
using EjemploNorthWindEmpleados.AccesoDatos;
using AccesoDatos.Entidades;
using System.Windows;

namespace EjemploNorthWindEmpleados.AccesoDatos
{
   public class Shippers
    {
        public static List<Shipper> getAll()
        {
            
            ConexionBD con = new ConexionBD();
            List<Shipper> listaobjetos = new List<Shipper>();
            SqlDataReader dr = con.executeQuery("SELECT * FROM Shippers");
            while (dr.Read())
            {
                Shipper shipp = new Shipper();
                shipp.ShipperID = dr.GetInt32(0);
                shipp.CompanyName = dr.GetString(1);
                shipp.Phone = dr.GetString(2);

                listaobjetos.Add(shipp);
            }
            con.close();

            return listaobjetos;
        }

        public static Shippers getById(int id)
        {
            return null;
        }

        public static int edit(int id , String companyname, String phone )
        {
            SqlCommand cmd;
            ConexionBD con = new ConexionBD();
            con.open();
            cmd = new SqlCommand("UPDATE Shippers SET CompanyName=@campanyname, Phone=@phone WHERE ShipperID=@id", con.con);
            cmd.Parameters.AddWithValue("@campanyname", companyname);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@id", id);
            int res = cmd.ExecuteNonQuery();
            con.close();
            return res;
        }

        public static int create(String name ,String phone)
        { 
           
                SqlCommand cmd;
                ConexionBD con = new ConexionBD();
                con.open();
                cmd = new SqlCommand("insert into Shippers(CompanyName, Phone) values(@companyname, @phone)", con.con);
                cmd.Parameters.AddWithValue("@companyname", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                int res = cmd.ExecuteNonQuery();
                
                con.close();
         
            return res;

        }

        public static int remove(int id)
        {
            ConexionBD con = new ConexionBD();
            int res = con.executeNonQuery("DELETE Shippers  WHERE ShipperID=" + id);
            con.close();
            return res;

        }
    }
}
