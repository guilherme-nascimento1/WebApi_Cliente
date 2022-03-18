namespace WebApi_Cliente.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }

        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string RedesSociais { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        
    }
}