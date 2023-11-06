using System;
using System.Collections.Generic;
using imobiliaria.imovel;

namespace imobiliaria.funcionario.corretor
{
    public class CorretorVendedor : Corretor
    {
        private List<Imovel> imoveisVendidos = new List<Imovel>();

        public CorretorVendedor(string nome, string rg, string cpf, string codigo) : base(nome, rg, cpf, codigo)
        {
        }

        public CorretorVendedor(string nome, string rg, string cpf, string codigo, double comissao) : base(nome, rg,
            cpf, codigo, comissao)
        {
        }

        public CorretorVendedor(string nome, string rg, string cpf, string codigo, double salarioFixo, double comissao)
            : base(nome, rg, cpf, codigo, salarioFixo, comissao)
        {
        }

        public void venderImovel(Imovel imovel)
        {
            if (imovel != null)
            {       
                imoveisVendidos.Add(imovel);
                imovel.IsVendido = true;
            }
        }

        public double getValorVendido()
        {
            double valorVendido = 0.0;

            foreach (Imovel imovelAtual in imoveisVendidos)
            {
                valorVendido += imovelAtual.Preco;
            }
            
            return valorVendido;
        }

        public override double getSalario()
        {
            double salario = 0.0;

            salario = comissao * this.getValorVendido() + salarioFixo;
            
            return salario;
        }

        public override void getRelatorio()
        {
            Console.Write($@"
===============================================================================================================
| Nome: {this.Nome}
===============================================================================================================
| Quantidade de imoveis vendidos: {this.imoveisVendidos.Count}                            
| Valor vendido: {this.getValorVendido():C}                            
| Taxa de comissao: {this.Comissao * 100:0.0}%
| Salario Fixo: {this.SalarioFixo:C}
===============================================================================================================
| Salario Final: {this.getSalario():C}
===============================================================================================================
");

        }
    }
}