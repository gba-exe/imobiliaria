using System.Collections.Generic;
using imobiliaria.funcionario.corretor;

namespace imobiliaria.funcionario.gerente
{
    public class Gerente : Funcionario
    {
        private List<Corretor> subordinados = new List<Corretor>();
        
        public Gerente(string nome, string rg, string cpf, string codigo, double salarioFixo) : base(nome, rg, cpf, codigo, salarioFixo)
        {
        }

        public void adicionarSubordinado(Corretor corretor)
        {
            if (corretor != null)
            {
                subordinados.Add(corretor);
            }
        }

        public List<Corretor> Subordinados
        {
            get => subordinados;
            set => subordinados = value;
        }

        public string Nome1
        {
            get => nome;
            set => nome = value;
        }

        public string Rg1
        {
            get => rg;
            set => rg = value;
        }

        public string Cpf1
        {
            get => cpf;
            set => cpf = value;
        }

        public string Codigo1
        {
            get => codigo;
            set => codigo = value;
        }

        public double SalarioFixo1
        {
            get => salarioFixo;
            set => salarioFixo = value;
        }
    }
}