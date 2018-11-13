using Passagens.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Passagens.Model;
using Passagens.DAO;

namespace Passagens.Service
{
    class ClienteService : IClientService
    {
        public void AdicionarCliente(Cliente cliente)
        {
            ClienteDAO dao = new ClienteDAO();
            dao.AdicionarCliente(cliente);
        }

        public Cliente GetClienteByName(string nome)
        {
            ClienteDAO dao = new ClienteDAO();
            return dao.GetClienteByName(nome);
        }

        public IEnumerable<Cliente> GetClientes()
        {
            ClienteDAO dao = new ClienteDAO();
            return dao.GetClientes();
        }
    }
}
