using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FomClient
{
    public partial class ChildFormCliente : Form
    {
        public ChildFormCliente()
        {
            InitializeComponent();
        }
        private void ChildFormCliente_Load(object sender, EventArgs e)
        {
            ClienteService.ClientServiceClient clientRequest = new ClienteService.ClientServiceClient();
            dgvClientes.DataSource = clientRequest.GetClientes();
        } 
    }
}
