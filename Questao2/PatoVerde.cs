using System;

namespace ExcSimuladorPatos.Questao2
{
    class PatoVerde:Pato
    {
        public override void grasna()
        {
            System.Console.WriteLine("Grasna");
        }
        public override void nada()
        {
            System.Console.WriteLine("Nada");
        }
        public override void voa()
        {
            System.Console.WriteLine("Não voa");
        }
        public override void boia()
        {
            System.Console.WriteLine("Não boia");
        }
        public override void flexivel()
        {
            System.Console.WriteLine("Não é flexivel");
        }
    }
}