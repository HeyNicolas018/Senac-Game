using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace makarovproject
{
    class EscolherCores : Monobehaviour
    {
        public EscolherCores() {  Run();

        }
        
        private static EscolherCores metodoCor;
        
        public static EscolherCores selecionaCor = metodoCor ??= new EscolherCores();

        public ConsoleColor corEscolhida = ConsoleColor.White;

       

        public override void Draw()
        {
            corConfirmada();
            Console.WriteLine("Aqui você tem a informação de teclas que mudam a cor e dá a possibilidade de escolher o que você vai querer no terminal.\r\nAs teclas para as cores são: ");
            //Número 1
            ManterCor("  _          __     _______ ____  __  __ _____ _     _   _  ___  \r\n / |         \\ \\   / / ____|  _ \\|  \\/  | ____| |   | | | |/ _ \\ \r\n | |  _____   \\ \\ / /|  _| | |_) | |\\/| |  _| | |   | |_| | | | |\r\n | | |_____|   \\ V / | |___|  _ <| |  | | |___| |___|  _  | |_| |\r\n |_|            \\_/  |_____|_| \\_\\_|  |_|_____|_____|_| |_|\\___/ \r\n                                                                 ", ConsoleColor.Red);

            //Número 2
            ManterCor("  ____               _    __  __    _    ____  _____ _     ___  \r\n |___ \\             / \\  |  \\/  |  / \\  |  _ \\| ____| |   / _ \\ \r\n   __) |  _____    / _ \\ | |\\/| | / _ \\ | |_) |  _| | |  | | | |\r\n  / __/  |_____|  / ___ \\| |  | |/ ___ \\|  _ <| |___| |__| |_| |\r\n |_____|         /_/   \\_\\_|  |_/_/   \\_\\_| \\_\\_____|_____\\___/ \r\n                                                                ", ConsoleColor.Yellow);

            //Número 3
            ManterCor("  _____          __     _______ ____  ____  _____ \r\n |___ /          \\ \\   / / ____|  _ \\|  _ \\| ____|\r\n   |_ \\   _____   \\ \\ / /|  _| | |_) | | | |  _|  \r\n  ___) | |_____|   \\ V / | |___|  _ <| |_| | |___ \r\n |____/             \\_/  |_____|_| \\_\\____/|_____|\r\n                                                  ", ConsoleColor.Green);

            
        }
        

        public void corConfirmada()
        {

            Console.Clear();
            Console.ForegroundColor = corEscolhida;
            
          
        }

        public void ManterCor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
        public override void Update()
        {
            
            if (!input) return;
            var tecla = Console.ReadKey().Key;
            switch (tecla)
            {

                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:

                    input = false;
                    visible = false;
                    ConsoleKey confi;
                    do
                    {
                        Console.WriteLine("\r\nDeseja Aplicar a cor Vermelha no terminal?\r\nY para confirmar\r\nN para Cancelar ");
                        confi = Console.ReadKey(true).Key;
                    } while (confi != ConsoleKey.Y && confi != ConsoleKey.N);

                    if (confi == ConsoleKey.Y)
                    {
                        GameManager.Instance.cores.corEscolhida = ConsoleColor.Red;
                        Mapa.Instance.corEscolhida = ConsoleColor.Red;
                        GameManager.Instance.diamante.visible = true;
                        GameManager.Instance.diamante.input = true;
                      
                    } else if (confi == ConsoleKey.N)
                    {
                        GameManager.Instance.cores.visible = true;
                        GameManager.Instance.cores.input = true;
                    }
                     break;
  
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:

                        input = false;
                        visible = false;
                        ConsoleKey Conf;

                    do
                    {
                        Console.WriteLine(" Deseja Aplicar a cor Amarela no terminal?\r\nY para confirmar\r\nN para Cancelar ");
                        Conf = Console.ReadKey(true).Key;
                    }   while (Conf != ConsoleKey.Y && Conf != ConsoleKey.N);

                    if (Conf == ConsoleKey.Y)
                    {
                        //Console.WriteLine("Perfeito! A cor Amarela foi selecionada com sucesso. Volte para o menu e a cor será definitivamente aplicada!");

                        GameManager.Instance.cores.corEscolhida = ConsoleColor.Yellow;
                        Mapa.Instance.corEscolhida = ConsoleColor.Yellow;

                        GameManager.Instance.diamante.visible = true;
                        GameManager.Instance.diamante.input = true;
                    }   else if (Conf == ConsoleKey.N)
                    {
                        GameManager.Instance.cores.visible = true;
                        GameManager.Instance.cores.input = true;
                    }
                    break;

                 case ConsoleKey.NumPad3:
                 case ConsoleKey.D3:
                    //Essa opção faz com que você possa escolher as cores do terminal
                    input = false;
                    visible = false;
                    ConsoleKey Confirm;
                    do
                    {
                        Console.WriteLine(" Deseja Aplicar a cor Verde no terminal?\r\nY para confirmar\r\nN para Cancelar ");
                        Confirm = Console.ReadKey(true).Key;
                    }   while (Confirm != ConsoleKey.Y && Confirm != ConsoleKey.N);
                    

                    if (Confirm == ConsoleKey.Y)
                    {
                        GameManager.Instance.cores.corEscolhida = ConsoleColor.Green;
                        Mapa.Instance.corEscolhida = ConsoleColor.Green;
                        GameManager.Instance.diamante.visible = true;
                        GameManager.Instance.diamante.input = true;
                    }
                    else if(Confirm == ConsoleKey.N)
                    {
                        GameManager.Instance.cores.visible = true;
                        GameManager.Instance.cores.input = true;

                    }
                    break;

                 case ConsoleKey.X:
                    // Sai do menu                    
                        GameManager.Instance.cores.visible = false;
                        GameManager.Instance.cores.input = false;

                        GameManager.Instance.diamante.visible = true;
                        GameManager.Instance.diamante.input = true;
                  break;
            }            
        }
        
        

        public static void NovaCor()
        {
            //EscolherCores.ManterCor("  _  _               _____ _____          _   _  ____  \r\n | || |             / ____|_   _|   /\\   | \\ | |/ __ \\ \r\n | || |_   ______  | |      | |    /  \\  |  \\| | |  | |\r\n |__   _| |______| | |      | |   / /\\ \\ | . ` | |  | |\r\n    | |            | |____ _| |_ / ____ \\| |\\  | |__| |\r\n    |_|             \\_____|_____/_/    \\_\\_| \\_|\\____/ \r\n                                                       \r\n                                                       ", ConsoleColor.Cyan);
        }
    }


}
