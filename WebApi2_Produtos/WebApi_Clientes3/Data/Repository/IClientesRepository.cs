using System.Collections.Generic;
using WebApi_Cliente3.Models;

namespace WebApi_Clientes3.Data.Repository
{
    public interface IClientesRepository
    {

        void Adicionar(Cliente cliente);

        void Atualizar(string id, Cliente clienteAtualizado);

        IEnumerable<Cliente> Buscar();

        Cliente Buscar(string id);

        void Remover(string id);

    }
}
