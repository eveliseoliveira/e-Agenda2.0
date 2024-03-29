﻿using System;
using System.Collections.Generic;
using System.Linq;
using EAgenda2._0.WinApp.Dominio;


namespace EAgenda2._0.WinApp.Dominio
{
    [Serializable]
    public class Tarefa
    {
        private List<ItemTarefa> itens = new List<ItemTarefa>();
        public Tarefa()
        {
            DataCriacao = DateTime.Now;
        }

        public Tarefa(int n, string t, bool p) : this()
        {
            Numero = n;
            Titulo = t;
            Prioridade = p;
            DataConclusao = null;
        }

        public int Numero { get; set; }
        public string Titulo { get; set; }
        public object Prioridade { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public List<ItemTarefa> Itens { get { return itens; } }

        public override string ToString()
        {
            var percentual = CalcularPercentualConcluido();

            if(DataConclusao.HasValue)
                return $"Número: {Numero}, Título: {Titulo}, Prioriade: {Prioridade}, Percentual: {percentual}, " +
                    $"Concluída: {DataConclusao.Value.ToShortDateString()}";

            return $"Número: {Numero}, Título: {Titulo}, Prioriade: {Prioridade}, Percentual: {percentual}";
        }

        public void AdicionarItem(ItemTarefa item)
        {
            if(Itens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }

        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            var percentual = CalcularPercentualConcluido();

            if (percentual == 100)
                DataConclusao = DateTime.Now;
        }

        public void MarcarPendente(ItemTarefa item)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.MarcarPendente();
        }

        public decimal CalcularPercentualConcluido()
        {
            if (itens.Count == 0)
                return 0;

            int quantidadeConcluidas = itens.Count(x => x.Concluido);

            var percentualConcluido = (quantidadeConcluidas / (decimal)itens.Count()) * 100;

            return Math.Round(percentualConcluido, 2);
        }


    }
}