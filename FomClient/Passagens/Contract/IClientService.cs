using Passagens.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Passagens.Contract
{
    [ServiceContract]
    interface IClientService
    {
        [OperationContract]
        Cliente GetClienteByName(string nome);

        [OperationContract]
        void AdicionarCliente(Cliente cliente);

        [OperationContract]
        IEnumerable<Cliente> GetClientes();
    }
}
