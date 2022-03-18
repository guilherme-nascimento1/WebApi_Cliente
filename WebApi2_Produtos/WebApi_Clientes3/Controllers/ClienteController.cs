using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi_Cliente3.Models;
using WebApi_Clientes3.Data.Repository;
using WebApi_Clientes3.Models.InputModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi_Clientes3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private IClientesRepository _clientesRepository;

         public ClienteController(IClientesRepository clientesRepository)
        {
            _clientesRepository = clientesRepository;
        }


        // GET: api/clientes
        [HttpGet]
        public IActionResult Get()
        {
            var clientes = _clientesRepository.Buscar();
            return Ok(clientes);
        }

        // GET api/clientes/{id}
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var cliente = _clientesRepository.Buscar(id);

            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        // POST api/clientes
        [HttpPost]
        public IActionResult Post([FromBody] ClienteInputModel novoCliente)
        {
            var clientes = new Cliente(novoCliente.Nome, novoCliente.DataNascimento, novoCliente.Telefone, novoCliente.Celular, novoCliente.Endereco,
              novoCliente.Cidade, novoCliente.RedesSociais, novoCliente.CPF, novoCliente.RG);

            _clientesRepository.Adicionar(clientes);

            return Created("", clientes);
        }

        // PUT api/clientes/{id}
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] ClienteInputModel clienteAtualizado)
        {
            var clientes = _clientesRepository.Buscar(id);

            if (clientes == null)
                return NotFound();

            clientes.AtualizarCliente(clienteAtualizado.Nome, clienteAtualizado.Endereco, clienteAtualizado.Telefone, clienteAtualizado.Celular, 
                clienteAtualizado.Cidade);

            _clientesRepository.Atualizar(id, clientes);

            return Ok(clientes);
        }

        // DELETE api/clientes/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var clientes = _clientesRepository.Buscar(id);

            if (clientes == null)
                return NotFound();

            _clientesRepository.Remover(id);

            return NoContent();
        }
    }
}
