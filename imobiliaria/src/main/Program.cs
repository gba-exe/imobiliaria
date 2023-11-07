using System;
using imobiliaria.equipe;
using imobiliaria.funcionario.corretor;
using imobiliaria.funcionario.gerente;
using imobiliaria.imobiliaria;
using imobiliaria.imovel;
using imobiliaria.menu;

namespace imobiliaria
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Menu menu = new Menu();
            Imobiliaria imobiliaria = new Imobiliaria("Imobiliaria fachada", "12345");
            Gerente gerente = new Gerente("Gabriel Bazante", "123456789", "12345678910", "2307", 1000000);
            
            imobiliaria.cadastrarFuncionario(gerente);

            menu.iniciar(imobiliaria);

            
        }
    }
}