using EAgenda.Dominio.CompromissoDominio;
using System.Collections.Generic;

namespace EAgenda.Infra.Arquivo
{
    public interface IRepositorioCompromisso
    { 
        void Inserir(Compromisso compromisso);    
        void Editar(Compromisso compromisso);
        void Excluir(Compromisso compromisso);
        List<Compromisso> SelecionarTodos();
    }
}