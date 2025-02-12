using System;
using xadrez;
using tabuleiro;
using System.Runtime.ConstrainedExecution;
namespace xadrez_console
{
    class Tela
    {
        public static void imprimirPartida(PartidaDeXadrez partida)
        {
            Tela.imprimirTabuleiro(partida.tab);
            Console.WriteLine();

            Console.WriteLine("Turno atual: " + partida.turno);
            Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);
            Console.WriteLine();
            Console.WriteLine("Peças capturadas: ");
            Console.Write("Brancas: ");
            Tela.imprimirPecasCapturadas(partida, Cor.Branca);
            Console.Write("Pretas: ");
            Tela.imprimirPecasCapturadas(partida, Cor.Preta);

        }
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
        public static void imprimirPecasCapturadas(PartidaDeXadrez p, Cor cor)
        {
            ConsoleColor aux = Console.ForegroundColor;
            if (cor == Cor.Preta)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write("[");
            foreach (Peca x in p.pecasCapturadas(cor))
            {
                Console.Write(" " + x + ", ");
            }
            Console.Write("]");
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }
    }
}