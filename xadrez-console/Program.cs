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
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.adicionarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.adicionarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.adicionarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));


            Tela.imprimirTabuleiro(tab);
        }

    }
}