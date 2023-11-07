using System;
using System.Collections.Generic;
using imobiliaria.equipe;
using imobiliaria.funcionario;

namespace imobiliaria.imobiliaria
{
    public class Imobiliaria
    {
        private string nome;
        private string cnpj;
        private List<Equipe> equipes;
        private List<Funcionario> funcionarios;

        public Imobiliaria(string nome, string cnpj)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.funcionarios = new List<Funcionario>();
        }

        public void cadastrarFuncionario(Funcionario funcionario)
        {
            if (funcionario != null)
            {
                funcionarios.Add(funcionario);
            }
        }

        public Funcionario getFuncionarioPorCpf(String cpf)
        {
            foreach (Funcionario funcionarioAtual in funcionarios)
            {
                if (funcionarioAtual.Cpf.Equals(cpf))
                {
                    return funcionarioAtual;
                }
            }

            return null;
        }
        
        public Funcionario getFuncionarioPorCodigo(String codigo)
        {
            foreach (Funcionario funcionarioAtual in funcionarios)
            {
                if (funcionarioAtual.Codigo.Equals(codigo))
                {
                    return funcionarioAtual;
                }
            }

            return null;
        }
    }
}