using System;
using System.Collections.Generic;
using imobiliaria.imovel;

namespace imobiliaria.funcionario.corretor
{
    public class CorretorCaptador : Corretor
    {
        private List<Imovel> imoveisCaptados = new List<Imovel>();

        public CorretorCaptador(string nome, string rg, string cpf, string codigo) : base(nome, rg, cpf, codigo)
        {
        }

        public CorretorCaptador(string nome, string rg, string cpf, string codigo, double comissao) : base(nome, rg,
            cpf, codigo, comissao)
        {
        }

        public CorretorCaptador(string nome, string rg, string cpf, string codigo, double salarioFixo, double comissao)
            : base(nome, rg, cpf, codigo, salarioFixo, comissao)
        {
        }

        public void captarImovel(Imovel imovel)
        {
            if (imovel != null)
            {
             imoveisCaptados.Add(imovel);   
            }
        }

        public double getValorCaptado()
        {
            double valorCaptado = 0.0;

            foreach (Imovel imovelAtual in imoveisCaptados)
            {
                valorCaptado += imovelAtual.Preco;
            }

            return valorCaptado;
        }
        
        public override double getSalario()
        {
            double salario = 0.0;

            salario = comissao * this.getValorCaptado() + salarioFixo;
            
            return salario;
        }

        public override void getRelatorio()
        {
            Console.Write($@"
===============================================================================================================
| Nome: {this.Nome}
===============================================================================================================
| Quantidade de imoveis captados: {this.imoveisCaptados.Count}                            
| Valor captado: {this.getValorCaptado():C}                            
| Taxa de comissao: {this.Comissao * 100:0.0}%
| Salario Fixo: {this.SalarioFixo:C}
===============================================================================================================
| Salario Final: {this.getSalario():C}
===============================================================================================================
");
        }
    }
}