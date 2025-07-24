using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makarovproject
{
    class GameManager
    {
        private GameManager() { }

        static private GameManager instance;

       public static GameManager Instance => instance ??= new GameManager();



        
        public Navio player;
        public bool jogando = true;
        public ConsoleColor corEscolhida = ConsoleColor.White;

        public List<Inimigo> myInimigos = new List<Inimigo>();

        public void Start()
        {
            Menu();
        }
        public void Menu() {
            
            /*
            if () { }
            else if () { }
            else { }
            */

            string tecla;
            do
            {

                corConfirmada();

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

                tecla = Console.ReadLine();
                switch (tecla)
                {
                    case "1":
                        //Opção jogar
                        jogar();
                        break;

                    case "2":
                        //Essa opção faz com que você possa escolher as cores do terminal
                        EscolherCor();
                        break;

                    case "3":
                        //Estes são os créditos
                        creditoJogador();
                        break;

                    case "4":
                        Console.WriteLine("Você escolheu sair. Obrigado por jogar e até a próxima!! xD");
                        break;


                }
            } while (tecla != "4");
            // Console.WriteLine("............................................................................  \r\n.............................................................. |//>..........\r\n.............|//>...........................................................\r\n............................................................................\r\n.................................................+=>........................\r\n...........................|>......................................[ ]>.....\r\n............................................................................\r\n.......|>...................................................................\r\n............................................................................\r\n.................................................|>.........................\r\n..................................<\\\\|......................................\r\n......|/>...................................................................\r\n............................................................................\r\n.......................|>......................................<=+..........\r\n.........|//>...............................................................\r\n...........................................<|...............................\r\n.............................................................=>.............\r\n....................+ |> + .................................................");


        }

       



        
        public void ManterCor(string mensagem, ConsoleColor cor)
        {

            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();

        }
        public void corConfirmada()
        {
            Console.Clear();
            Console.ForegroundColor = corEscolhida;


        }
        public void EscolherCor()
        {
            string tecla;
            do
            {
                
                corConfirmada();
                Console.WriteLine("Aqui você tem a informação de teclas que mudam a cor e dá a possibilidade de escolher o que você vai querer no terminal.\r\nAs teclas para as cores são: ");

                //Número 1
                ManterCor("  _          __     _______ ____  __  __ _____ _     _   _  ___  \r\n / |         \\ \\   / / ____|  _ \\|  \\/  | ____| |   | | | |/ _ \\ \r\n | |  _____   \\ \\ / /|  _| | |_) | |\\/| |  _| | |   | |_| | | | |\r\n | | |_____|   \\ V / | |___|  _ <| |  | | |___| |___|  _  | |_| |\r\n |_|            \\_/  |_____|_| \\_\\_|  |_|_____|_____|_| |_|\\___/ \r\n                                                                 ", ConsoleColor.Red);

                //Número 2
                ManterCor("  ____               _    __  __    _    ____  _____ _     ___  \r\n |___ \\             / \\  |  \\/  |  / \\  |  _ \\| ____| |   / _ \\ \r\n   __) |  _____    / _ \\ | |\\/| | / _ \\ | |_) |  _| | |  | | | |\r\n  / __/  |_____|  / ___ \\| |  | |/ ___ \\|  _ <| |___| |__| |_| |\r\n |_____|         /_/   \\_\\_|  |_/_/   \\_\\_| \\_\\_____|_____\\___/ \r\n                                                                ", ConsoleColor.Yellow);

                //Número 3
                ManterCor("  _____          __     _______ ____  ____  _____ \r\n |___ /          \\ \\   / / ____|  _ \\|  _ \\| ____|\r\n   |_ \\   _____   \\ \\ / /|  _| | |_) | | | |  _|  \r\n  ___) | |_____|   \\ V / | |___|  _ <| |_| | |___ \r\n |____/             \\_/  |_____|_| \\_\\____/|_____|\r\n                                                  ", ConsoleColor.Green);

                tecla = Console.ReadLine();
                switch (tecla)
                {
                    case "1":
                        Console.WriteLine("Deseja Aplicar a cor Vermelha no terminal?\r\nY para confirmar\r\nN para Cancelar ");
                        string confi = Console.ReadLine();
                        if (confi == "y")
                        {

                            corEscolhida = ConsoleColor.Red;


                        }
                        break;

                    case "2":
                        Console.WriteLine("Deseja Aplicar a cor Amarela no terminal?\r\nY para confirmar\r\nN para Cancelar ");
                        string Conf = Console.ReadLine();
                        if (Conf == "y")
                        {
                            //Console.WriteLine("Perfeito! A cor Amarela foi selecionada com sucesso. Volte para o menu e a cor será definitivamente aplicada!");
                            corEscolhida = ConsoleColor.Yellow;
                        }
                        break;

                    case "3":
                        Console.WriteLine("Deseja Aplicar a cor Verde no terminal?\r\nY para confirmar\r\nN para Cancelar ");
                        string Confirm = Console.ReadLine();
                        if (Confirm == "y")
                        {
                            corEscolhida = ConsoleColor.Green;
                        }
                        break;
                }


            } while (tecla != "x");
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
            Console.Clear();
            Mapa.Instance.iniciar();
            player = new Navio(24, 10, myInimigos);
            while (jogando)
            {
                Console.SetCursorPosition(0, 0);
                Mapa.Instance.desenharMapa();
                player.desenha();
                var tecla = Console.ReadKey(true).Key;
                player.movimentar(tecla);
                Mapa.Instance.AtualizarPosicao();
            }
        }

    }
}


