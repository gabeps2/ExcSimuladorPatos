using System;

namespace ExcSimuladorPatos.Questao2
{
    class TesteQ2
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
            novoPatoCabecaVermelha.boia();
            novoPatoCabecaVermelha.flexivel();
            novoPatoCabecaVermelha.mostra();
            

            System.Console.WriteLine("\nPato Branco: ");
            novoPatoBranco.grasna();
            novoPatoBranco.nada();
            novoPatoBranco.voa();
            novoPatoBranco.boia();
            novoPatoBranco.flexivel();
            novoPatoBranco.mostra();

            System.Console.WriteLine("\nPato Verde: ");
            novoPatoVerde.grasna();
            novoPatoVerde.nada();
            novoPatoVerde.voa();
            novoPatoVerde.boia();
            novoPatoVerde.flexivel();
            novoPatoVerde.mostra();

            System.Console.WriteLine("\nPato de Madeira: ");
            novoPatoMadeira.grasna();
            novoPatoMadeira.nada();
            novoPatoMadeira.voa();
            novoPatoMadeira.boia();
            novoPatoMadeira.flexivel();
            novoPatoMadeira.mostra();

            System.Console.WriteLine("\nPato de Ferro: ");
            novoPatoFerro.grasna();
            novoPatoFerro.nada();
            novoPatoFerro.voa();
            novoPatoFerro.boia();
            novoPatoFerro.flexivel();
            novoPatoFerro.mostra();

            System.Console.WriteLine("\nPato de Borracha: ");
            novoPatoBorracha.grasna();
            novoPatoBorracha.nada();
            novoPatoBorracha.voa();
            novoPatoBorracha.boia();
            novoPatoBorracha.flexivel();
            novoPatoBorracha.mostra();

        }
    }
}