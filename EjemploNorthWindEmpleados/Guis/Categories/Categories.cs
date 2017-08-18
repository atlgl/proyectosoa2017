using System;
using System.Windows.Forms;

namespace EjemploNorthWindEmpleados.Guis.Categories
{
    public partial class Categories : Form
    {
        int ID = 0;
        int typeDataAcces;

        /// <summary>  
        ///  Constructor  
        /// </summary>  
        public Categories()
        {
            // TODO: Inicializa la GUI y alimenta el dataGridView con los datos
            InitializeComponent();
            DisplayData();
        }

        /// <summary>  
        ///  Insert Click Event 
        /// </summary>  
        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (tb_category_name.Text != "" && tb_category_description.Text != "")
            {
                if (typeDataAcces == 1)
                {
                    AccesoDatos.Categories.create(tb_category_name.Text, tb_category_description.Text);
                    MessageBox.Show("Insertado correctamente");
                    DisplayData();
                    ClearData();
                } else if (typeDataAcces == 2)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Por favor no dejes los campos vacios");
            }
        }

        /// <summary>  
        ///  Update Click Event  
        /// </summary>  
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tb_category_name.Text != "" && tb_category_description.Text != "")
            {
                if (typeDataAcces == 1)
                {
                    AccesoDatos.Categories.edit(ID, tb_category_name.Text, tb_category_description.Text);
                    MessageBox.Show("Registro Actualizado");
                    DisplayData();
                    ClearData();
                }                  
            }
            else
            {
                MessageBox.Show("Selecciona un registro para actualizar");
            }
        }

        /// <summary>  
        ///  Remove Click Event 
        /// </summary>  
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (typeDataAcces == 1)
                {
                    AccesoDatos.Categories.remove(ID);
                    MessageBox.Show("Registro Eliminado!");
                    DisplayData();
                    ClearData();
                }                
            }
            else
            {
                MessageBox.Show("Selecciona un registro para eliminar");
            }
        }

        /// <summary>  
        ///  Set Data to DataGridView  
        /// </summary>  
        private void DisplayData()
        {
            dataGridView1.DataSource = AccesoDatos.Categories.getAll();
        }

        /// <summary>  
        ///  Clear Data from editTexts 
        /// </summary>  
        private void ClearData()
        {
            tb_category_name.Text = "";
            tb_category_description.Text = "";
            ID = 0;
        }

        /// <summary>  
        ///  Change the Data access type
        /// <remarks>
        /// This function give you a flag
        /// to change the DLL from AccesoDatosg</remarks>
        /// </summary>  
        public int setTypeDataAccess(int typeData)
        {
            return typeDataAcces = typeData;
        }

        /// <summary>  
        ///  Row Header Mouse Click Event
        /// </summary>  
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tb_category_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_category_description.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
