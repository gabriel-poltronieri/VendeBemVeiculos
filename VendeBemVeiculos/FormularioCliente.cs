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
    public partial class FormularioCliente : Form
    {
        //Atributos da classe
        private FormularioVenda formVenda;
        private Cliente cliente;
        //Construtor só recebe o formulário de vendas para acessar seu método
        public FormularioCliente(FormularioVenda formVenda) 
        {
            this.formVenda = formVenda;
            InitializeComponent();
        }
        //Quando carregar, limita o tamanho de caracteres que podem ser digitados no campo do CPF e atualiza a lista
        private void FormularioCliente_Load(object sender, EventArgs e)
        {
            TextoCpf.MaxLength = 11;
            AtualizaLista();
        }
        //Comportamento para quando um cliente for selecionado
        private void ListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //simplesmente define um novo cliente
            this.cliente = (Cliente)ListaClientes.SelectedItem;
        }
        //Comportamentos para quando apertar botões
        private void BotaoSeleciona_Click(object sender, EventArgs e)
        {
            //verifica se o cliente é nulo. Caso não seja, seleciona o cliente do formulario de venda e fecha esse formulário
            if (this.cliente != null)
            {
                this.formVenda.SelecionaCliente(this.cliente);
                this.Close();
            }
        }
        private void BotaoBusca_Click(object sender, EventArgs e)
        {
            //Pega o cpf digitado na busca
            string cpf = TextoCpf.Text;
            //Verifica se ele tem o tamanho correto
            if (cpf.Length != 11)
            {
                MessageBox.Show("O CPF deve conter 11 dígitos");
            }
            else
            {
                //Caso o cpf tenha o tamanho certo, deve-se colocar um filtro para encontrar o cliente
                var filtro = FormularioPrincipal.Clientes.Where(c => c.Cpf == cpf);
                try
                {
                    //Só existe um CPF para cada cliente. Se ele existir, ele será o elemento zero do filtro
                    Cliente selecionado = (Cliente)filtro.ElementAt(0);
                    //limpa a lista e mostra apenas o selecionado
                    this.ListaClientes.Items.Clear();
                    ListaClientes.Items.Add(selecionado);
                }
                catch
                {
                    //Se o cliente não for encontrado, não terá nenhum objeto em lista e um ArgumentOutOfRangeException será lançado
                    MessageBox.Show("Nenhum cliente com o CPF buscado");
                }

            }
        }
        private void BotaoNovo_Click(object sender, EventArgs e)
        {
            //Abre um formulário para adicionar um novo cliente
            FormularioNovoCliente formNovoCliente = new FormularioNovoCliente(this);
            formNovoCliente.Show();
        }
        private void BotaoExclui_Click(object sender, EventArgs e)
        {
            if (this.cliente != null)
            {
                FormularioPrincipal.Clientes.Remove(this.cliente);
                FormularioPrincipal.SalvarClientes();
                AtualizaLista();
            }
        }
        //Método para atualizar a lista
        public void AtualizaLista()
        {
            //Limpa a lista e adiciona todos os clientes salvos
            ListaClientes.Items.Clear();
            foreach (Cliente c in FormularioPrincipal.Clientes)
            {
                ListaClientes.Items.Add(c);
            }
        }

    }
}
