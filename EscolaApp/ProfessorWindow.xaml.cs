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

namespace EscolaApp
{
    /// <summary>
    /// Lógica interna para ProfessorWindow.xaml
    /// </summary>
    public partial class ProfessorWindow : Window
    {
        public ProfessorWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Professor p = new Professor();
            p.Id = int.Parse(txtId.Text);
            p.Nome = txtNome.Text;
            p.Matricula = txtMatricula.Text;
            p.Area = txtArea.Text;
            NProfessor.Inserir(p);
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listProfessor.ItemsSource = null;
            listProfessor.ItemsSource = NProfessor.Listar();
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Professor p = new Professor();
            p.Id = int.Parse(txtId.Text);
            NProfessor.Excluir(p);
            ListarClick(sender, e);
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Professor p = new Professor();
            p.Id = int.Parse(txtId.Text);
            p.Nome = txtNome.Text;
            p.Matricula = txtMatricula.Text;
            p.Area = txtArea.Text;
            NProfessor.Atualizar(p);
            ListarClick(sender, e);
        }
    }
}
