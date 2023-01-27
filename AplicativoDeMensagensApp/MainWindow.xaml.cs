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

namespace AplicativoDeMensagensApp
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

        private void Grupo_Click(object sender, RoutedEventArgs e)
        {
            GrupoWindow w = new GrupoWindow();
            w.ShowDialog();
        }

        private void Contato_Click(object sender, RoutedEventArgs e)
        {
            ContatoWindow w = new ContatoWindow();
            w.ShowDialog();
        }

        private void AddContato_Click(object sender, RoutedEventArgs e)
        {
            Add_ContatoWindow w = new Add_ContatoWindow();
            w.ShowDialog();
        }

        private void ListMembros_Click(object sender, RoutedEventArgs e)
        {
            List_MembrosWindow w = new List_MembrosWindow();
            w.ShowDialog();
        }
    }
}
