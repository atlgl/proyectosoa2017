using System;
using System.Windows.Forms;

namespace EjemploNorthWindEmpleados.Guis.OrderDetails
{
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();
            ViewWindowsOrderDetails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int OrderID = Convert.ToInt32(txtOrderID.Text);
            int ProductID = Convert.ToInt32(txtProductID.Text);
            double UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
            int Quantity = Convert.ToInt32(txtQuantity.Text);
            float Discount = Convert.ToSingle(txtDiscount.Text);

           int result =  AccesoDatos.OrdersDetails.create(OrderID, ProductID, UnitPrice, Quantity, Discount);
            if (result != 0)
            {
                MessageBox.Show("LA ORDEN CON EL ID: " + OrderID + " AH SIDO REGISTRADO");
                LimpiarCampos();
                ViewWindowsOrderDetails();
            }
            else
            {
                MessageBox.Show("ERROR AL INSERTAR LA ORDEN");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String ID = txtOrderID.Text;
           
            try
            {
                int OrderID = Convert.ToInt32(ID);
                AccesoDatos.OrdersDetails.remove(OrderID);
                MessageBox.Show("LA ORDEN CON EL ID: " + OrderID + " AH SIDO ELIMINADO");
                LimpiarCampos();
                ViewWindowsOrderDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR LA ORDEN, ELIJA UN DATO");
            }

        }


       public void LimpiarCampos()
        {
            txtOrderID.Text = " ";
            txtProductID.Text = " ";
            txtUnitPrice.Text = " ";
            txtQuantity.Text = " ";
            txtDiscount.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
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
                ViewWindowsOrderDetails();
            }
            catch(Exception es)
            {
                MessageBox.Show("NO PUEDE MODIFICAR EL ProductID E INGRESE NUMEROS ENTEROS (NO DECIMALES)");
            }

        }

        public void ViewWindowsOrderDetails()
        {
            WindowsOrderDetails.DataSource = AccesoDatos.OrdersDetails.getAll();
        }

        private void WindowsOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderID.Text = WindowsOrderDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProductID.Text = WindowsOrderDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtUnitPrice.Text = WindowsOrderDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantity.Text = WindowsOrderDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDiscount.Text = WindowsOrderDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
