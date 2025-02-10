using System;
using tabuleiro;
namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro T)
        {
           

            for (int i = 0; i < T.linhas; i++)
            {

                for (int j = 0; j < T.colunas; j++)
                {
                    if(T.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.WriteLine(T.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}