using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makarovproject
{
    class GameManager: Monobehaviour
    {
        private GameManager() {
            Run();
        }

        static private GameManager instance;

       public static GameManager Instance => instance ??= new GameManager();



        
        public Navio player;
        public bool jogando = false;
        

        public List<Inimigo> myInimigos = new List<Inimigo>();


        public override void Update()
        {

            if (jogando)
            {
                var tecla = Console.ReadKey().Key;
                player.movimentar(tecla);
            } else
            {
                Console.Clear();
                MenuJogo.Mymenu.MeuMenu();
            }
            
        }

        public void creditoJogador()
        {
            string tecla;
            do
            {
                Console.Clear();
                Console.WriteLine("O jogo foi inspirado em navios e ações marítimas. Os navios foram expirados em símbolos que mostram o que cada é.\r\nBoa sorte se jogar novamente e busque o máximo de pontuação que conseguir!\r\nObrigado por jogar e até a próxima!");
                tecla = Console.ReadLine();
            } while (tecla != "x");
        }

        public void jogar()
        {
            jogando = true;
            
            player = new Navio();

        }
    }
}


