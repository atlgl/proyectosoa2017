using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;

namespace EjemploNorthWindEmpleados.AccesoDatos
{
    /**
     * Clase que se encarga de hacer una conexion a BD
     * esta clase solo permite conexiones a SQLServer
     * */

    public class ConexionBD
    {
        public SqlConnection con;
        private SqlCommand cmd;
        
        public ConexionBD()
        {
            try
            {
                string cadena = ConfigurationManager.ConnectionStrings["Micadena"].ConnectionString;
                con = new SqlConnection(cadena);
                cmd = new SqlCommand();
                cmd.Connection = con;
            }
            catch(SqlException ex)
            {
                
            }
        }

        public int executeNonQuery(string consulta)
        {
            int retorno = 0;

            try
            {
                cmd.CommandText = consulta;
                open();
                retorno = cmd.ExecuteNonQuery();
                close();
            }
            catch(SqlException e)
            {

            }
            return retorno;
        }

        public SqlDataReader executeQuery(string consulta)
        {
            try
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;
                open();

                } catch(SqlException e){
                
                }
           return cmd.ExecuteReader();
        }

        public SqlDataReader executeQuery(string comando,SqlParameterCollection p)
        {

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = comando;
                foreach (SqlParameter item in p)
                    cmd.Parameters.Add(item);
                open();
            }
            catch(SqlException e)
            {

            }


            return cmd.ExecuteReader();
        }

        public int executeNonQuery(string comando,SqlParameterCollection p)
        {
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = comando;
            foreach (SqlParameter item in p)
                cmd.Parameters.Add(item);
            open();
            int retorno = cmd.ExecuteNonQuery();
            close();
            return retorno;
        }


        public void open()
        {
            if(con !=null && con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch(SqlException e)
                {

                }
            }
        }

        public void close()
        {
            if(con !=null  && con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }


    }
}
