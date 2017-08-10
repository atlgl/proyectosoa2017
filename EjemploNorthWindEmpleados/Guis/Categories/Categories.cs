using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EjemploNorthWindEmpleados.Guis.Categories
{
    public partial class Categories : Form
    {
        // ID to update and remove
        int ID = 0;
        
        // Constructor
        public Categories()
        {
            InitializeComponent();
            DisplayData();
        }

        // Insert
        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (tb_category_name.Text != "" && tb_category_description.Text != "")
            {
                AccesoDatos.Categories.create(tb_category_name.Text,tb_category_description.Text);
                MessageBox.Show("Insertado correctamente");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Por favor no dejes los campos vacios");
            }
        }

        // Update
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tb_category_name.Text != "" && tb_category_description.Text != "")
            {
                AccesoDatos.Categories.edit(ID,tb_category_name.Text,tb_category_description.Text);
                MessageBox.Show("Registro Actualizado");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Selecciona un registro para actualizar");
            }
        }

        // Remove
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                AccesoDatos.Categories.remove(ID);
                MessageBox.Show("Registro Eliminado!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Selecciona un registro para eliminar");
            }
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            dataGridView1.DataSource = AccesoDatos.Categories.getAll();
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
