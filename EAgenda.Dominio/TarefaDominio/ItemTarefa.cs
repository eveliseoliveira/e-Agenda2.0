using System;

namespace EAgenda2._0.WinApp.Dominio
{
    [Serializable]
    public class ItemTarefa
    {
        public string Titulo { get; set; }
        public bool Concluido { get; private set; }

        public override string ToString()
        {
            return Titulo;
        }

        public void Concluir()
        {
            Concluido = true;
        }

        public void MarcarPendente()
        {
            Concluido = false;
        }
    }
}