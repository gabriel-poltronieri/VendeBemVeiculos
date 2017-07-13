using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendeBemVeiculos
{
    public partial class FormularioNovoCliente : Form
    {
        FormularioCliente formCliente;
        public FormularioNovoCliente(FormularioCliente formCliente)
        {
            this.formCliente = formCliente;
            InitializeComponent();
        }

        private void BotaoCadastra_Click(object sender, EventArgs e)
        {
            if (TextoNome.Text == "" || TextoEndereco.Text == "")
            {
                MessageBox.Show("Complete os dados");
            }
            else
            {
                string nome = TextoNome.Text;
                if (TextoCpf.Text.Length != 11)
                {
                    MessageBox.Show("CPF deve conter 11 dígitos");
                }
                else
                {
                    string cpf = TextoCpf.Text;
                    if (10 < TextoTelefone.Text.Length || TextoTelefone.Text.Length > 11)
                    {
                        MessageBox.Show("Valor fora do tamanho do telefone. Não esqueça do código de área");
                    }
                    else
                    {
                        string telefone = TextoTelefone.Text;
                        string endereco = TextoEndereco.Text;
                        Cliente novoCliente = new Cliente(nome, cpf, telefone, endereco);
                        FormularioPrincipal.Clientes.Add(novoCliente);
                        formCliente.AtualizaLista();
                        this.Close();
                    }
                }
            }
        }

        private void FormularioNovoCliente_Load(object sender, EventArgs e)
        {
            TextoCpf.MaxLength = 11;
            TextoTelefone.MaxLength = 11;
        }

        private void BotaoCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
