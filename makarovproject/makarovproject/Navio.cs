using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace makarovproject
{
    
    
    class Navio
    {
        
        public int x;
        public int y;
        List<Inimigo> myInimigos = new List<Inimigo>();
        char[,] mapa;

        string forma = "|>";

        public Navio(int x, int y, List<Inimigo> myInimigos, char[,]mapa)
        {
            this.x = x;
            this.y = y;
            this.myInimigos = myInimigos;
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
            if (mapa[tempX, tempY] != '#' && mapa[tempX + 1, tempY] != '#' && mapa[tempX +1, tempY] != '#' && mapa[tempX, tempY] != '#' && mapa[tempX, tempY ] != '#')
            {
                x = tempX;
                y = tempY;
                desenha();
            }

        }
        public void desenha()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.SetCursorPosition(x, y);
            Console.WriteLine(forma);
            Console.ResetColor();
        }




    }
}
