

using tabuleiro;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos) // colocar Peca p na posição Pos
        {
            pecas[pos.linha, pos.coluna] = p; // é ir lá na matriz de pecas e jogar a peca p
            p.posicao = pos; // ir na p e dizer q a posição da p agr é pós
        }
    }
}
