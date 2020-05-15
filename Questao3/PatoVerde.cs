using System;

namespace ExcSimuladorPatos.Questao3
{
    class PatoVerde:Pato,IGrasna,INadar
    {
        public virtual void grasna()
        {
            System.Console.WriteLine("Grasna");
        }
        public virtual void nada()
        {
            System.Console.WriteLine("Nada");
        }
    }
}