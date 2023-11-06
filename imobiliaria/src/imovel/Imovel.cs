using System;
using imobiliaria.funcionario.corretor;

namespace imobiliaria.imovel
{
    public class Imovel
    {
        private String rua;
        private String bairro;
        private String numero;
        private String complemento;
        private String cep;
        private Double preco;
        private CorretorCaptador corretorCaptador;
        private bool isVendido;
        
        public Imovel(string rua, string bairro, string numero, string complemento, string cep, double preco)
        {
            this.rua = rua;
            this.bairro = bairro;
            this.numero = numero;
            this.complemento = complemento;
            this.cep = cep;
            this.preco = preco;
            this.isVendido = false;
        }

        public Imovel(string rua, string bairro, string numero, string complemento, string cep, double preco, CorretorCaptador corretorCaptador)
        {
            this.rua = rua;
            this.bairro = bairro;
            this.numero = numero;
            this.complemento = complemento;
            this.cep = cep;
            this.preco = preco;
            this.corretorCaptador = corretorCaptador;
            this.isVendido = false;
        }

        public string Rua
        {
            get => rua;
            set => rua = value;
        }

        public string Bairro
        {
            get => bairro;
            set => bairro = value;
        }

        public string Numero
        {
            get => numero;
            set => numero = value;
        }

        public string Complemento
        {
            get => complemento;
            set => complemento = value;
        }

        public string Cep
        {
            get => cep;
            set => cep = value;
        }

        public double Preco
        {
            get => preco;
            set => preco = value;
        }

        public CorretorCaptador CorretorCaptador
        {
            get => corretorCaptador;
            set => corretorCaptador = value;
        }

        public bool IsVendido
        {
            get => isVendido;
            set => isVendido = value;
        }
    }
}