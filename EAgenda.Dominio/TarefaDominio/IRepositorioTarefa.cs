﻿using EAgenda2._0.WinApp.Dominio;
using System.Collections.Generic;

namespace EAgenda2._0.WinApp.Dominio
{
    public interface IRepositorioTarefa
    {
        void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens);
        void AtualizarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes);
        void Editar(Tarefa tarefa);
        void Excluir(Tarefa tarefa);
        void Inserir(Tarefa novaTarefa);
        List<Tarefa> SelecionarTodos();
        List<Tarefa> SelecionarTarefasConcluidas();
        List<Tarefa> SelecionarTarefasPendentes();
    }
}