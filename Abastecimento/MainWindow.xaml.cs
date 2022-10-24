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

namespace AbastecimentoApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Abastecimento abastecimento = new Abastecimento();
            abastecimento.SetKmRodados(double.Parse(txt1.Text));
            abastecimento.SetValorPago(double.Parse(txt2.Text));
            abastecimento.SetValorLitro(double.Parse(txt3.Text));
            txt4.Text = abastecimento.MediaKmLitro().ToString();
            txt5.Text = abastecimento.MediaReaisKm().ToString();
        }
    }
}
