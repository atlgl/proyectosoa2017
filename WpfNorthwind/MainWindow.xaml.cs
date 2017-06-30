using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using AccesoDatosDs;
using AccesoDatosEF;

namespace WpfNorthwind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.Loaded += DataGrid_Loaded;
            dataGrid1.Loaded += DataGrid1_Loaded; 
          
        }

        private void DataGrid1_Loaded(object sender, RoutedEventArgs e)
        {
            AccesoDatosEF.NorthwindEntities db = new NorthwindEntities();
            dataGrid1.ItemsSource = db.Shippers.ToList();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            AccesoDatosEF.NorthwindEntities db = new NorthwindEntities();
            
            dataGrid.ItemsSource = db.Employees.ToList();
            
            
            //          AccesoDatosDs.DataSetNorthWindTableAdapters.EmployeesTableAdapter tabla = new AccesoDatosDs.DataSetNorthWindTableAdapters.EmployeesTableAdapter();
            //        tabla.DeleteQuery(13);


            //      dataGrid.DataContext = tabla.GetData();

        }
    }
}
