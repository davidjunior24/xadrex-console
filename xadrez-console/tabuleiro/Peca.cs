using System;

namespace tabuleiro
{
    class Peca
    {
        public Cor cor {  get; set; }
        public Posicao posicao { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Cor cor, Posicao posicao, int qtdMovimentos)
        {
            this.cor = cor;
            this.posicao = posicao;
            this.qtdMovimentos = qtdMovimentos;
        }
    }
}
