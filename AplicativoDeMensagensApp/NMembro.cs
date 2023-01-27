using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AplicativoDeMensagensApp
{
    static class NMembro
    {
        private static List<Membro> membros = new List<Membro>();
        public static void Inserir(Membro m)
        {
            Abrir();
            int id = 0;
            foreach (Membro obj in membros)
            {
                if (obj.Id > id) id = obj.Id;
            }
            m.Id = id + 1;
            membros.Add(m);
            Salvar();
        }
        public static List<Membro> Listar()
        {
            Abrir();
            return membros;
        }
        public static Membro Listar(int id)
        {
            foreach (Membro m in membros)
            {
                if (m.Id == id) return m;
            }
            return null;
        }
    
        public static /*List<Grupo>*/ void ListarGrupos(Contato c)
        {

        }
        public static void TornarAdmin(Membro m)
        {

        }
        public static void Excluir(Membro m)
        {
            Abrir();
            Membro x = null;
            foreach (Membro obj in membros)
            {
                if (obj.Id == m.Id) x = obj;
            }
            if (x != null) membros.Remove(x);
            Salvar();
        }
        public static void Atualizar(Membro m)
        {
            Abrir();
            Membro obj = Listar(m.Id);
            obj.Nome = m.Nome;
            obj.IdGrupo = m.IdGrupo;
            obj.IdContato = m.IdContato;
            obj.Admin = m.Admin;
            obj.Numero = m.Numero;
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Membro>));
                f = new StreamReader("./membros.xml", false);
                membros = (List<Membro>)xml.Deserialize(f);
            }
            catch
            {
                membros = new List<Membro>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Membro>));
            StreamWriter f = new StreamWriter("./membros.xml", false);
            xml.Serialize(f, membros);
            f.Close();
        }
    }
}
