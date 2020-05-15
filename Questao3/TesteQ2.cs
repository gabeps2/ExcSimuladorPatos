using System;

namespace ExcSimuladorPatos.Questao3
{
    class TesteQ3
    {
        static public void testar()
        {
            PatoCabecaVermelha novoPatoCabecaVermelha = new PatoCabecaVermelha();
            PatoBranco novoPatoBranco = new PatoBranco();
            PatoVerde novoPatoVerde = new PatoVerde();
            PatoMadeira novoPatoMadeira = new PatoMadeira();
            PatoFerro novoPatoFerro = new PatoFerro();
            PatoBorracha novoPatoBorracha = new PatoBorracha();


            System.Console.WriteLine("\nPato Cabeça Vermelha: ");
            novoPatoCabecaVermelha.grasna();
            novoPatoCabecaVermelha.nada();
            novoPatoCabecaVermelha.voa();
            novoPatoCabecaVermelha.mostra();
            
            System.Console.WriteLine("\nPato Branco: ");
            novoPatoBranco.voa();
            novoPatoBranco.mostra();

            System.Console.WriteLine("\nPato Verde: ");
            novoPatoVerde.grasna();
            novoPatoVerde.nada();
            novoPatoVerde.mostra();

            System.Console.WriteLine("\nPato de Madeira: ");
            novoPatoMadeira.boia();
            novoPatoMadeira.mostra();

            System.Console.WriteLine("\nPato de Ferro: ");
            novoPatoFerro.mostra();

            System.Console.WriteLine("\nPato de Borracha: ");
            novoPatoBorracha.boia();
            novoPatoBorracha.flexivel();
            novoPatoBorracha.mostra();

        }
    }
}