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
    /// Lógica interna para GrupoWindow.xaml
    /// </summary>
    public partial class GrupoWindow : Window
    {
        public GrupoWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Grupo g = new Grupo();
            g.Id = int.Parse(txtId.Text);
            g.Nome = txtNome.Text;
            g.Descricao = txtDesc.Text;
            NGrupo.Inserir(g);
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listGrupos.ItemsSource = null;
            listGrupos.ItemsSource = NGrupo.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Grupo g = new Grupo();
            g.Id = int.Parse(txtId.Text);
            g.Nome = txtNome.Text;
            g.Descricao = txtDesc.Text;
            NGrupo.Atualizar(g);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Grupo g = new Grupo();
            g.Id = int.Parse(txtId.Text);
            NGrupo.Excluir(g);
            ListarClick(sender, e);
        }

        private void listTurmas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listGrupos.SelectedItem != null)
            {
                Grupo obj = (Grupo)listGrupos.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtNome.Text = obj.Nome;
                txtDesc.Text = obj.Descricao;
            }
        }
    }
}
