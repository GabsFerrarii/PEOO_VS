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
    /// Lógica interna para List_MembrosWindow.xaml
    /// </summary>
    public partial class List_MembrosWindow : Window
    {
        public List_MembrosWindow()
        {
            InitializeComponent();
            listGrupos.ItemsSource = NGrupo.Listar();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            if (listGrupos.SelectedItem != null)
            {
                Grupo g = (Grupo)listGrupos.SelectedItem;
                listMembros.ItemsSource = null;
                listMembros.ItemsSource = NMembro.ListarMembros(g);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um grupo");
            }
        }

        private void AdminClick(object sender, RoutedEventArgs e)
        {
            if(listMembros.SelectedItem != null)
            {
                Membro m = (Membro)listMembros.SelectedItem;
                NMembro.TornarAdmin(m);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um membro");
            }
        }
    }
}
