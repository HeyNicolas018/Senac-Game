using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace makarovproject
{


    class Bullet : Monobehaviour
    {
        Vector2 pos;
        string forma = "*";
        public Bullet()
        {
            Run();
        }

        public override void Start()
        {
            pos = new Vector2(GameManager.Instance.player.pos.x+1, GameManager.Instance.player.pos.y);

        }

        public override void Update()
        {
                 movimentar();
        }

        public void movimentar()
        {
            int tempX = pos.x;
            int x = pos.Right;

            //movimentação do player principal
            if (Mapa.Instance.mapa[x,pos.y] == '#' )
            {
                GameManager.Instance.player.bullets.Remove(this);
                Stop();
            }

            foreach(var i in GameManager.Instance.map.myInimigos)
            {
                if (pos.x == i.x && pos.y == i.y)
                {
                    GameManager.Instance.map.myInimigos.Remove(i);
                    GameManager.Instance.player.ponto += 10;
                    GameManager.Instance.player.bullets.Remove(this);
                    Stop();
                    break;
                }
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(pos.x, pos.y);
            Console.WriteLine(forma);
            Console.ResetColor();
        }
    }
}
