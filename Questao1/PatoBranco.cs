using System;

namespace ExcSimuladorPatos.Questao1
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
    }
}