using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Cliente.Models;
using WebApi_Cliente3.Models;

namespace WebApi_Cliente.Controllers
{
    public class ClienteController : ApiController
    {
        static readonly IClienteRepositorio repositorio = new ClienteRepositorio();

        public IEnumerable<Cliente> GetAllClientes()
        {
            return repositorio.GetAll();
        }

        public Cliente GetCliente(int id)
        {
            Cliente item = repositorio.Get(id); 
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        public IEnumerable<Cliente> GetClientesPorCidade(string cidade)
        {
            return repositorio.GetAll().Where(
                p => string.Equals(p.Cidade, cidade, StringComparison.OrdinalIgnoreCase));
        }

        public HttpResponseMessage PostCliente(Cliente item)
        {
            item = repositorio.Add(item);
            var response = Request.CreateResponse<Cliente>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void PutCliente(int id, Cliente cliente)
        {
            cliente.Id = id;
            if (!repositorio.Update(cliente))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public void DeleteCliente(int id)
        {
            Cliente item = repositorio.Get(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repositorio.Remove(id);
        }
    }
}
