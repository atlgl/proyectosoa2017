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
    public partial class Consumir_WFC : Form
    {
        Ship.Service1Client c = new Ship.Service1Client();
        public Consumir_WFC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int anInteger;
            anInteger = Convert.ToInt32(textBox2.Text);
            anInteger = int.Parse(textBox2.Text);

            int par;
            par = Convert.ToInt32(textBox3.Text);
            par = int.Parse(textBox3.Text);
            int res = c.sumar(anInteger, par);
            

            MessageBox.Show("Resultado suma:." + res);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int anInteger;
            anInteger = Convert.ToInt32(textBox2.Text);
            anInteger = int.Parse(textBox2.Text);

            int par;
            par = Convert.ToInt32(textBox3.Text);
            par = int.Parse(textBox3.Text);
            
            int res3 = c.multiplicacion(anInteger, par);
            MessageBox.Show("Resultado Mutiplicación:." + res3);
        }
    }
}
