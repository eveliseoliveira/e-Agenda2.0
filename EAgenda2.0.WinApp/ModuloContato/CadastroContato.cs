using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAgenda2._0.WinApp.ModuloContato
{
    public partial class CadastroContato : Form
    {
        private Contato contato;
        public CadastroContato()
        {
            InitializeComponent();
        }
        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
                txt_Id.Text = value.Id.ToString();
                txt_Nome.Text = value.Nome;
                txt_Email.Text = value.Email;
                txt_Telefone.Text = value.Telefone;
                txt_Empresa.Text = value.Empresa;
                txt_Cargo.Text = value.Cargo;
            }
        }


        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            contato.Nome = txt_Nome.Text;
            contato.Email = txt_Email.Text;
            contato.Telefone = txt_Telefone.Text;
            contato.Empresa = txt_Empresa.Text;
            contato.Cargo = txt_Cargo.Text;
        }
    }
}
