using EjemploNorthWindEmpleados.Gui.Employees;
using EjemploNorthWindEmpleados.Guis.Categories;
using EjemploNorthWindEmpleados.Guis.Consumo;
using System;
using System.Windows.Forms;

namespace EjemploNorthWindEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void conexionBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // NOTHING
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebServicePrueba.Service1Client c = new WebServicePrueba.Service1Client();
            int res=c.sumar(10, 10);
            WebServicePrueba.Employees[] lista = c.getAll();

            dataGridView1.DataSource = lista;

            MessageBox.Show("Resultado:." + res);
        }

        private void conexionDBDatasetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add my own windowform from table
            Categories ventana = new Categories();
            ventana.setTypeDataAccess(1);
            ventana.Show();
        }

        private void employeesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeWindow ventanita = new EmployeeWindow();
            ventanita.Show();
        }

        private void categoriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Categories ventana = new Categories();
            ventana.setTypeDataAccess(2);
            ventana.Show();
        }

        private void consumoWCFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsumoWCF ventana = new ConsumoWCF();
            ventana.Show();
        }
    }
}
