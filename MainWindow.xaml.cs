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

namespace erpweb.com.es
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            VersionAplicacion.Text = "Versión 1.0 - 2016";
            FechaSistema.Text = System.DateTime.Today.ToShortDateString();
        }

        private void MnSalir_Click(object sender, RoutedEventArgs e)
        {
            
            var resultado = MessageBox.Show("¿Estás seguro que quieres salir?",
                "salir del programa",MessageBoxButton.YesNo,MessageBoxImage.Warning);
            if (resultado==MessageBoxResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
