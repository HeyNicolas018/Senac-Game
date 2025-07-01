using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace makarovproject
{
    
    
    class Navio
    {
        
        public int x;
        public int y;
        int[][] myInimigos;
        char[,] mapa;

        char forma = '+';

        public Navio(int x, int y, int[][] inimigos, char[,]mapa)
        {
            this.x = x;
            this.y = y;
            this.myInimigos = inimigos;
            this.mapa = mapa;
        }
        
        public void movimentar(ConsoleKey tecla)
        {
            
            int tempX = x;
            int tempY = y;

            switch (tecla)
            {
                case ConsoleKey.A:
                    tempX -= 1;
                    break;

                case ConsoleKey.D:
                    tempX += 1;
                    break;
                case ConsoleKey.S:
                    tempY += 1;
                    break;
                case ConsoleKey.W:
                    tempY -= 1;
                    break;
            }

            //movimentação do player principal
            if (mapa[tempX, tempY] != '#' && mapa[tempX - 1, tempY] != '#')
            {
                mapa[x, y] = '.';
                mapa[x - 1, y] = '.';
                mapa[tempX, tempY] = '>';
                mapa[tempX - 1, tempY] = '|';
                x = tempX;
                y = tempY;
            }

        }


    }
}
