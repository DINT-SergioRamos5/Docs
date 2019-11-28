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

namespace Docs
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int anchura;
        private int altura;
        public MainWindow()
        {
            InitializeComponent();
            altura = 600;
            anchura = 500;
        }

        private void NuevoDocumentoClick(object sender, RoutedEventArgs e)
        {
            NuevoDocumento editor = new NuevoDocumento();
            editor.Owner = this;
            editor.Title = "Documento" + OwnedWindows.Count;
            editor.Width = anchura;
            editor.Height = altura;
            editor.Show();
        }

        private void ConfiguracionClick(object sender, RoutedEventArgs e)
        {
            Configuracion configuracion = new Configuracion(anchura, altura);
            configuracion.Owner = this;
            configuracion.Title = "Configuración";

            if (configuracion.ShowDialog() == true)
            {
                anchura = configuracion.anchura;
                altura = configuracion.altura;
            }
        }
    }
}
