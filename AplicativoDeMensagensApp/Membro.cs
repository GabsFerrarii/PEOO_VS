using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoDeMensagensApp
{
    public class Membro
    {
        public int Id { get; set; }
        public int IdContato { get; set; }
        public int IdGrupo { get; set; }
        public bool Admin { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Nome} - {Numero} - Admin: {Admin}";
        }
    }
}
