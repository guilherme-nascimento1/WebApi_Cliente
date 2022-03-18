using System;
using System.Collections.Generic;

namespace WebApi_Cliente.Models
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private List<Cliente> clientes = new List<Cliente>();
        private int _nextId = 1;

        public ClienteRepositorio()
        {
            Add(new Cliente
            {
                Nome = "Fabio",
                DataNascimento = "30/06/1960",
                Telefone = "11 44444-5555",
                Celular = "11 91111-5555",
                Endereco = "Rua Exemplo 123",
                Cidade = "São Caetano do Sul",
                RedesSociais = "fabio.com.br",
                CPF = "11111111-11",
                RG = "111111111-1"
            });

            Add(new Cliente
            {
                Nome = "Guilherme",
                DataNascimento = "30/06/1998",
                Telefone = "11 33333-5555",
                Celular = "11 92222-5555",
                Endereco = "Rua Exemplo 123",
                Cidade = "São Caetano do Sul",
                RedesSociais = "guilherme-nascimento-045642162",
                CPF = "11111111-11",
                RG = "111111111-1"
            });

            Add(new Cliente
            {
                Nome = "Gabriel",
                DataNascimento = "30/06/2000",
                Telefone = "11 5555-5555",
                Celular = "11 95555-5555",
                Endereco = "Rua Exemplo 123",
                Cidade = "Santo André",
                RedesSociais = "gabriel.com.br",
                CPF = "11111111-11",
                RG = "111111111-1"
            });

            Add(new Cliente
            {
                Nome = "Gustavo",
                DataNascimento = "30/06/2005",
                Telefone = "11 5555-5555",
                Celular = "11 95555-5555",
                Endereco = "Rua Exemplo 123",
                Cidade = "Sao Paulo",
                RedesSociais = "gustavo-nascimento.com",
                CPF = "11111111-11",
                RG = "111111111-1"
            });

            Add(new Cliente
            {
                Nome = "Guilherme",
                DataNascimento = "30/06/1998",
                Telefone = "11 5555-5555",
                Celular = "11 95555-5555",
                Endereco = "Rua Exemplo 123",
                Cidade = "São Caetano do Sul",
                RedesSociais = "guilherme-nascimento-045642162",
                CPF = "11111111-11",
                RG = "111111111-1"
            });

        }

        public Cliente Add(Cliente item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            clientes.Add(item);
            return item;
        }

        public Cliente Get(int id)
        {
            return clientes.Find(p => p.Id == id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return clientes;
        }

        public void Remove(int id)
        {
            clientes.RemoveAll(p => p.Id == id);
        }

        public bool Update(Cliente item)
        {
            if( item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = clientes.FindIndex(p => p.Id == item.Id);

            if(index == -1)
            {
                return false;
            }
            clientes.RemoveAt(index);
            clientes.Add(item);
            return true;
        }
    }
}