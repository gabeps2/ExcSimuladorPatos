using System;

namespace ExcSimuladorPatos.Questao2
{
    abstract class Pato 
    {
        abstract public void grasna();
        abstract public void nada();
        abstract public void voa();
        abstract public void boia();
        abstract public void flexivel();
        public void mostra()
        {
            Console.WriteLine(this.ToString());
        }

        
        

    }
}
