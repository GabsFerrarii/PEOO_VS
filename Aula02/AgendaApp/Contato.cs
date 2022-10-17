using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp
{
    class Contato
    {
        private string nome, gomes, telefone;
        public Contato(string n, string g, string t)
        {
            nome = n;
            gomes = g;
            telefone = t;
        }
        public override string ToString()
        {
            return $"{nome} - {gomes} - {telefone}";
        }
    }
}
