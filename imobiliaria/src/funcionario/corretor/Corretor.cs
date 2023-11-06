using System;

namespace imobiliaria.funcionario.corretor
{
    public abstract class Corretor : Funcionario
    {
        protected double comissao;
        
        public abstract double getSalario();

        public abstract void getRelatorio();
        
        protected Corretor(string nome, string rg, string cpf, string codigo) : base(nome, rg, cpf, codigo)
        {
        }
        
        protected Corretor(string nome, string rg, string cpf, string codigo, double comissao) : base(nome, rg, cpf, codigo)
        {
            this.comissao = comissao;
        }

        protected Corretor(string nome, string rg, string cpf, string codigo, double salarioFixo, double comissao) : base(nome, rg, cpf, codigo, salarioFixo)
        {
            this.comissao = comissao;
        }

        public double Comissao
        {
            get => comissao;
            set => comissao = value;
        }
    }
}