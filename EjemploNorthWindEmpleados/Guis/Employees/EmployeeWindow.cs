using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using EjemploNorthWindEmpleados.Guis.Employees;

namespace EjemploNorthWindEmpleados.Gui.Employees
{
    public partial class EmployeeWindow : Form
    {
        public EmployeeWindow()
        {
            InitializeComponent();
        }

        private void Ventana2_Load(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = AccesoDatos.Employees.getAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeEditSave nuevo = new EmployeeEditSave();
            nuevo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
