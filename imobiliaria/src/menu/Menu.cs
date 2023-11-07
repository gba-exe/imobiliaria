using System;
using imobiliaria.imobiliaria;

namespace imobiliaria.menu
{
    public class Menu
    {
        private Display display = new Display();
        private Logica logica = new Logica();

        private int solicitarOpcao()
        {
            Console.WriteLine("Insira uma opcao: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private string solicitarInformacao()
        {
            return Console.ReadLine();
        }

        public void iniciar(Imobiliaria imobiliaria)
        {
            while (true)
            {
                display.mostrarOpcoesIniciais();
                switch (solicitarOpcao())
                {
                    case 1:
                        cadastrarFuncionario();
                        break;
                    case 2:
                        entrar(imobiliaria);
                        break;
                    case 0:
                        display.sair();
                        return;
                    default:
                        display.opcaoInvalida();
                        break;
                }
            }
        }

        private void cadastrarFuncionario()
        {
            while (true)
            {
                display.cadastrarFuncionario();
                switch (solicitarOpcao())
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        display.voltar();
                        return;
                    default:
                        display.opcaoInvalida();
                        break;
                }    
            }
        }

        private void entrar(Imobiliaria imobiliaria)
        {
            Console.Write("Cpf: ");
            String cpf = solicitarInformacao();
            
            Console.Write("Codigo: ");
            String codigo = solicitarInformacao();

            if (logica.isCadastrado(cpf, codigo, imobiliaria))
            {
                display.entrando();
            }
            else
            {
                display.loginInvalido();
            }
        }
}
}