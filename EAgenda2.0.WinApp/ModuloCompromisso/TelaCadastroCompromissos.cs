using EAgenda.Infra.Arquivo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EAgenda.Dominio.CompromissoDominio;

namespace EAgenda2._0.WinApp.ModuloCompromisso
{
    public partial class TelaCadastroCompromissos : Form
    {
        private RepositorioCompromissoEmArquivo repositorioCompromisso;
        public TelaCadastroCompromissos(RepositorioCompromissoEmArquivo repositorioCompromisso)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            InitializeComponent();
            CarregarCompromisso();
        }

        private void CarregarCompromisso()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            listCompromisso.Items.Clear();

            foreach (Compromisso id in compromissos)
            {
                listCompromisso.Items.Add(id);
            }
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            CadastroCompromisso tela = new CadastroCompromisso();

            tela.Compromisso = new Compromisso();

            DialogResult resultado = tela.ShowDialog();

            if (tela.Compromisso.Validar() != "REGISTRO_VALIDO")
            {
                MessageBox.Show(tela.Compromisso.Validar(), "Cadastro de Compromisso",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (resultado == DialogResult.OK)
                repositorioCompromisso.Inserir(tela.Compromisso);

            CarregarCompromisso();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            var compromissoSelecionado = (Compromisso)listCompromisso.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("É necessário selecionar um compromisso primeiro", "Editar Compromisso",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroCompromisso tela = new CadastroCompromisso();

            tela.Compromisso = compromissoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Editar(tela.Compromisso);

                CarregarCompromisso();
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromisso.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("É necessário selecionar um compromisso primeiro", "Exclusão de Compromisso",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja excluir a compromisso?", "Exclusão de Compromisso",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromissoSelecionado);

                CarregarCompromisso();
            }
        }
    }
}
