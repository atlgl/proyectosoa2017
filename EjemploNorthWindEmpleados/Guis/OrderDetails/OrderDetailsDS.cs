using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploNorthWindEmpleados.Guis.OrderDetails
{
    public partial class OrderDetailsDS : Form
    {
        public OrderDetailsDS()
        {
            InitializeComponent();
        }

        private void OrderDetailsDS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);

        }
        
        public void LimpiarCampos()
        {
            txtOrderID.Text = " ";
            txtProductID.Text = " ";
            txtUnitPrice.Text = " ";
            txtQuantity.Text = " ";
            txtDiscount.Text = " ";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProductID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtUnitPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDiscount.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int OrderID = Convert.ToInt32(txtOrderID.Text);
            int ProductID = Convert.ToInt32(txtProductID.Text);
            double UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
            int Quantity = Convert.ToInt32(txtQuantity.Text);
            float Discount = Convert.ToSingle(txtDiscount.Text);

            int result = AccesoDatos.OrdersDetails.create(OrderID, ProductID, UnitPrice, Quantity, Discount);
            if (result != 0)
            {
                MessageBox.Show("LA ORDEN CON EL ID: " + OrderID + " AH SIDO REGISTRADO");
                LimpiarCampos();
                this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
            }
            else
            {
                MessageBox.Show("ERROR AL INSERTAR LA ORDEN");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String ID = txtOrderID.Text;

            try
            {
                int OrderID = Convert.ToInt32(ID);
                AccesoDatos.OrdersDetails.remove(OrderID);
                MessageBox.Show("LA ORDEN CON EL ID: " + OrderID + " AH SIDO ELIMINADO");
                LimpiarCampos();
                this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR LA ORDEN, ELIJA UN DATO");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                int OrderID = Convert.ToInt32(txtOrderID.Text);
                int ProductID = Convert.ToInt32(txtProductID.Text);
                double UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
                int Quantity = Convert.ToInt32(txtQuantity.Text);
                float Discount = Convert.ToSingle(txtDiscount.Text);

                AccesoDatos.OrdersDetails.edit(OrderID, UnitPrice, Quantity, Discount);
                MessageBox.Show("LA ORDEN CON EL ID: " + OrderID + " AH SIDO MODIFICADO");
                LimpiarCampos();
                this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
            }
            catch (Exception es)
            {
                MessageBox.Show("NO PUEDE MODIFICAR EL ProductID E INGRESE NUMEROS ENTEROS (NO DECIMALES)");
            }
        }
    }
}