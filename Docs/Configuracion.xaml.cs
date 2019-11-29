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
using System.Windows.Shapes;

namespace Docs
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        public int Anchura { get; set; }
        public int Altura { get; set; }
        public Configuracion(int anchura, int altura)
        {
            InitializeComponent();
            DataContext = this;
            Altura = altura;
            Anchura = anchura;
            
        }

        private void AceptarClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;            
        }
    }
}
