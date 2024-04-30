﻿using System;
using tabuleiro;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdeMovimento { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qtdeMovimento = 0; 
        }

        public void incrementarQtdeMovimentos()
        {
            qtdeMovimento++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
