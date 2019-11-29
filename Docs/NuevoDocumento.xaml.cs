using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica de interacción para NuevoDocumento.xaml
    /// </summary>
    public partial class NuevoDocumento : Window
    {
        public NuevoDocumento()
        {
            InitializeComponent();
        }



        private void GuardarClick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dialogo = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "Archivos de texto|*.txt",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (dialogo.ShowDialog() == true)
            {
                File.WriteAllText(dialogo.FileName, EditorTextBox.Text);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            MessageBoxResult message = MessageBox.Show("¿Estas seguro que quieres cerrar la ventana?", 
                "Aviso", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
            if (message == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
            }

        }
    }
}
