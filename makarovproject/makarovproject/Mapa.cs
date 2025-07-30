using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace makarovproject
{
    class Mapa : Monobehaviour
    {
        private Mapa() {
            Run();


        }
        private static Mapa instance;
        public static Mapa Instance => instance ??= new Mapa();
        
        public char[,] mapa;
        public int largura = 120;
        public int altura = 29;
        
        public ConsoleColor corEscolhida = EscolherCores.selecionaCor.corEscolhida;
        public List<Inimigo> myInimigos = new List<Inimigo>();

       

        public void iniciar()
        {
            
            mapa = new char[largura, altura];

            myInimigos.Add(new Inimigo("|>",  ConsoleColor.Red));
            for (int i = 0; i < 10; i++)
            {
                myInimigos.Add(new Inimigo("|//>", ConsoleColor.Red));
            }

            myInimigos.Add(new Inimigo("|/>", ConsoleColor.Red));

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
        }
        
        public override void Draw()
        {
            Console.SetCursorPosition(0,0);
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

   
        public override void Start()
        {
            iniciar();
        }

        public override void Update()
        {
            AtualizarPosicao();
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
