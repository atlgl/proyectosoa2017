using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using EjemploNorthWindEmpleados.AccesoDatos;
using EjemploNorthWindEmpleados.Entidades;

namespace PruebaWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Employees> getAll()
        {
            //List<Employees> lista = new List<Employees>();
            //lista.Add(new Employees() { EmployeeID = 1, FirstName = "Juanito" });
            //lista.Add(new Employees() { EmployeeID = 2, FirstName = "Maria" });
            List<Employee> lista = EjemploNorthWindEmpleados.AccesoDatos.Employees.getAll();
            List<Employees> lista2 = new List<Employees>();
            foreach (Employee item in lista)
            {
                lista2.Add(new Employees {EmployeeID=item.Id,FirstName=item.FirstName });
            }

            
            return lista2;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int multiplicacion(int a, int b)
        {
            return a * b;
        }

        public int sumar(int a, int b)
        {
            return a + b;
        }
    }
}
