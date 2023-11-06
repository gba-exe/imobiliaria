using System;
using System.Collections.Generic;
using imobiliaria.funcionario;
using imobiliaria.funcionario.gerente;

namespace imobiliaria.equipe
{
    public class Equipe
    {
        private String nome;
        private Gerente gerente;
        private List<Funcionario> membros = new List<Funcionario>();

        public Equipe(string nome, Gerente gerente)
        {
            this.nome = nome;
            this.gerente = gerente;
            gerente.EquipeAtual = this;
        }

        public void adicionarMembros(Funcionario funcionario)
        {
            if (funcionario != null)
            {
                foreach (Funcionario membroAtual in membros)
                {
                    if (membroAtual == funcionario)
                    {
                        return;
                    }
                }
                membros.Add(funcionario);
                funcionario.EquipeAtual = this;
            }
        }
        
        public void RemoverMembro(Funcionario funcionario)
        {
            if (funcionario != null)
            {
                foreach (Funcionario membroAtual in membros)
                {
                    if (membroAtual == funcionario)
                    {
                        membros.Remove(membroAtual);
                        return; 
                    }
                }
            }
        }

        public void mostrarMembros()
        {
            Console.WriteLine("===============================================================================================================");
            for (int i = 0; i < membros.Count; i++)
            {
                Console.Write($@"| Membro: {i+1}
|   - Nome: {membros[i].Nome}
|   - Codigo: {membros[i].Codigo}
");
            }
            Console.WriteLine("===============================================================================================================");
        }

        public void mostrarResumoDaEquipe()
        {
            Console.Write($@"
===============================================================================================================
| Nome: {nome}
| Gerente:
|   - Nome: {gerente.Nome}
|   - Codigo: {gerente.Codigo}
===============================================================================================================
");
            for (int i = 0; i < membros.Count; i++)
            {
                Console.Write($@"| Membro: {i+1}
|   - Nome: {membros[i].Nome}
|   - Codigo: {membros[i].Codigo}
");
            }
            Console.WriteLine("===============================================================================================================");
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public Gerente Gerente
        {
            get => gerente;
            set => gerente = value;
        }
    }
}