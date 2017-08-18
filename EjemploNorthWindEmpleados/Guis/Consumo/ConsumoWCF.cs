using System;
using System.Windows.Forms;

namespace EjemploNorthWindEmpleados.Guis.Consumo
{
    public partial class ConsumoWCF : Form
    {
        WebServicePrueba.Service1Client cliente = new WebServicePrueba.Service1Client();
        int res = 0;
        public ConsumoWCF()
        {
            // TODO: Initialize webServiceClient
            InitializeComponent();
        }

        /// <summary>  
        ///  Suma Click event
        /// </summary>  
        private void btn_suma_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = Convert.ToString(cliente.sumar(int.Parse(num1.Text), int.Parse(num2.Text)));
        }

        /// <summary>  
        ///  Multiplicacion Click Event 
        /// </summary>  
        private void btn_multiplicacion_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = Convert.ToString(cliente.multiplicacion(int.Parse(num1.Text), int.Parse(num2.Text)));
        }
    }
}
