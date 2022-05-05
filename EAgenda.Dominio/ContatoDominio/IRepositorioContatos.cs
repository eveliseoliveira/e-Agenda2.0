using EAgenda2._0.WinApp;
using System.Collections.Generic;

namespace EAgenda.Infra.Arquivo
{
    public interface IRepositorioContatos
    {
        void Editar(Contato contato);
        void Excluir(Contato contato);
        void Inserir(Contato contato);
        List<Contato> SelecionarTodos();
    }
}