using System;

namespace ExcSimuladorPatos.Questao2
{
    class PatoBranco:Pato
    {
        public override void grasna()
        {
            System.Console.WriteLine("Não grasna");
        }
        public override void nada()
        {
            System.Console.WriteLine("Nada");
        }
        public override void voa()
        {
            System.Console.WriteLine("Voa");
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