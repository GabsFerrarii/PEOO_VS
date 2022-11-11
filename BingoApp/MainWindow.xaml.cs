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

namespace BingoApp
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txt1.Text = slider.Value.ToString();
        }
        private Bingo b;

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            b = new Bingo();
            b.Iniciar(int.Parse(txt1.Text));
            btnIniciar.IsEnabled = false;
            btnSortear.IsEnabled = true;
            txt2.Clear();
            txtSorteados.Clear();
        }

        private void btnSortear_Click(object sender, RoutedEventArgs e)
        {
            int x = b.Sortear();
            if(x == -1)
            {
                txt2.Text = "Fim";
                btnIniciar.IsEnabled = true;
                btnSortear.IsEnabled = false;
            }
        }
    }
}
