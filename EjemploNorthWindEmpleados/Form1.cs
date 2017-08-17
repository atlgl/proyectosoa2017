using EjemploNorthWindEmpleados.Gui.Employees;
using System;
using System.Windows.Forms;
using EjemploNorthWindEmpleados.Guis.OrderDetails;
using WpfNorthwind;

namespace EjemploNorthWindEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        /*private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
            try
            {
                WindowsEmpoyeeView();//this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            }
          catch(Exception ex)
            {

            }


        }*/

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void conexionBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeWindow ventanita = new EmployeeWindow();
            ventanita.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebServicePrueba.Service1Client c = new WebServicePrueba.Service1Client();
            int res=c.sumar(10, 10);
            WebServicePrueba.Employees[] lista = c.getAll();

            MessageBox.Show("Resultado:." + res);
        }

        private void ordersDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDetails OrderDetailsWindows = new OrderDetails();
            OrderDetailsWindows.Show();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDetailsDS orderDetailsDS = new OrderDetailsDS();
            orderDetailsDS.Show();
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet1.Customers);

        }

        private void orderDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainWindow OrdersDetailsEF = new MainWindow();
            
        }
    }
}
