using System;
using xadrez_console;

namespace tabuleiro
{
    abstract class Peca
    {
        public Cor cor { get; set; }
        public Posicao posicao { get; set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qtdMovimentos = 0;
        }
        public void incrementarQtdMovimento()
        {
            qtdMovimentos++;
        }
        public void decrementarQtdMovimento()
        {
            qtdMovimentos--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for(int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public abstract bool[,] movimentosPossiveis();

    }
}
