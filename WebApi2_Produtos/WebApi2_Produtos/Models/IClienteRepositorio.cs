using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Cliente3.Models
{
    public interface IClienteRepositorio
    {
        IEnumerable<Cliente> GetAll();
        Cliente Get(int id);
        Cliente Add(Cliente item);
        void Remove(int id);
        bool Update(Cliente item);
    }
}
