using System;

namespace imobiliaria.menu
{
    public class Display
    {
        public void mostrarOpcoesIniciais()
        {
            Console.WriteLine
            ($@"
+-----------------------------------------------------------+
| 1) Cadastrar Funcionario                                  |
| 2) Entrar                                                 |
|                                                           |
| 0) Sair                                                   |
+-----------------------------------------------------------+
            ");
        }

        public void cadastrarFuncionario()
        {
            Console.WriteLine
            ($@"
+-----------------------------------------------------------+
| 1) Cadastrar Gerente                                      |
| 2) Cadastrar Corretor Vendedor                            |
| 3) Cadastrar Corretor Captador                            |
|                                                           |
| 0) Sair                                                   |
+-----------------------------------------------------------+
            ");
        }

        public void entrar()
        {
            Console.WriteLine
            ($@"
+-----------------------------------------------------------+
| Inisira os dados abaixo:                                  |
+-----------------------------------------------------------+
            ");
        }

        public void opcaoInvalida()
        {
            Console.WriteLine("Opcao invalida! ");
        }

        public void voltar()
        {
            Console.WriteLine("Voltando... ");
        }
        public void sair()
        {
            Console.WriteLine("Saindo... ");
        }

        public void entrando()
        {
            Console.WriteLine("Entrando... ");
        }
        
        public void loginInvalido()
        {
            Console.WriteLine("Login invalido! ");
        }
    }
}