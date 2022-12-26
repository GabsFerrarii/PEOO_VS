using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaApp
{
    static class NTurma
    {
        private static List<Turma> turmas = new List<Turma>();
        public static void Inserir(Turma t)
        {
            turmas.Add(t);
        }
        public static List<Turma> Listar()
        {
            return turmas;
        }
        public static void Atualizar(Turma t)
        {
            foreach(Turma obj in turmas)
            {
                if(obj.Id == t.Id)
                {
                    obj.AnoLetivo = t.AnoLetivo;
                    obj.Curso = t.Curso;
                    obj.Descricao = t.Descricao;
                }
            }
        }
        public static void Excluir(Turma t)
        {
            Turma x = null;
            foreach(Turma obj in turmas)
            {
                if (obj.Id == t.Id) x = obj;
            }
            if (x != null) turmas.Remove(x);
        }
    }
}
