using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    internal class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna) // Construtor com argumentos
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString() // Sobreposição para exibir na tela
        {
            return Linha + ", " + Coluna;
        }
    }
}
