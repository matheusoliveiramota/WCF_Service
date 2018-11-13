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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void listaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormCliente formCliente = new ChildFormCliente();
            formCliente.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteService.ClientServiceClient clientRequest = new ClienteService.ClientServiceClient();
                ClienteService.Cliente novoCliente = new ClienteService.Cliente();

                novoCliente.Nome = txtNome.Text;
                novoCliente.Cpf = txtCpf.Text;

                clientRequest.AdicionarCliente(novoCliente);
                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            ClienteService.ClientServiceClient client = new ClienteService.ClientServiceClient();
            ClienteService.Cliente cliente = client.GetClienteByName(txtNome.Text);
            if (cliente != null)
                txtCpf.Text = cliente.Cpf;
            else
                MessageBox.Show("Cliente inexistente!");
        }
    }
}
