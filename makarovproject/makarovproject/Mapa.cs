using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace makarovproject
{
    class Mapa
    {
        private Mapa() { }
        private static Mapa instance;
        public static Mapa Instance => instance ??= new Mapa();
        
        public char[,] mapa;
        public int largura = 50;
        public int altura = 20;

        public ConsoleColor corEscolhida = ConsoleColor.White;
        public List<Inimigo> myInimigos = new List<Inimigo>();


        public void iniciar()
        {
            
            mapa = new char[largura, altura];

            Random random = new Random();

            int x = random.Next(1, 49);
            int y = random.Next(1, 19);
            myInimigos.Add(new Inimigo("|>", x, y, ConsoleColor.Red));

            
            for (int i = 0; i < 5; i++)
            {
                x = random.Next(1, 49);
                y = random.Next(1, 19);
                myInimigos.Add(new Inimigo("|x", x, y, ConsoleColor.Red));
            }

             x = random.Next(1, 49);
             y = random.Next(1, 19);
            myInimigos.Add(new Inimigo("|//>", x, y, ConsoleColor.Red));
            //finaliza



            for ( x = 0; x < largura; x++)
            {
                for ( y = 0; y < altura; y++)
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
        }
        //Desenha o Mapa
        public void desenharMapa()
        {
            Console.ForegroundColor = corEscolhida;
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {

                    Console.Write(mapa[x, y]);
                }
                Console.WriteLine();
            }


            foreach (var i in myInimigos)
            {
                i.desenha();
            }

        }
        public void AtualizarPosicao()
        {

            //movimentação do inimigos

            foreach (var i in myInimigos)
            {
                i.Update();
            }
        } 
    }
}
