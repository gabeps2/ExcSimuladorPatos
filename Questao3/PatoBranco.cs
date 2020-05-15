using System;

namespace ExcSimuladorPatos.Questao3
{
    class PatoBranco:Pato,INadar,iVoar
    {
        public virtual void nada()
        {
            System.Console.WriteLine("Nada");
        }
        public virtual void voa()
        {
            System.Console.WriteLine("Voa");
        }
    }
}