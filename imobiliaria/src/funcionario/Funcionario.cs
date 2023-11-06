using System;
using imobiliaria.equipe;

namespace imobiliaria.funcionario
{
    public abstract class Funcionario
    {
        protected String nome;
        protected String rg;
        protected String cpf;
        protected String codigo;
        protected Double salarioFixo = 0.0;
        protected Equipe equipeAtual;

        public Funcionario(string nome, string rg, string cpf, string codigo)
        {
            this.nome = nome;
            this.rg = rg;
            this.cpf = cpf;
            this.codigo = codigo;
        }

        protected Funcionario(string nome, string rg, string cpf, string codigo, double salarioFixo)
        {
            this.nome = nome;
            this.rg = rg;
            this.cpf = cpf;
            this.codigo = codigo;
            this.salarioFixo = salarioFixo;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public string Rg
        {
            get => rg;
            set => rg = value;
        }

        public string Cpf
        {
            get => cpf;
            set => cpf = value;
        }

        public string Codigo
        {
            get => codigo;
            set => codigo = value;
        }

        public double SalarioFixo
        {
            get => salarioFixo;
            set => salarioFixo = value;
        }

        public Equipe EquipeAtual
        {
            get => equipeAtual;
            set => equipeAtual = value;
        }
    }
}