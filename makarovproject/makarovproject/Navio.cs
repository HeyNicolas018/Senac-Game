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
        Vector2 pos = new Vector2(1, 1);
        List<Inimigo> myInimigos = new List<Inimigo>();
        char[,] mapa;

        string forma = "|>";

        public Navio(int x, int y, List<Inimigo> myInimigos)
        {
            this.myInimigos = myInimigos;
            this.mapa = Mapa.Instance.mapa;
        }
        
        public void movimentar(ConsoleKey tecla)
        {
            
            int tempX = pos.x;
            int tempY = pos.y;
            int x = pos.x;
            int y = pos.y;

            switch (tecla)
            {
                case ConsoleKey.A:
                    x = pos.Left;
                    break;
                case ConsoleKey.D:
                    x = pos.Right;
                    break;
                case ConsoleKey.S:
                    y = pos.Down;
                    break;
                case ConsoleKey.W:
                    y = pos.Up;
                    break;
            }

            //movimentação do player principal
            if (mapa[x, y] == '#' || mapa[x + 1, y] == '#' || mapa[x - 1, y] == '#' )
            {
                pos.x = tempX;
                pos.y = tempY;
                
            }
            desenha();

        }
        public void desenha()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.SetCursorPosition(pos.x , pos.y);
            Console.WriteLine(forma);
            Console.ResetColor();
        }




    }
}
