using System;
using ExcSimuladorPatos.Questao1;
using ExcSimuladorPatos.Questao2;
using ExcSimuladorPatos.Questao3;

namespace ExcSimuladorPatos
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Questão 1: ");
            TesteQ1.testar();
            System.Console.WriteLine("----------------------------------------------------------------");
            System.Console.WriteLine("\nQuestão 2: ");
            TesteQ2.testar();
            System.Console.WriteLine("----------------------------------------------------------------");
            System.Console.WriteLine("\nQuestão 3: ");
            TesteQ3.testar();
            Console.ReadKey();
        }
    }
}
