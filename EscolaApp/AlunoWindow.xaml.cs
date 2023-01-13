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
    /// Lógica interna para AlunoWindow.xaml
    /// </summary>
    public partial class AlunoWindow : Window
    {
        public AlunoWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Aluno a = new Aluno();
            a.Id = int.Parse(txtId.Text);
            a.Nome = txtNome.Text;
            a.Matricula = txtMatricula.Text;
            a.IdTurma = int.Parse(txtIdTurma.Text);
            a.Email = txtEmail.Text;
            NAluno.Inserir(a);
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listDiario.ItemsSource = null;
            listDiario.ItemsSource = NAluno.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Aluno a = new Aluno();
            a.Id = int.Parse(txtId.Text);
            a.Nome = txtNome.Text;
            a.Matricula = txtMatricula.Text;
            a.IdTurma = int.Parse(txtIdTurma.Text);
            NAluno.Atualizar(a);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Aluno a = new Aluno();
            a.Id = int.Parse(txtId.Text);
            NAluno.Excluir(a);
            ListarClick(sender, e);
        }
    }
}
