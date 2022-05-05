using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EAgenda2._0.WinApp.Dominio;
using EAgenda2._0.WinApp.Infra;

namespace EAgenda2._0.WinApp
{
    public partial class TelaCadastroTarefa : Form
    {
        private IRepositorioTarefa repositorioTarefa;
        public TelaCadastroTarefa()
        {
            repositorioTarefa = new RepositorioTarefaEmArquivo();
            InitializeComponent();
            CarregarTarefa();
        }
        private void CarregarTarefa()
        {
            List<Tarefa> tarefasConcluidas = repositorioTarefa.SelecionarTarefasConcluidas();

            listTarefasConcluidas.Items.Clear();

            foreach (Tarefa t in tarefasConcluidas)
            {
                    listTarefasConcluidas.Items.Add(t);
            }

            List<Tarefa> tarefasPendentes = repositorioTarefa.SelecionarTarefasPendentes();

            listTarefasPendentes.Items.Clear();

            foreach (Tarefa t in tarefasPendentes)
            {
                listTarefasPendentes.Items.Add(t);
            }
        }
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            CadastroTarefa tela = new CadastroTarefa();

            tela.Tarefa = new Tarefa();

            DialogResult resultado = tela.ShowDialog();

            if(resultado == DialogResult.OK)
                repositorioTarefa.Inserir(tela.Tarefa);

            CarregarTarefa();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            var tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;
            
            if (tarefaSelecionada == null)
            {
                MessageBox.Show("É necessário selecionar uma tarefa primeiro", "Editar Tarefa",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroTarefa tela = new CadastroTarefa();

            tela.Tarefa = tarefaSelecionada;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Editar(tela.Tarefa);
                
                CarregarTarefa();
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("É necessário selecionar uma tarefa primeiro", "Exclusão de Tarefa",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja excluir a tarefa?","Exclusão de Tarefa",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefaSelecionada);

                CarregarTarefa();
            }
        }

        private void btn_AdicionarItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("É necessário selecionar uma tarefa primeiro", "Edição de Tarefas",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

                CadastroItensTarefa tela = new CadastroItensTarefa(tarefaSelecionada);
                
            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itens = tela.ItensAdicionados;

                repositorioTarefa.AdicionarItens(tarefaSelecionada, itens);

                CarregarTarefa();
            }
        }

        private void btn_AtualizarItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("É necessário selecionar uma tarefa primeiro", "Edição de Tarefas",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            AtualizacaoItensTarefa tela = new AtualizacaoItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itensConcluidos = tela.ItensConcluidos;

                List<ItemTarefa> itensPendentes = tela.ItensPendentes;

                repositorioTarefa.AtualizarItens(tarefaSelecionada, itensConcluidos, itensPendentes);

                CarregarTarefa();

            }
        }

        private void TelaCadastroTarefa_Load(object sender, EventArgs e)
        {

        }

    }
}
