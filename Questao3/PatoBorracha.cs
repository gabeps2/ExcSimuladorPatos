using System;

namespace ExcSimuladorPatos.Questao3
{
    class PatoBorracha:Pato,IBoiar,IFlexivel
    {
        public virtual void boia()
        {
            System.Console.WriteLine("Boia");
        }
        public virtual void flexivel()
        {
            System.Console.WriteLine("É flexivel");
        }
    }
}