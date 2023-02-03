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
    /// Lógica interna para Add_ContatoWindow.xaml
    /// </summary>
    public partial class Add_ContatoWindow : Window
    {
        public Add_ContatoWindow()
        {
            InitializeComponent();
            
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listContatos.ItemsSource = null;
            listContatos.ItemsSource = NContato.Listar();
            listGrupos.ItemsSource = null;
            listGrupos.ItemsSource = NGrupo.Listar();
        }

        private void AdicionarClick(object sender, RoutedEventArgs e)
        {
            if(listContatos.SelectedItem != null && listGrupos.SelectedItem != null)
            {
                Grupo g = (Grupo)listGrupos.SelectedItem;
                Contato c = (Contato)listContatos.SelectedItem;
                NMembro.CadastrarContato(c, g);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um contato e um grupo");
            }
        }
    }
}
