using System;
using tabuleiro;
using xadrez;
using xadrez_console;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.adicionarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.adicionarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 5));
                tab.adicionarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                tab.adicionarPeca(new Rei(tab, Cor.Branca), new Posicao(4, 5));


                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}