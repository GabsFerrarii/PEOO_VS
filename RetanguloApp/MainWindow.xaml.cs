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

namespace RetanguloApp
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
            Retangulo retangulo = new Retangulo();
            retangulo.SetBase(double.Parse(txt1.Text));
            retangulo.SetAltura(double.Parse(txt5.Text));
            txt3.Text = retangulo.CalcArea().ToString();
            txt4.Text = retangulo.CalcDiagonal().ToString();
        }
    }
}
