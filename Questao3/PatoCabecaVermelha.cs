using System;

namespace ExcSimuladorPatos.Questao3
{
    class PatoCabecaVermelha:Pato,IGrasna,INadar,iVoar
    {
        public virtual void grasna()
        {
            System.Console.WriteLine("Grasna");
        }
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