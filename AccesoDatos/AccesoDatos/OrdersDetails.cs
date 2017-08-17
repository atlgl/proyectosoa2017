using System.Data.SqlClient;
using System.Collections.Generic;
using AccesoDatos.Entidades;
using System.Data.Sql;

namespace EjemploNorthWindEmpleados.AccesoDatos
{
    public class OrdersDetails
    {
        public static ConexionBD con = new ConexionBD();
        public static SqlCommand cmd;

        public static List<OrderDetails> getAll()
        {
            
            List<OrderDetails> listaobjetos = new List<OrderDetails>();
            try
            {
                SqlDataReader dr = con.executeQuery("SELECT * FROM [Order Details]");
                while (dr.Read())
                {
                    OrderDetails orD = new OrderDetails();
                    orD.OrderID = dr.GetInt32(0);
                    orD.ProductID = dr.GetInt32(1);
                    orD.UnitPrice = dr.GetDecimal(2);
                    orD.Quantity = dr.GetInt16(3);
                    orD.Descount = dr.GetFloat(4);

                    listaobjetos.Add(orD);
                }
                con.close();
            }
            catch(SqlException ex)
            {
                
            }
            return listaobjetos;
        }


        public static int create(int OrderId, int ProductID, double UnitPrice, int Quantity, float Discount)
        {
            con.open();
            cmd = new SqlCommand("INSERT INTO [Order Details] VALUES("+OrderId+", "+ProductID+", "+UnitPrice+", "+Quantity+", "+Discount+")", con.con);
            int result = cmd.ExecuteNonQuery();
            con.close();

            return result;
        }

        public static int remove(int OrderId)
        {
            int result = con.executeNonQuery("delete from [Order Details] where OrderID = " + OrderId + "");
            con.close();

            return result;
        }
        
        public static int edit(int OrderId, double UnitPrice, int Quantity, float Discount)
        {
            int result = 0;
            SqlCommand cmd1;
            con.open();
                cmd1 = new SqlCommand("update [Order Details] set UnitPrice = " + UnitPrice + ", Quantity = " + Quantity + ", Discount = " + Discount + " where OrderID = " + OrderId + "", con.con);

                result = cmd1.ExecuteNonQuery();

                con.close();
                
            return result;
        }

    }
}
