using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using EAgenda.Dominio.CompromissoDominio;
using EAgenda2._0.WinApp.Dominio;

namespace EAgenda.Infra.Arquivo
{
    public class RepositorioCompromissoEmArquivo : IRepositorioCompromisso
    {
        private const string arquivoCompromissos = @"C:\Users\SAMSUNG\Documents\Visual Studio\EAgendaDois.bin";
        private int contador = 0;
        private List<Compromisso> compromissos;

        public RepositorioCompromissoEmArquivo()
        {
            compromissos = CarregarCompromissosDoArquivo();

            if (compromissos.Count > 0)
                contador = compromissos.Max(x => x.Id);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }

        public void Inserir(Compromisso novoCompromisso)
        {
            novoCompromisso.Id = ++contador;
            compromissos.Add(novoCompromisso);

            GravarCompromissosEmArquivo();
        }

        public void Editar(Compromisso compromisso)
        {
            foreach (var item in compromissos)
            {
                if (item.Id == compromisso.Id)
                {
                    item.Assunto = compromisso.Assunto;
                    item.Local = compromisso.Local;
                    item.HorarioInicial = compromisso.HorarioInicial;
                    item.HorarioFinal = compromisso.HorarioFinal;
                    item.dateTimePicker = compromisso.dateTimePicker;
                    break;
                }
            }
            GravarCompromissosEmArquivo();
        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);

            GravarCompromissosEmArquivo();
        }

        private void GravarCompromissosEmArquivo()
        {
            BinaryFormatter serealizador = new BinaryFormatter();

            MemoryStream ms = new MemoryStream();

            serealizador.Serialize(ms, compromissos);

            byte[] bytes = ms.ToArray();

            File.WriteAllBytes(arquivoCompromissos, bytes);
        }

        private List<Compromisso> CarregarCompromissosDoArquivo()
        {
            if (File.Exists(arquivoCompromissos) == false)
                return new List<Compromisso>();

            BinaryFormatter serealizador = new BinaryFormatter();

            byte[] bytes = File.ReadAllBytes(arquivoCompromissos);

            MemoryStream ms = new MemoryStream(bytes);

            return (List<Compromisso>)serealizador.Deserialize(ms);
        }
    }
}
