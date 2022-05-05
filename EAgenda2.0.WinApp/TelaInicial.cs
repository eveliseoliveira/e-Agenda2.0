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
using EAgenda2._0.WinApp.ModuloCompromisso;

namespace EAgenda2._0.WinApp
{
    public partial class TelaInicial : System.Windows.Forms.Form
    {
        RepositorioContatoEmArquivo repositorioContato;
        RepositorioCompromissoEmArquivo repositorioCompromisso;

        public TelaInicial()
        {
            repositorioContato = new RepositorioContatoEmArquivo();
            repositorioCompromisso = new RepositorioCompromissoEmArquivo();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Tarefas_Click(object sender, EventArgs e)
        {
            TelaCadastroTarefa tela = new TelaCadastroTarefa();

            tela.ShowDialog();
        }

        private void btn_Contatos_Click(object sender, EventArgs e)
        {
            TelaCadastroContatos tela = new TelaCadastroContatos(repositorioContato);

            tela.ShowDialog();
        }

        private void btn_Compromissos_Click(object sender, EventArgs e)
        {
            TelaCadastroCompromissos tela = new TelaCadastroCompromissos(repositorioCompromisso);

            tela.ShowDialog();
        }
    }
}
