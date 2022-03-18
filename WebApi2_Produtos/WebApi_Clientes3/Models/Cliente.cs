using System;

namespace WebApi_Cliente3.Models
{
    public class Cliente
    {

        public Cliente(string nome,string dataNascimento, string telefone, string celular, string endereco, string cidade, string redeSocial, string cpf, string rg)
        {
            Id = Guid.NewGuid().ToString();
            Nome = nome; 
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Celular = celular;            
            Endereco = endereco;
            Cidade = cidade;
            RedesSociais = redeSocial;
            CPF = cpf;
            RG = rg;
            
        }

        public string Id { get; private set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }

        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string RedesSociais { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }


        public void AtualizarCliente (string nome, string endereco, string telefone, string celular, string cidade)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Celular =celular;
            Cidade = cidade;
        }


    }
}