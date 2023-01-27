using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AplicativoDeMensagensApp
{
    static class NContato
    {
        private static List<Contato> contatos = new List<Contato>();
        public static void Inserir(Contato c)
        {
            Abrir();
            int id = 0;
            foreach (Contato obj in contatos)
            {
                if (obj.Id > id) id = obj.Id;
            }
            c.Id = id + 1;
            contatos.Add(c);
            Salvar();
        }
        public static List<Contato> Listar()
        {
            Abrir();
            return contatos;
        }
        public static Contato Listar(int id)
        {
            foreach (Contato c in contatos)
            {
                if (c.Id == id) return c;
            }
            return null;
        }
        public static void Excluir(Contato c)
        {
            Abrir();
            Contato x = null;
            foreach (Contato obj in contatos)
            {
                if (obj.Id == c.Id) x = obj;
            }
            if (x != null) contatos.Remove(x);
            Salvar();
        }
        public static void Atualizar(Contato c)
        {
            Abrir();
            Contato obj = Listar(c.Id);
            obj.Nome = c.Nome;
            obj.Numero = c.Numero;
            obj.Email = c.Email;
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Contato>));
                f = new StreamReader("./contatos.xml", false);
                contatos = (List<Contato>)xml.Deserialize(f);
            }
            catch
            {
                contatos = new List<Contato>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Contato>));
            StreamWriter f = new StreamWriter("./contatos.xml", false);
            xml.Serialize(f, contatos);
            f.Close();
        }
    }
}
