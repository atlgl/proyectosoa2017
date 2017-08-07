using System;
using System.Data.SqlClient;
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
                "Data Source=DESKTOP-41IUBS2\\SQLEXPRESS;Initial Catalog=NORTHWND;" +
                "User ID=sa;Password=genexus";
            SqlConnection con = new SqlConnection(cadena);
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();  
        }
    }
}
