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
    public partial class FormDataset : Form
    {
        public FormDataset()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet2.Shippers' Puede moverla o quitarla según sea necesario.
            this.shippersTableAdapter.Fill(this.northwindDataSet2.Shippers);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet1.Suppliers' Puede moverla o quitarla según sea necesario.
            this.suppliersTableAdapter.Fill(this.northwindDataSet1.Suppliers);

        }
    }
}
