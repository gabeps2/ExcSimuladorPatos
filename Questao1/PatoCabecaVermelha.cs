using System;

namespace ExcSimuladorPatos.Questao1
{
    class PatoCabecaVermelha:Pato
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
            System.Console.WriteLine("Voa");
        }

    }
}