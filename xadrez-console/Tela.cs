﻿using System;
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
                    imprimirPeca(T.peca(i, j));
                }
                Console.WriteLine();
                if (i == T.linhas - 1)
                {
                    Console.Write("  " + "a b c d e f g h");
                    Console.WriteLine();
                }
            }
        }
        public static void imprimirTabuleiro(Tabuleiro T, bool[,] possiveisMovimentos)
        {
            ConsoleColor corOriginal = Console.BackgroundColor;
            ConsoleColor corAlterada = ConsoleColor.DarkGray;
            int m = 8;
            for (int i = 0; i < T.linhas; i++)
            {
                Console.Write(m-- + " ");
                for (int j = 0; j < T.colunas; j++)
                {
                    if (possiveisMovimentos[i, j] == true)
                    {
                        Console.BackgroundColor = corAlterada;
                    }
                    
                    imprimirPeca(T.peca(i, j));
                    Console.BackgroundColor = corOriginal;
                }
                Console.WriteLine();
                if (i == T.linhas - 1)
                {
                    Console.Write("  " + "a b c d e f g h");
                    Console.WriteLine();
                }
            }
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string posic = Console.ReadLine();
            char coluna = posic[0];
            int linha = int.Parse(posic[1] + ""); // "" -> força a ser uma string
            return new PosicaoXadrez(coluna, linha);
        }
        public static void imprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca + " ");
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(peca + " ");
                    Console.ForegroundColor = aux;
                }
            }
        }
    }
}