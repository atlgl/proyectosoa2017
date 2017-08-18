﻿using EjemploNorthWindEmpleados.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EjemploNorthWindEmpleados.AccesoDatos
{
    public class Categories
    {
        /// <summary>  
        ///  Select Method (List<Category>) 
        /// </summary>  
        public static List<Category> getAll()
        {
            ConexionBD con = new ConexionBD();
            List<Category> listaobjetos = new List<Category>();
            SqlDataReader dataReader = con.executeQuery("SELECT * FROM Categories");
            while (dataReader.Read())
            {
                Category category = new Category();
                category.Id = dataReader.GetInt32(0);
                category.CategoryName= dataReader.GetString(1);
                category.CategoryDescription = dataReader.GetString(2);
                listaobjetos.Add(category);
            }
            con.close();
            return listaobjetos;
        }

        /// <summary>  
        ///  Update Method(void) 
        /// </summary>  
        public static void edit(int id, string name, string description)
        {
            SqlCommand cmd;
            ConexionBD con = new ConexionBD();
            con.open();
            cmd = new SqlCommand("UPDATE Categories SET CategoryName=@category, Description=@description WHERE CategoryId=@id", con.con);
            cmd.Parameters.AddWithValue("@category", name);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.close();
        }

        /// <summary>  
        ///  Insert Method (void)  
        /// </summary>  
        public static void create(string name, string description)
        {
            SqlCommand cmd;
            ConexionBD con = new ConexionBD();
            con.open();
            cmd = new SqlCommand("insert into Categories(CategoryName, Description) values(@category, @description)", con.con);
            cmd.Parameters.AddWithValue("@category", name);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.ExecuteNonQuery();
            con.close();
        }

        /// <summary>  
        ///  Delete Method (void) 
        /// </summary>  
        public static void remove(int id)
        {
            ConexionBD con = new ConexionBD();
            con.executeNonQuery("DELETE FROM Categories WHERE CategoryID=" + id);
            con.close();
        }
    }
}