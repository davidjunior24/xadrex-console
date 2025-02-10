using System;
using tabuleiro;
using xadrez_console;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro t = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(t);
            Console.ReadLine();
        }

    }
}