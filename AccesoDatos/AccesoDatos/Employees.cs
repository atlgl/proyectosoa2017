using EjemploNorthWindEmpleados.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploNorthWindEmpleados.AccesoDatos
{
    public class Employees 
    {
        public static List<Employee> getAll()
        {
            ConexionBD con = new ConexionBD();
            List<Employee> listaobjetos = new List<Employee>();
            SqlDataReader dr = con.executeQuery("GetAllEmployees",null);
            while (dr.Read())
            {
                Employee emp = new Employee();
                emp.Id = dr.GetInt32(0);
                emp.LastName = dr.GetString(1);
                emp.Title = dr.GetString(3);
                emp.FirstName = dr.GetString(2);
                listaobjetos.Add(emp);
            }
            con.close();
            
            return listaobjetos;
        }

        public static Employee getById(int id)
        {
            return null;
        }

        public static int edit(Employee e)
        {
            return 1;
        }

        public static int create(Employee e)
        {
            return 1;
        }

        public static int remove(int id)
        {
            ConexionBD con = new ConexionBD();
            int res = con.executeNonQuery("DELETE FROM employees WHERE id=" + id);
            con.close();
            return res;
            
        }

        //city ivan
        //customers liove
        //ismael products
        //David Categorys
        //jesus historyOrderDetail,
        //usuario correo password,idemployeee,activado, 
        //region ivan
        //territories amiguito
        //orders noe 
        //ordersdetails alfredo
        //carlos shippers
        //karla suplliers
        //erika customer demographis





     
    }
}
