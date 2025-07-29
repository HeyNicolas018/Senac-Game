using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace makarovproject
{
    class MenuJogo : Monobehaviour
    {
        public MenuJogo() {
            Run();

        }

        static private MenuJogo myMenu;

        public static MenuJogo Mymenu => myMenu ??= new MenuJogo();

        public override void Update()
        {
            if (!input) return;
             var tecla = Console.ReadKey().Key;
            switch (tecla)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:

                    //Opção jogar
                    GameManager.Instance.map = Mapa.Instance;
                    GameManager.Instance.map.visible = true;

                    GameManager.Instance.player = new Navio();
                    GameManager.Instance.player.visible = true;
                    GameManager.Instance.player.input = true;

                    GameManager.Instance.diamante.visible = false;
                    GameManager.Instance.diamante.input = false;
                    break;

                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    //Essa opção faz com que você possa escolher as cores do terminal

                    
                    GameManager.Instance.map = Mapa.Instance;
                    GameManager.Instance.map.visible = false;
                    GameManager.Instance.map.input = false;

                    GameManager.Instance.diamante.visible = false;
                    GameManager.Instance.diamante.input = false;
                    
                    GameManager.Instance.cores = EscolherCores.selecionaCor;
                    GameManager.Instance.cores.visible = true;
                    GameManager.Instance.cores.input = true;
                    
                    break;

                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    //Estes são os créditos
                    GameManager.Instance.creditoJogador();
                    break;

                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    Console.WriteLine("Você escolheu sair. Obrigado por jogar e até a próxima!! xD");
                    break;

            }
        }

        public override void Draw()
        {

            EscolherCores.selecionaCor.corConfirmada();
                
            //Menu Principal
            Console.WriteLine("\r\nTECLAS:\r\nUse a tecla 1 para jogar \r\nTecla 2 para abrir as configurações\r\nTecla 3 Para abrir os créditos\r\nTecla 4 para fechar o jogo \r\nTecla X para sair dos menus!");

            //Jogar
            Console.WriteLine("                      _  ___   ____    _    ____\r\n                     | |/ _ \\ / ___|  / \\  |  _ \\\r\n                  _  | | | | | |  _  / _ \\ | |_)\r\n                 | |_| | |_| | |_| |/ ___ \\|  _ <\r\n                  \\___/ \\___/ \\____/_/   \\_\\_| \\_\\");

            //Configuracao
            Console.WriteLine("  ____ ___  _   _ _____ ___ ____ _   _ ____      _    ____ ___  _____ ____\r\n / ___/ _ \\| \\ | |  ___|_ _/ ___| | | |  _ \\    / \\  / ___/ _ \\| ____/ ___|\r\n| |  | | | |  \\| | |_   | | |  _| | | | |_) |  / _ \\| |  | | | |  _| \\___ \\\r\n| |__| |_| | |\\  |  _|  | | |_| | |_| |  _ <  / ___ \\ |__| |_| | |___ ___) |\r\n \\____\\___/|_| \\_|_|   |___\\____|\\___/|_| \\_\\/_/   \\_\\____\\___/|_____|____/");

            //Creditos
            Console.WriteLine("              ____ ____  _____ ____ ___ _____ ___  ____\r\n             / ___|  _ \\| ____|  _ \\_ _|_   _/ _ \\/ ___|\r\n            | |   | |_) |  _| | | | | |  | || | | \\___ \\\r\n            | |___|  _ <| |___| |_| | |  | || |_| |___) |\r\n             \\____|_| \\_\\_____|____/___| |_| \\___/|____/");

            //Sair
            Console.WriteLine("                        ____    _    ___ ____\r\n                       / ___|  / \\  |_ _|  _ \\\r\n                       \\___ \\ / _ \\  | || |_)\r\n                        ___) / ___ \\ | ||  _ <\r\n                       |____/_/   \\_\\___|_| \\_\\");

           
            
        }
    }
}
