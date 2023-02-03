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

namespace AplicativoDeMensagensApp
{
    /// <summary>
    /// Lógica interna para List_GruposWindow.xaml
    /// </summary>
    public partial class List_GruposWindow : Window
    {
        public List_GruposWindow()
        {
            InitializeComponent();
            listContatos.ItemsSource = NContato.Listar();
        }
        private void ListarClick(object sender, RoutedEventArgs e)
        {
            if(listContatos.SelectedItem != null)
            {
                Contato c = (Contato)listContatos.SelectedItem;
                listGrupos.ItemsSource = null;
                listGrupos.ItemsSource = NMembro.ListarGrupos(c);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um contato");
            }
        }
    }
}
