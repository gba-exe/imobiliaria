using System;
using imobiliaria.imobiliaria;

namespace imobiliaria.menu
{
    public class Logica
    {
        public Boolean isCadastrado(String cpf, String codigo, Imobiliaria imobiliaria)
        {
            if (imobiliaria.getFuncionarioPorCpf(cpf) == null || imobiliaria.getFuncionarioPorCodigo(codigo) == null)
            {
                return false;
            }
            return true;
        }
    }
}