using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makarovproject
{
    class CreditoJogador : Monobehaviour
    {
        public CreditoJogador()
        {
            Run();
        }
        public static CreditoJogador instance;
        public static CreditoJogador Instance => instance ??= new CreditoJogador();

        public override void Draw()
        {
            GameManager.Instance.cores.corConfirmada();
            Console.WriteLine("O jogo foi inspirado em navios e ações marítimas. Os navios foram expirados em símbolos que mostram o que cada é.\r\nBoa sorte se jogar novamente e busque o máximo de pontuação que conseguir!\r\nObrigado por jogar e até a próxima!");
        }

        public override void Update()
        {
            if (!input) return;
            var tecla = Console.ReadKey().Key;
            switch (tecla)
            {
                case ConsoleKey.X:
                    // Sai do menu                    
                        GameManager.Instance.cores.visible = false;
                        GameManager.Instance.cores.input = false;

                        GameManager.Instance.diamante.visible = true;
                        GameManager.Instance.diamante.input = true;
                  break;
            }
        }
    }
}
