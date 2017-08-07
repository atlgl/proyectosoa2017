using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EjemploNorthWindEmpleados.Guis.Categories
{
    public partial class Categories : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-41IUBS2\\SQLEXPRESS;" +
            "Initial Catalog=NORTHWND;" +
            "User ID=sa;Password=genexus");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        // ID para actualizar y eliminar
        int ID = 0;

        public Categories()
        {
            InitializeComponent();
            DisplayData();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (tb_category_name.Text != "" && tb_category_description.Text != "")
            {
                cmd = new SqlCommand("insert into Categories(CategoryName,Description) values(@category,@description)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@category", tb_category_name.Text);
                cmd.Parameters.AddWithValue("@description", tb_category_description.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insertado correctamente");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Por favor no dejes los campos vacios");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tb_category_name.Text != "" && tb_category_description.Text != "")
            {
                cmd = new SqlCommand("update Categories set CategoryName=@category,Description=@description where CategoryID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@category", tb_category_name.Text);
                cmd.Parameters.AddWithValue("@description", tb_category_description.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Selecciona un registro para actualizar");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete Categories where CategoryID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro Eliminado!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Categories", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //Clear Data de TextBox
        private void ClearData()
        {
            tb_category_name.Text = "";
            tb_category_description.Text = "";
            ID = 0;
        }

        //dataGridView1 RowHeaderMouseClick Event  
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tb_category_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_category_description.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
