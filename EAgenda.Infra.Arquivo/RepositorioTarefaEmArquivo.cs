using EAgenda2._0.WinApp.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace EAgenda2._0.WinApp.Infra
{
    public class RepositorioTarefaEmArquivo : IRepositorioTarefa
    {
        private const string arquivoTarefas = @"C:\Users\SAMSUNG\Documents\Visual Studio\EAgendaDois.bin";
        private int contador = 0;
        private List<Tarefa> tarefas;

        public RepositorioTarefaEmArquivo()
        {
            tarefas = CarregarTarefasDoArquivo();

            if (tarefas.Count > 0)
                contador = tarefas.Max(x => x.Numero);
        }

        public List<Tarefa> SelecionarTodos()
        {
            return tarefas;
        }

        public void Inserir(Tarefa novaTarefa)
        {
            novaTarefa.Numero = ++contador;
            tarefas.Add(novaTarefa);

            GravarTarefasEmArquivo();
        }

        public void Editar(Tarefa tarefa)
        {
            foreach (var item in tarefas)
            {
                if (item.Numero == tarefa.Numero)
                {
                    item.Titulo = tarefa.Titulo;
                    item.Prioridade = tarefa.Prioridade;
                    break;
                }
            }
            GravarTarefasEmArquivo();
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);

            GravarTarefasEmArquivo();
        }

        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach (var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }
            GravarTarefasEmArquivo();
        }

        public void AtualizarItens(Tarefa tarefaSelecionada, List<ItemTarefa>
            itensConcluidos, List<ItemTarefa> itensPendentes)
        {
            foreach (var item in itensConcluidos)
            {
                tarefaSelecionada.ConcluirItem(item);
            }
            foreach (var item in itensPendentes)
            {
                tarefaSelecionada.MarcarPendente(item);
            }
            GravarTarefasEmArquivo();
        }

        private void GravarTarefasEmArquivo()
        {
            BinaryFormatter serealizador = new BinaryFormatter();

            MemoryStream ms = new MemoryStream();

            serealizador.Serialize(ms, tarefas);

            byte[] bytes = ms.ToArray();

            File.WriteAllBytes(arquivoTarefas, bytes);
        }

        private List<Tarefa> CarregarTarefasDoArquivo()
        {
            if (File.Exists(arquivoTarefas) == false)
                return new List<Tarefa>();

            BinaryFormatter serealizador = new BinaryFormatter();

            byte[] bytes = File.ReadAllBytes(arquivoTarefas);

            MemoryStream ms = new MemoryStream(bytes);

            return (List<Tarefa>)serealizador.Deserialize(ms);
        }

        public List<Tarefa> SelecionarTarefasConcluidas()
        {
            return tarefas.Where(x => x.CalcularPercentualConcluido() == 100).ToList();
        }

        public List<Tarefa> SelecionarTarefasPendentes()
        {
            return tarefas.Where(x => x.CalcularPercentualConcluido() < 100).ToList();
        }
    }
}