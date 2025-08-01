using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace makarovproject
{
    
    
    class Navio : Monobehaviour
    {
        public Vector2 pos = new Vector2(1, 1);      
        string forma = "|>";
        public int ponto = 0;
        public List<Bullet> bullets = new List<Bullet>();
        public Navio()
        {
            Run();
        }

        public override void Start()
        {
            Console.Clear();
        }

        public override void Update()
        {
            if (!input) return;
            var tecla = Console.ReadKey(true).Key;
            movimentar(tecla);
        }

        public void movimentar(ConsoleKey tecla)
        {         
            int tempX = pos.x;
            int tempY = pos.y;
            int x = pos.x;
            int y = pos.y;

            switch (tecla)
            {
                case ConsoleKey.F:
                    if (bullets.Count > 5)
                    {
                        Console.SetCursorPosition(20, 0);
                        Console.WriteLine("Limite de balas atingido! ");
                        return;
                    }
                    bullets.Add(new Bullet());
                    break;


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
                case ConsoleKey.X:

                    GameManager.Instance.map = Mapa.Instance;
                    GameManager.Instance.map.visible = false;
                    GameManager.Instance.map.input = false; 
                    GameManager.Instance.player.visible = false;

                    GameManager.Instance.diamante.visible = true;
                    GameManager.Instance.diamante.input = true;                   

                    GameManager.Instance.player.visible = false;
                    GameManager.Instance.player.visible = false;
                    GameManager.Instance.player.Stop();


                    break;
            }

            //movimentação do player principal
            if (Mapa.Instance.mapa[x, y] == '#' || Mapa.Instance.mapa[x + 1, y] == '#' || Mapa.Instance.mapa[x - 1, y] == '#' )
            {
                pos.x = tempX;
                pos.y = tempY;
                
            }



            foreach (var i in GameManager.Instance.map.myInimigos)
            {
                if (pos.x >= i.x && pos.x <= (i.x+i.forma.Length) && pos.y == i.y)
                {
                    GameManager.Instance.map.myInimigos.Remove(i);
                    GameManager.Instance.player.visible = false;
                    GameManager.Instance.player.input = false;

                    GameManager.Instance.map.visible = false;
                    GameManager.Instance.map.input = false;

                    GameManager.Instance.diamante.visible = true;
                    GameManager.Instance.diamante.input = true;

                    Stop();
                    break;
                }
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(pos.x, pos.y);
            Console.WriteLine(forma);
            Console.ResetColor();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Pontos: {ponto} ");
            try
            {
                foreach (var bullet in bullets)
                {
                    bullet.Draw();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
