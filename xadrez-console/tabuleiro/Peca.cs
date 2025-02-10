using System;
using xadrez_console;

namespace tabuleiro
{
    class Peca
    {
        public Cor cor {  get; set; }
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
        
    }
}
