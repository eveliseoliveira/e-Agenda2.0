using EAgenda2._0.WinApp.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAgenda2._0.WinApp.Dominio;

namespace EAgenda2._0.WinApp
{
    public partial class AtualizacaoItensTarefa : Form
    {
        private readonly Tarefa tarefa;

        public AtualizacaoItensTarefa(Tarefa tarefa)
        {

            InitializeComponent();

            this.tarefa = tarefa;

            label_TituloTarefa.Text = tarefa.Titulo;

            CarregararItensTarefas(tarefa);
        }

        private void CarregararItensTarefas(Tarefa tarefa)
        {
            int i = 0;
            foreach (var item in tarefa.Itens)
            {
                list_ItensTarefa.Items.Add(item);

                if (item.Concluido)
                    list_ItensTarefa.SetItemChecked(i, true);

                i++;
            }
        }

        public List<ItemTarefa> ItensConcluidos
        {
            get
            {
                return list_ItensTarefa.CheckedItems
                    .Cast<ItemTarefa>()
                    .ToList();
            }
        }
        public List<ItemTarefa> ItensPendentes
        {
            get
            {
                return list_ItensTarefa.Items
                    .Cast<ItemTarefa>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
        }
    }
}
