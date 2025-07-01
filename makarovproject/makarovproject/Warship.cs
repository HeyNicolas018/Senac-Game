using System;
using System.Security.Cryptography.X509Certificates;

namespace makarovproject
{
    class Warship
    {
        static char[,] mapa;
        static int largura = 50;
        static int altura = 20;
        static int playerX = 24;
        static int playerY = 10;
        static bool jogando = true;
        static ConsoleColor corEscolhida = ConsoleColor.White;
        static int[][] inimigos = new int[5][]; 


        public static void Main()
        {
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
                        Console.WriteLine("Opção jogar escolhida");
                        jogar();
                        break;

                    case "2":
                        Console.WriteLine("Essa opção faz com que você possa escolher as cores do terminal!.");
                        EscolherCor();
                        break;

                    case "3":
                        Console.WriteLine("Estes são os créditos!");
                        creditoJogador();
                        break;

                    case "4":
                        Console.WriteLine("Você escolheu sair. Obrigado por jogar e até a próxima!! xD");
                        break;

                    case "w":
                        Console.WriteLine("Cima");
                        break;

                    case "a":
                        Console.WriteLine("Esquerda");
                        break;

                    case "s":
                        Console.WriteLine("Baixo");
                        break;

                    case "d":
                        Console.WriteLine("Direita");
                        break;
                }
            } while (tecla != "4");
            // Console.WriteLine("............................................................................  \r\n.............................................................. |//>..........\r\n.............|//>...........................................................\r\n............................................................................\r\n.................................................+=>........................\r\n...........................|>......................................[ ]>.....\r\n............................................................................\r\n.......|>...................................................................\r\n............................................................................\r\n.................................................|>.........................\r\n..................................<\\\\|......................................\r\n......|/>...................................................................\r\n............................................................................\r\n.......................|>......................................<=+..........\r\n.........|//>...............................................................\r\n...........................................<|...............................\r\n.............................................................=>.............\r\n....................+ |> + .................................................");
        }
        public static void ManterCor(string mensagem, ConsoleColor cor)
        {

            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();

        }
        public static void corConfirmada()
        {
            Console.Clear();
            Console.ForegroundColor = corEscolhida;

        }
        public static void EscolherCor()
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
        public static void creditoJogador()
        {
            string tecla;
            do
            {
                Console.Clear();
                Console.WriteLine("O jogo foi inspirado em navios e ações marítimas. Os navios foram expirados em símbolos que mostram o que cada é.\r\nBoa sorte se jogar novamente e busque o máximo de pontuação que conseguir!\r\nObrigado por jogar e até a próxima!");
                tecla = Console.ReadLine();
            } while (tecla != "x");
        }

        static void jogar()
        {
            iniciarMapa();
            while (jogando)
            {

                Console.Clear();
                desenhaMapa();

                var tecla = Console.ReadKey(true).Key;
                AtualizarPosicao(tecla);
            }
        }


        //Inicia o mapa
        static void iniciarMapa()
        {
            mapa = new char[largura, altura];

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
            mapa[playerX, playerY] = '>';
            mapa[playerX - 1, playerY] = '|';


        }
        //Desenha o Mapa
        static void desenhaMapa()
        {
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {

                    Console.Write(mapa[x, y]);
                }
                Console.WriteLine();
            }
        }


        static void AtualizarPosicao(ConsoleKey tecla)
        {
            int tempX = playerX;
            int tempY = playerY;
            switch (tecla)
            {
                case ConsoleKey.A:
                    tempX--;
                    break;
                case ConsoleKey.S:
                    tempY++;
                    break;
                case ConsoleKey.D:
                    tempX++;
                    break;
                case ConsoleKey.W:
                    tempY--;
                    break;
            }

            if (mapa[tempX, tempY] != '#' && mapa[tempX - 1, tempY] != '#')
            {
                mapa[playerX, playerY] = '.';
                mapa[playerX - 1, playerY] = '.';
                mapa[tempX, tempY] = '>';
                mapa[tempX - 1, tempY] = '|';
                playerX = tempX;
                playerY = tempY;
            }
        }

    }
}
    // Console.WriteLine("............................................................................  \r\n.............................................................. |//>..........\r\n.............|//>...........................................................\r\n............................................................................\r\n.................................................+=>........................\r\n...........................|>......................................[ ]>.....\r\n............................................................................\r\n.......|>...................................................................\r\n............................................................................\r\n.................................................|>.........................\r\n..................................<\\\\|......................................\r\n......|/>...................................................................\r\n............................................................................\r\n.......................|>......................................<=+..........\r\n.........|//>...............................................................\r\n...........................................<|...............................\r\n.............................................................=>.............\r\n....................+ |> + .................................................");

//navio encontra outros navios e ele navega pelo mapinha a procura de outros navios e eliminá.los.
// existe Destroyers, Cruzadores, Battleships e Porta aviões 
// string destroyer = "Você recebe 10 pontos";
// string Cruzador = "Você recebe 20 pontos";
// string Battleship = "Você recebe 30 pontos";
// string portaAvioes = "Você recebe 50 pontos";

// Os navios vão aparecer ao decorrer do jogo e você terá  que destruir o máximo de návio que conseguir.
// Se caso você morrer = [ string morreu = "você perdeu o jogo" ]
// o jogo reinicia.
// DESTROYER = [ "  |> " ]
// CRUZADOR  = [ "  |/>  " ]
// BATTLESHIP = [ "  |//> " ]
// PORTA.AVIAO = [ " +=> "  ]

//Esses são os projéteis do návio:
// DISPARO DOS NAVIOS (TODOS) : [ " * " ]
// TORPEDO DOS CRUZADORES, DESTROIERS E AVIÕES  = [ " + " ]
// IDENTIFICAÇÃO DO AVIAO DO PORTA AVIAO = [ " /-*-\ " ]

/* MAPA DO JOGO  

OS  " . " REPRESENTAM O MAR DO JOGO.

............................................................................  
..............................................................|//>..........
.............|//>...........................................................
............................................................................
.................................................+=>........................
...........................|>......................................|>.......
............................................................................
.......|>...................................................................
............................................................................
.................................................|>.........................
..................................<\\|......................................
......|/>...................................................................
............................................................................
.......................|>......................................<=+..........
.........|//>...............................................................
...........................................<|...............................
.............................................................=>.............
.................... [ |> ] ................................................
        |
         --> "aqui está o jogador e ele começa com um Destroyer
                          tendo a possibilidade de upar seu navio ao decorrer
                          do jogo" 
*/


/*
                                                                               
                                                                            
                                                                               
                                          _____   ___      ______       _      _______     
                                       |_   _|.'   `.  .' ___  |     / \    |_   __ \    
                                         | | /  .-.  \/ .'   \_|    / _ \     | |__) |   
                                     _   | | | |   | || |   ____   / ___ \    |  __ /    
                                    | |__' | \  `-'  /\ `.___]  |_/ /   \ \_ _| |  \ \_  
                                    `.____.'  `.___.'  `._____.'|____| |____|____| |___| 
                                                                                                                             
                                                                               
                                                                               
                                                                               
                                                                               
                                                                               
*/