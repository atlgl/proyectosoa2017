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
            String consulta = "INSERT INTO Employees (firstname,lastname,title) VALUES('"+txtfn.Text+"','"+txtlastname.Text+"','"+txttitle.Text+"')";
            String cadena =
                "Data Source=DESKTOP-C248MND;Initial Catalog=Northwind;" +
                "User ID=sa;Password=sa123";
            SqlConnection con = new SqlConnection(cadena);
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();

            this.Close();
            
        }
    }
}
