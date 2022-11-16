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

namespace ParesImparesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Numeros n;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            n = new Numeros(int.Parse(txtI.Text), int.Parse(txtF.Text));
            n.Calcular(pCheck.IsChecked.Value, iCheck.IsChecked.Value);
        }
    }
}
