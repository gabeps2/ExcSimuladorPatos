using System;

namespace ExcSimuladorPatos.Questao1
{
    abstract class Pato 
    {
        abstract public void grasna();
        
        abstract public void nada();
        
        abstract public void voa();
        public void mostra()
        {
            Console.WriteLine(this.ToString());
        }

        
        

    }
}
