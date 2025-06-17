using System;

namespace makarovproject
{
    class Warships
    {
        static char[,] mapa;
        static int largura = 20;
        static int altura = 10;
        static int playerX = 2;
        static int playerY = 1;
        static bool jogando = true;

        static void Main()
        {
            Console.Clear();
            //colocar menu 
            jogar();


        }
        static void jogar() {
             iniciarMapa();
             while (jogando) 
             {

                Console.Clear();
                desenhaMapa();

                var tecla = Console.ReadKey(true).Key;
                AtualizarPosicao(tecla);
             }
        }

        static void iniciarMapa() {
            mapa = new char[largura, altura];
            
            for (int x = 0; x < largura; x++)
            {
                for (int y = 0; y < altura; y++)
                {
                    //Ultima posiçao do vetor é tamanho - 1
                    if (x == 0 || y == 0 || x == largura - 1 || y == altura - 1)
                    {
                        mapa[x, y] = '#';
                    }
                    else
                    {
                        mapa[x, y] = '.';

                    }
                }
            }
            mapa[playerX, playerY] = '>';
            mapa[playerX-1, playerY] = '-';
        }
        static void desenhaMapa()
        {
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                
                    Console.Write(mapa[x, y]);
                }
                Console.WriteLine();
            }
        }


        static void AtualizarPosicao(ConsoleKey tecla)
        {
            int tempX = playerX;
            int tempY = playerY;
            //oi
            switch (tecla)
            {
                case ConsoleKey.A:
                    tempX--;
                    break;
                case ConsoleKey.S:
                    tempY++;
                    break;
                case ConsoleKey.D:
                    tempX++;
                    break;
                case ConsoleKey.W:
                    tempY--;
                    break;
            }

            if (mapa[tempX, tempY] != '#' && mapa[tempX-1, tempY] != '#')
            {
                mapa[playerX, playerY] = '.';
                mapa[playerX-1, playerY] = '.';
                mapa[tempX, tempY] = '>';
                mapa[tempX-1, tempY] = '-';
                playerX = tempX;
                playerY = tempY;
            }
        }

    }
}
    // Console.WriteLine("............................................................................  \r\n.............................................................. |//>..........\r\n.............|//>...........................................................\r\n............................................................................\r\n.................................................+=>........................\r\n...........................|>......................................[ ]>.....\r\n............................................................................\r\n.......|>...................................................................\r\n............................................................................\r\n.................................................|>.........................\r\n..................................<\\\\|......................................\r\n......|/>...................................................................\r\n............................................................................\r\n.......................|>......................................<=+..........\r\n.........|//>...............................................................\r\n...........................................<|...............................\r\n.............................................................=>.............\r\n....................+ |> + .................................................");



//navio encontra outros navios e ele navega pelo mapinha a procura de outros navios e eliminá.los.
// existe Destroyers, Cruzadores, Battleships e Porta aviões 
// string destroyer = "Você recebe 10 pontos";
// string Cruzador = "Você recebe 20 pontos";
// string Battleship = "Você recebe 30 pontos";
// string portaAvioes = "Você recebe 50 pontos";

// Os navios vão aparecer ao decorrer do jogo e você terá  que destruir o máximo de návio que conseguir.
// Se caso você morrer = [ string morreu = "você perdeu o jogo" ]
// o jogo reinicia.
// DESTROYER = [ "  |> " ]
// CRUZADOR  = [ "  |/>  " ]
// BATTLESHIP = [ "  |//> " ]
// PORTA.AVIAO = [ " +=> "  ]

//Esses são os projéteis do návio:
// DISPARO DOS NAVIOS (TODOS) : [ " * " ]
// TORPEDO DOS CRUZADORES, DESTROIERS E AVIÕES  = [ " + " ]
// IDENTIFICAÇÃO DO AVIAO DO PORTA AVIAO = [ " /-*-\ " ]

/* MAPA DO JOGO  

OS  " . " REPRESENTAM O MAR DO JOGO.

............................................................................
..............................................................|//>..........
.............|//>...........................................................
............................................................................
.................................................+=>........................
...........................|>......................................|>.......
............................................................................
.......|>...................................................................
............................................................................
.................................................|>.........................
..................................<\\|......................................
......|/>...................................................................
............................................................................
.......................|>......................................<=+..........
.........|//>...............................................................
...........................................<|...............................
.............................................................=>.............
.................... [ |> ] ................................................
        |
         --> "aqui está o jogador e ele começa com um Destroyer
                          tendo a possibilidade de upar seu navio ao decorrer
                          do jogo" 
*/
