using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAgenda.Dominio.CompromissoDominio
{
    [Serializable]
    public class Compromisso
    {
        public Compromisso()
        {

        }

        public Compromisso(int id, string assunto, string local, string horarioInicial, string horarioFinal) : this()
        {
            Id = id;
            Assunto = assunto;
            Local = local;
            HorarioInicial = horarioInicial;
            HorarioFinal = horarioFinal;
        }

        public int Id { get; set; }
        public string Assunto { get; set; }
        public string Local { get; set; }
        public string HorarioInicial { get; set; }
        public string HorarioFinal { get; set; }
        public string dateTimePicker { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Assunto: {Assunto}, Local: {Local}, Data: {dateTimePicker}, Horario Inicial: {HorarioInicial}, Horario Final: {HorarioFinal}";
        }

        public string Validar()
        {

            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(Assunto))
                sb.AppendLine("O assunto do compromisso é obrigatório!");

            if (string.IsNullOrEmpty(Local))
                sb.AppendLine("O local do compromisso é obrigatório!");

            if (string.IsNullOrEmpty(dateTimePicker))
                sb.AppendLine("A data do compromisso é obrigatório!");

            if (dateTimePicker.Equals(DateTime.Now) == true)
                sb.AppendLine("A data do compromisso não pode ser antes da data atual!");

            if (HorarioEstaValido() == false)
                sb.AppendLine("O horário de início deve ser menor que o horário de término");

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }

        private bool HorarioEstaValido()
        {
            bool horarioEstaValido = false;

            string horarioInicialProcessado = HorarioInicial.Replace("-", string.Empty)
                                                .Replace(" ", string.Empty)
                                                .Replace(":", string.Empty);

            string horarioFinalProcessado = HorarioInicial.Replace("-", string.Empty)
                                                   .Replace(" ", string.Empty)
                                                   .Replace(":", string.Empty);

            if (horarioInicialProcessado.Length > horarioFinalProcessado.Length)
                return horarioEstaValido;

            horarioEstaValido = System.Text.RegularExpressions.Regex.IsMatch(horarioInicialProcessado, @"^[0-2359]*$");
            return horarioEstaValido;
        }
    }
}
