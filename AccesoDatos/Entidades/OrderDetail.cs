using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploNorthWindEmpleados.Entidades
{
    class OrderDetail
    {

        public int Id { get; set; }

        public int IdProduct { get; set; }

        public int UnidPrice { get; set; }

        public int Quantity { get; set; }

        public int Discount { get; set; }

    }
}
