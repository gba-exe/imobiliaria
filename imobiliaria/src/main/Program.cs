using imobiliaria.equipe;
using imobiliaria.funcionario.corretor;
using imobiliaria.funcionario.gerente;
using imobiliaria.imovel;

namespace imobiliaria
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CorretorCaptador corretorCaptador =
                new CorretorCaptador("Gabriel", "123456789", "12345678910", "2307", 2500.0, 0.02);
            
            CorretorVendedor corretorVendedor =
                new CorretorVendedor("Vitor", "123456789", "12345678910", "0007", 3500.0, 0.02);

            Gerente gerente = new Gerente("Nicolas", "123456789", "12345678910", "0012", 100000000);

            Imovel imovel = 
                new Imovel("Professor Nobil Marcacini", "Jaragua", "219", "Casa 30", "02998030", 300000.0);

            corretorCaptador.getRelatorio();
            
            corretorCaptador.getRelatorio();

            corretorCaptador.getRelatorio();
            
            corretorVendedor.getRelatorio();
            
            corretorVendedor.venderImovel(imovel);
            
            corretorVendedor.getRelatorio();

            Equipe odiadoresDoVerstappen = new Equipe("Odiadores do Max Verstappen OFC", gerente);
            
            odiadoresDoVerstappen.adicionarMembros(corretorCaptador);
            odiadoresDoVerstappen.adicionarMembros(corretorVendedor);
            
            odiadoresDoVerstappen.mostrarMembros();
            odiadoresDoVerstappen.mostrarResumoDaEquipe();

            Menu menu = new Menu();

        }
    }
}