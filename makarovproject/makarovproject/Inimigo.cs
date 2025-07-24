using makarovproject;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace makarovproject
{
    public class Inimigo
    {
        public string forma { get; set; }
        public char disparo { get; set; }


        public int x { get; set; }
        public int y { get; set; }


        public ConsoleColor cor { get; set; }

        public Inimigo(string forma, ConsoleColor cor) {
            this.forma = forma;

            Random random = new Random();

            this.x = random.Next(1, Mapa.Instance.largura - forma.Length - 1); 

            this.y = random.Next(1, Mapa.Instance.altura - 1);

            this.cor = cor;
        }



        public void desenha()
        {
            Console.ForegroundColor = cor;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(forma);
            Console.ResetColor();
        }


        public void Update()
        {
           
            Random random = new Random();

            //posições aleatórias
            int ry = random.Next(-1, 2);
            int rx = random.Next(-1, 2);
            //pos. Y
            if (ry + y > 0 && ry + y < Mapa.Instance.altura - 1)
            {
                y += ry;
            }
            //pos. X
            if (x + rx > 0 && x + rx + forma.Length < Mapa.Instance.largura - 2)
            {
                x += rx;
            }
        }
       
    }
 }
