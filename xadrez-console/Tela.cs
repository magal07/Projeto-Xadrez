using tabuleiro;
using System;
namespace xadrez_console
{
     class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++) {
                Console.Write(8 -i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if(tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        //Console.Write(tab.peca(i, j) + " "); // tab.peca = chamando peça no argumento tab // version initial
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor; // CRIANDO A VARIÁVEL E BUSCANDO COR PRIMÁRIA DO CONSOLE (CINZA)
                Console.ForegroundColor = ConsoleColor.Yellow; // ALTERANDO A COR DA VARIÁVEL aux PARA YELLOW
                Console.Write(peca); // chamando peça
                Console.ForegroundColor = aux;
            }
        }
    }
}
