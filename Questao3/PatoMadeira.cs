using System;

namespace ExcSimuladorPatos.Questao3
{
    class PatoMadeira:Pato,IBoiar
    {
        public virtual void boia()
        {
            System.Console.WriteLine("Boia");
        }
    }
}