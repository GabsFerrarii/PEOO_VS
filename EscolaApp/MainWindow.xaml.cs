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

namespace EscolaApp
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

        private void TurmaClick(object sender, RoutedEventArgs e)
        {
            TurmaWindow w = new TurmaWindow();
            w.ShowDialog();
        }

        private void AlunoClick(object sender, RoutedEventArgs e)
        {
            AlunoWindow w = new AlunoWindow();
            w.ShowDialog();
        }

        private void MatriculaClick(object sender, RoutedEventArgs e)
        {
            MatriculaWindow w = new MatriculaWindow();
            w.ShowDialog();
        }

        private void DiarioClick(object sender, RoutedEventArgs e)
        {
            DiarioWindow w = new DiarioWindow();
            w.ShowDialog();
        }

        private void ProfessorClick(object sender, RoutedEventArgs e)
        {
            ProfessorWindow w = new ProfessorWindow();
            w.ShowDialog();
        }

        private void CadastroClick(object sender, RoutedEventArgs e)
        {
            Cad_Prof_TurmaWindow w = new Cad_Prof_TurmaWindow();
            w.ShowDialog();
        }

        private void ListarTurmasClick(object sender, RoutedEventArgs e)
        {
            List_Turma_ProfWindow w = new List_Turma_ProfWindow();
            w.ShowDialog();
        }
    }
}
