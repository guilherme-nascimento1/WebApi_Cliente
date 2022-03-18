using MongoDB.Driver;
using System.Collections.Generic;
using WebApi_Cliente3.Models;
using WebApi_Clientes3.Data.Configurations;

namespace WebApi_Clientes3.Data.Repository
{
    public class ClienteRepository : IClientesRepository
    {
        private readonly IMongoCollection<Cliente> _items;

        public ClienteRepository(IDatabaseConfig databaseConfig)
        {
            var client = new MongoClient(databaseConfig.ConnectionString);
            var database = client.GetDatabase(databaseConfig.DatabaseName);

            _items = database.GetCollection<Cliente>("clientes");
        }

        public void Adicionar(Cliente cliente)
        {
            _items.InsertOne(cliente);
        }

        public void Atualizar(string id, Cliente clienteAtualizado)
        {
            _items.ReplaceOne(cliente => cliente.Id == id, clienteAtualizado);
        }

        public IEnumerable<Cliente> Buscar()
        {
            return _items.Find(cliente => true).ToList();
        }

        public Cliente Buscar(string id)
        {
            return _items.Find(cliente => cliente.Id == id).FirstOrDefault();
        }

        public void Remover(string id)
        {
            _items.DeleteOne(cliente => cliente.Id == id);
        }
    }
}

