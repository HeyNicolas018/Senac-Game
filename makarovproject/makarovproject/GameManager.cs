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
        public MenuJogo diamante;
        public Mapa map;
        public EscolherCores cores;
        public CreditoJogador creditos;
        
        public bool jogando = false;        
        public List<Inimigo> myInimigos = new List<Inimigo>();


        public override void Update()
        {
            Draw();           
        }

        public override void Start()
        {
            diamante = MenuJogo.Mymenu;
            diamante.visible = true;
            diamante.input = true;
        }

        public void jogar()
        {
            jogando = true;        
            player = new Navio();
        }

        public override void Draw()
        {
            if (map != null && map.visible) map.Draw();
            if (player != null && player.visible) player.Draw();          
            if (diamante != null && diamante.visible) diamante.Draw();
            if (cores != null && cores.visible) cores.Draw();
            if (creditos != null && creditos.visible) creditos.Draw();
        }
    }
}


