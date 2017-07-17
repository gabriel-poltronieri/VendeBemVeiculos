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
        private FormularioCliente formCliente;
        //Construtor recebe o formulario de clientes
        public FormularioNovoCliente(FormularioCliente formCliente)
        {
            this.formCliente = formCliente;
            InitializeComponent();
        }
        //O que fazer ao carregar o formulário
        private void FormularioNovoCliente_Load(object sender, EventArgs e)
        {
            //limita o tamanho do cpf e do telefone
            TextoCpf.MaxLength = 11;
            TextoTelefone.MaxLength = 11;
        }
        //Funcionalidade dos botões
        private void BotaoCadastra_Click(object sender, EventArgs e)
        {
            //verificar se os campos "Nome" e "Endereço" estão vazios
            if (TextoNome.Text == "" || TextoEndereco.Text == "")
            {
                MessageBox.Show("Complete os dados");
            }
            else
            {
                //salva o nome numa spring
                string nome = TextoNome.Text;
                //Verifica se o CPF tem tamanho válido
                if (TextoCpf.Text.Length != 11)
                {
                    MessageBox.Show("CPF deve conter 11 dígitos");
                }
                else
                {
                    //salva o cpf
                    string cpf = TextoCpf.Text;
                    //verifica se o telefone tem tamanho válido
                    if (10 > TextoTelefone.Text.Length || TextoTelefone.Text.Length > 11)
                    {
                        MessageBox.Show("Valor fora do tamanho do telefone. Não esqueça do código de área");
                    }
                    else
                    {
                        string telefone = TextoTelefone.Text;
                        string endereco = TextoEndereco.Text;
                        //Cria um usuário com os dados inseridos
                        Cliente novoCliente = new Cliente(nome, cpf, telefone, endereco);
                        //Se o usuário não existir no registro, salva ele na lista
                        if (!FormularioPrincipal.Clientes.Contains(novoCliente))
                        {
                            FormularioPrincipal.Clientes.Add(novoCliente);
                            FormularioPrincipal.SalvarClientes();
                            formCliente.AtualizaLista();
                            this.Close();
                        }
                        //caso contrário, apresenta uma mensagem de aviso
                        else
                        {
                            MessageBox.Show("CPF já cadastrado");
                        }
                    }
                }
            }
        }
        private void BotaoCancela_Click(object sender, EventArgs e)
        {
            //fecha o formulário
            this.Close();
        }
    }
}
