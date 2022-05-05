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
using EAgenda2._0.WinApp.Infra;

namespace EAgenda2._0.WinApp
{
    public partial class CadastroTarefa : Form
    {
        private Tarefa tarefa;

        public CadastroTarefa()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set 
            {
                tarefa = value;
                txt_Numero.Text = value.Numero.ToString();
                txt_Titulo.Text = value.Titulo;
            }            
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            tarefa.Titulo = txt_Titulo.Text;

            if (rb_Alta.Checked)
                tarefa.Prioridade = rb_Alta.Text;
            
            if (rb_Normal.Checked)
                tarefa.Prioridade = rb_Normal.Text;
            
            if (rb_Baixa.Checked)
                tarefa.Prioridade = rb_Baixa.Text;
        }
    }
}
