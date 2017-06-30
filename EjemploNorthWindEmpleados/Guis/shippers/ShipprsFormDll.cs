using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploNorthWindEmpleados.Guis.shippers
{
    public partial class ShipprsFormDll : Form
    {
        int ID = 0;
        public ShipprsFormDll()
        {
            InitializeComponent();
            DisplayData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                AccesoDatos.Shippers.edit(ID, textBox2.Text, textBox3.Text);
                MessageBox.Show("Registro Actualizado");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Selecciona un registro para actualizar");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox2.Text != "")
            {
                AccesoDatos.Shippers.create(textBox2.Text, textBox3.Text);
                MessageBox.Show("Registro Insertados");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Selecciona un registro para actualizar");
            }
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            dataGridView1.DataSource = AccesoDatos.Shippers.getAll();
        }

        //Clear Data de TextBox
        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            ID=0;
        }

        //dataGridView1 RowHeaderMouseClick Event  
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}

