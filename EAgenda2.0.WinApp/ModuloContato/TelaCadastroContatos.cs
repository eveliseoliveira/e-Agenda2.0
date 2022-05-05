using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAgenda.Infra.Arquivo;
using EAgenda2._0.WinApp.Dominio;
using EAgenda2._0.WinApp.Infra;
using EAgenda2._0.WinApp.ModuloContato;

namespace EAgenda2._0.WinApp
{
    public partial class TelaCadastroContatos : Form
    {
        private RepositorioContatoEmArquivo repositorioContato;

        public TelaCadastroContatos(RepositorioContatoEmArquivo repositorioContato)
        {
            this.repositorioContato = repositorioContato;
            InitializeComponent();
            CarregarContato();
        }
        private void CarregarContato()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listContatos.Items.Clear();

            foreach (Contato id in contatos)
            {
                listContatos.Items.Add(id);
            }
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            CadastroContato tela = new CadastroContato();

            tela.Contato = new Contato();

            DialogResult resultado = tela.ShowDialog();
            
            if (tela.Contato.Validar() != "REGISTRO_VALIDO")
            {
                MessageBox.Show(tela.Contato.Validar(), "Cadastro de Contato",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            if (resultado == DialogResult.OK)
                repositorioContato.Inserir(tela.Contato);

            CarregarContato();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            var contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("É necessário selecionar um contato primeiro", "Editar Contato",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroContato tela = new CadastroContato();

            tela.Contato = contatoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Editar(tela.Contato);

                CarregarContato();
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("É necessário selecionar um contato primeiro", "Exclusão de Contato",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja excluir o contato?", "Exclusão de Contato",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Excluir(contatoSelecionado);

                CarregarContato();
            }
        }
    }
}
