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

            PosicaoXadrez pos = new PosicaoXadrez('a', 2);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();

        }
    }
}