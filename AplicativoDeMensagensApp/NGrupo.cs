using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AplicativoDeMensagensApp
{
    static class NGrupo
    {
        private static List<Grupo> grupos = new List<Grupo>();
        public static void Inserir(Grupo g)
        {
            Abrir();
            int id = 0;
            foreach(Grupo obj in grupos)
            {
                if (obj.Id > id) id = obj.Id;
            }
            g.Id = id + 1;
            grupos.Add(g);
            Salvar();
        }
        public static List<Grupo> Listar()
        {
            Abrir();
            return grupos;
        }
        public static Grupo Listar(int id)
        {
            foreach(Grupo g in grupos)
            {
                if (g.Id == id) return g;
            }
            return null;
        }
        public static /*List<Membro>*/ void ListarMembros(Grupo g)
        {

        }
        public static void Excluir(Grupo g)
        {
            Abrir();
            Grupo x = null;
            foreach(Grupo obj in grupos)
            {
                if (obj.Id == g.Id) x = obj;
            }
            if (x != null) grupos.Remove(x);
            Salvar();
        }
        public static void Atualizar(Grupo g)
        {
            Abrir();
            Grupo obj = Listar(g.Id);
            obj.Nome = g.Nome;
            obj.Descricao = g.Descricao;
            Salvar();
        }
        public static void CadastrarContato(Contato c, Grupo g)
        {

        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Grupo>));
                f = new StreamReader("./grupos.xml", false);
                grupos = (List<Grupo>)xml.Deserialize(f);
            }
            catch
            {
                grupos = new List<Grupo>();
            }
            if (f != null) f.Close();

        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Grupo>));
            StreamWriter f = new StreamWriter("./grupos.xml", false);
            xml.Serialize(f, grupos);
            f.Close();
        }
    }
}
