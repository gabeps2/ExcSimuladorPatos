using System;

namespace ExcSimuladorPatos.Questao1
{
    public class TesteQ1
    {
        static public void testar()
        {
            PatoCabecaVermelha novoPatoCabecaVermelha = new PatoCabecaVermelha();
            PatoBranco novoPatoBranco = new PatoBranco();
            PatoVerde novoPatoVerde = new PatoVerde();

            System.Console.WriteLine("\nPato Cabeça Vermelha: ");
            novoPatoCabecaVermelha.grasna();
            novoPatoCabecaVermelha.nada();
            novoPatoCabecaVermelha.voa();
            novoPatoCabecaVermelha.mostra();

            System.Console.WriteLine("\nPato Branco: ");
            novoPatoBranco.grasna();
            novoPatoBranco.nada();
            novoPatoBranco.voa();
            novoPatoBranco.mostra();

            System.Console.WriteLine("\nPato Verde: ");
            novoPatoVerde.grasna();
            novoPatoVerde.nada();
            novoPatoVerde.voa();
            novoPatoVerde.mostra();
        }
    }
}