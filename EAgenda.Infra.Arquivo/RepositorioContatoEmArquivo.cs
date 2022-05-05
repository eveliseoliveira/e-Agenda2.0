using EAgenda2._0.WinApp;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace EAgenda.Infra.Arquivo
{
    public class RepositorioContatoEmArquivo : IRepositorioContatos
    {
        private const string arquivoContatos = @"C:\Users\SAMSUNG\Documents\Visual Studio\EAgendaDois.bin";
        private int contador = 0;
        private List<Contato> contatos;

        public RepositorioContatoEmArquivo()
        {
            contatos = CarregarContatosDoArquivo();

            if (contatos.Count > 0)
                contador = contatos.Max(x => x.Id);
        }

        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public void Inserir(Contato novoContato)
        {
            novoContato.Id = ++contador;
            contatos.Add(novoContato);

            GravarContatosEmArquivo();
        }

        public void Editar(Contato contato)
        {
            foreach (var item in contatos)
            {
                if (item.Id == contato.Id)
                {
                    item.Nome = contato.Nome;
                    item.Email = contato.Email;
                    item.Telefone = contato.Telefone;
                    item.Empresa = contato.Empresa;
                    item.Cargo = contato.Cargo;
                    break;
                }
            }
            GravarContatosEmArquivo();
        }

        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);

            GravarContatosEmArquivo();
        }

        private void GravarContatosEmArquivo()
        {
            BinaryFormatter serealizador = new BinaryFormatter();

            MemoryStream ms = new MemoryStream();

            serealizador.Serialize(ms, contatos);

            byte[] bytes = ms.ToArray();

            File.WriteAllBytes(arquivoContatos, bytes);
        }

        private List<Contato> CarregarContatosDoArquivo()
        {
            if (File.Exists(arquivoContatos) == false)
                return new List<Contato>();

            BinaryFormatter serealizador = new BinaryFormatter();

            byte[] bytes = File.ReadAllBytes(arquivoContatos);

            MemoryStream ms = new MemoryStream(bytes);

            return (List<Contato>)serealizador.Deserialize(ms);
        }
    }
}
