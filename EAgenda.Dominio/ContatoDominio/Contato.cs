using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAgenda2._0.WinApp
{
    [Serializable]
    public class Contato
    {
        public Contato()
        {

        }

        public Contato(int id, string nome, string email, string telefone, string empresa, string cargo) : this()
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Email: {Email}, Telefone: {Telefone}, Empresa: {Empresa}, Cargo: {Cargo}";
        }

        public string Validar()
        {

            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(Nome))
                sb.AppendLine("O nome do contato é obrigatório!");

            if (EmailEstaValido(ValidarEmail) == false)
                sb.AppendLine("Insira um endereço de email válido! (Ex: contato@gmail.com)");

            if (TelefoneEstaValido() == false)
                sb.AppendLine("O número precisa seguir um dos formatos: 99999-0000 ou 99999 0000 ou 999990000");

            if (string.IsNullOrEmpty(Empresa))
                sb.AppendLine("O nome da empresa é obrigatório!");

            if (string.IsNullOrEmpty(Cargo))
                sb.AppendLine("O nome do cargo é obrigatório!");

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }

        private bool EmailEstaValido(Func<bool> validacaoSelecionada)
        {
            bool emailEstaValido = validacaoSelecionada();

            return emailEstaValido;
        }

        private bool ValidarEmail()
        {
            bool emailEstaValido = false;
            if (Email == string.Empty)
            {
                return emailEstaValido;
            }
            
            return System.Net.Mail.MailAddress.TryCreate(Email, out _);
        }
        private bool TelefoneEstaValido()
        {
            bool telefoneEstaValido = false;

            string telefoneProcessado = Telefone.Replace("-", string.Empty)
                                                .Replace(" ", string.Empty);

            if (telefoneProcessado.Length < 9)
                return telefoneEstaValido;

            telefoneEstaValido = System.Text.RegularExpressions.Regex.IsMatch(telefoneProcessado, @"^[0-9]*$");

            return telefoneEstaValido;
        }
    }
}
