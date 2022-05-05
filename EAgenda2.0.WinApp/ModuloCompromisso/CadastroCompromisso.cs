using EAgenda.Dominio.CompromissoDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAgenda2._0.WinApp.ModuloCompromisso
{
    public partial class CadastroCompromisso : Form
    {
        private Compromisso compromisso;
        public CadastroCompromisso()
        {
            InitializeComponent();
        }

        public Compromisso Compromisso
        {
            get
            {
                return compromisso;
            }
            set
            {
                compromisso = value;
                txt_Id.Text = value.Id.ToString();
                txt_Assunto.Text = value.Assunto;
                txt_Local.Text = value.Local;
                txt_HorarioInicio.Text = value.HorarioInicial;
                txt_HorarioTermino.Text = value.HorarioFinal;
                dateTimePicker.Text = value.dateTimePicker;
            }
        }



        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            compromisso.Assunto = txt_Assunto.Text;
            compromisso.Local = txt_Local.Text;
            compromisso.HorarioInicial = txt_HorarioInicio.Text;
            compromisso.HorarioFinal = txt_HorarioTermino.Text;
            compromisso.dateTimePicker = dateTimePicker.Text;
        }

        private void CadastroCompromisso_Load(object sender, EventArgs e)
        {

        }       

    }
}
