using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploNorthWindEmpleados.Guis.Employees
{
    public partial class EmployeeEditSave : Form
    {
        public EmployeeEditSave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String consulta = "INSERT INTO Employees (firstname,lastname,title) VALUES('" + txtfn.Text + "','" + txtlastname.Text + "','" + txttitle.Text + "')";
                String cadena =
                    "Data Source=DESKTOP-45F06AD\\Alfredo;Initial Catalog=Northwind;" +
                    "User ID=admin;Password=admin123";
                SqlConnection con = new SqlConnection(cadena);
                con.Open();
                SqlCommand cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(txtfn + " ah sido registrado");

            }
            catch(SqlException ex)
            {
                MessageBox.Show("ERROR EN: " + ex);
            }
            this.Close();
            
        }
    }
}
