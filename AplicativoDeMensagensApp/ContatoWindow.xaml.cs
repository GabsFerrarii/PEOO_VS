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
    /// Lógica interna para ContatoWindow.xaml
    /// </summary>
    public partial class ContatoWindow : Window
    {
        public ContatoWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Contato c = new Contato();
            c.Id = int.Parse(txtId.Text);
            c.Nome = txtNome.Text;
            c.Email = txtEmail.Text;
            c.Numero = txtNumero.Text;
            NContato.Inserir(c);
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listContatos.ItemsSource = null;
            listContatos.ItemsSource = NContato.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Contato c = new Contato();
            c.Id = int.Parse(txtId.Text);
            c.Nome = txtNome.Text;
            c.Email = txtEmail.Text;
            c.Numero = txtNumero.Text;
            NContato.Atualizar(c);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Contato c = new Contato();
            c.Id = int.Parse(txtId.Text);
            NContato.Excluir(c);
            ListarClick(sender, e);
        }

        private void listContatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listContatos.SelectedItem != null)
            {
                Contato obj = (Contato)listContatos.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtNome.Text = obj.Nome;
                txtEmail.Text = obj.Email;
                txtNumero.Text = obj.Numero;
            }
        }
    }
}
