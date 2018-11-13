using Passagens.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens.DAO
{
    class ClienteDAO
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public Cliente GetClienteByName(string nome)
        {
            Cliente buscaCliente = clientes.Where(c => c.Nome == nome).FirstOrDefault();
            return buscaCliente;
        }

        public IEnumerable<Cliente> GetClientes()
        {
            return clientes;
        }
    }
}
