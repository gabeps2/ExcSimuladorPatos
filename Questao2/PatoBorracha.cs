using System;

namespace ExcSimuladorPatos.Questao2
{
    class PatoBorracha:Pato
    {
        public override void grasna()
        {
            System.Console.WriteLine("Não grasna");
        }
        public override void nada()
        {
            System.Console.WriteLine("Não Nada");
        }
        public override void voa()
        {
            System.Console.WriteLine("Não voa");
        }
        public override void boia()
        {
            System.Console.WriteLine("Boia");
        }
        public override void flexivel()
        {
            System.Console.WriteLine("É flexivel");
        }
    }
}