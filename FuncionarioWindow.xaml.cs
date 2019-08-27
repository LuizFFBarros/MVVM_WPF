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

namespace WPFMVVMCRUD
{
    /// <summary>
    /// Interaction logic for FuncionarioWindow.xaml
    /// </summary>
    public partial class FuncionarioWindow : Window
    {
        public FuncionarioWindow()
        {
            InitializeComponent(); SexoComboBox.ItemsSource = Enum.GetValues(typeof(Model.Sexo)).Cast<Model.Sexo>();
            EstadoCivilComboBox.ItemsSource = Enum.GetValues(typeof(Model.EstadoCivil)).Cast<Model.EstadoCivil>();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
