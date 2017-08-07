using System;
using System.Windows.Forms;
using EjemploNorthWindEmpleados.Guis.Employees;

namespace EjemploNorthWindEmpleados.Gui.Employees
{
    public partial class EmployeeWindow : Form
    {
        private int indexFromDataGrid = 0;
        public EmployeeWindow()
        {
            InitializeComponent();
        }

        private void Ventana2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            // dataGridView1.DataSource = AccesoDatos.Employees.getAll();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                } catch
                {
                    Console.WriteLine("Error");
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EmployeeEditSave nuevo = new EmployeeEditSave();
            nuevo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            // dataGridView1.DataSource = AccesoDatos.Employees.getAll();
        }
    }
}
