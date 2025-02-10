using System;
using MyApp;
using tabuleiro;
namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro T)
        {
            int m = 8;
            for (int i = 0; i < T.linhas; i++)
            {
                Console.Write(m-- + " ");
                for (int j = 0; j < T.colunas; j++)
                {
                    if (T.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {

                        imprimirPeca(T.peca(i,j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                if(i == T.linhas - 1)
                {
                    Console.Write("  " + "a b c d e f g h");
                    Console.WriteLine();
                }
            }
        }
        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}