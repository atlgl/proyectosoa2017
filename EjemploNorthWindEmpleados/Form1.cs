using EjemploNorthWindEmpleados.Gui.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploNorthWindEmpleados.Guis.shippers;




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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebServicePrueba.Service1Client c = new WebServicePrueba.Service1Client();
            int res=c.sumar(10, 10);
            WebServicePrueba.Employees[] lista = c.getAll();

            dataGridView1.DataSource = lista;

            MessageBox.Show("Resultado:." + res);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShipprsFormDll ventanita = new ShipprsFormDll();
            ventanita.Show();

        }

        private void dllEFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consumir_WFC tanita = new Consumir_WFC();
            tanita.Show();

        }

        private void shipperDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataset ventana = new FormDataset();
            ventana.Show();
        }
    }
}
