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
        public int anchura;
        public int altura;
        public Configuracion(int anchura, int altura)
        {
            InitializeComponent();
            this.altura = altura;
            this.anchura = anchura;

            AnchoTextBox.Text = anchura.ToString();
            AltutaTextBox.Text = altura.ToString();
        }

        private void AceptarClick(object sender, RoutedEventArgs e)
        {
            anchura = int.Parse(AnchoTextBox.Text);
            altura = int.Parse(AltutaTextBox.Text);

            DialogResult = true;
            Close();
        }
    }
}
