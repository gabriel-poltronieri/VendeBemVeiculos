using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendeBemVeiculos
{
    public partial class FormularioPrincipal : Form
    {
        //Atributos da Classe
        private static List<Vendedor> vendedores = new List<Vendedor>();
        private static HashSet<Veiculo> veiculos = new HashSet<Veiculo>();
        private static HashSet<Cliente> clientes = new HashSet<Cliente>();
        //Propriedades da classe
        public static List<Vendedor> Vendedores
        {
            get
            {
                return vendedores;
            }
        }
        public static HashSet<Veiculo> Veiculos
        {
            get
            {
                return veiculos;
            }
        }
        public static HashSet<Cliente> Clientes
        {
            get
            {
                return clientes;
            }
        }
        //Construtor apenas carrega a interface
        public FormularioPrincipal()
        {
            InitializeComponent();
        }
        //Ao carregar o formulário, carrega-se também os veiculos, clientes e vendedores
        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {            
            CarregarVendedores();
            CarregarVeiculos();
            CarregarClientes();
        }
        //Os botões tem a função de instanciar novos formulários
        private void BotaoVenda_Click(object sender, EventArgs e)
        {
            FormularioVenda formVenda = new FormularioVenda(this);
            formVenda.Show();
        }
        private void BotaoEstoque_Click(object sender, EventArgs e)
        {
            FormularioEstoque formEstoque = new FormularioEstoque(this);
            formEstoque.Show();
        }
        private void BotaoVendedores_Click(object sender, EventArgs e)
        {
            FormularioVendedores formVendedores = new FormularioVendedores(this);
            formVendedores.Show();
        }
        //Métodos para salvar novos objetos
        public static void SalvarClientes()
        {
            /*
             *O método verifica se existe algum cliente salva na hashset. Caso não tenha nenhum (o que pode ocorrer ao se excluir o último cliente), o arquivo 'Clientes' que existia
             * é excluído. Se houver algum cliente, o programa instancia uma Stream que irá criar um arquivo que recebe o nome de todos os cliente.
             * Os cliente são salvos em uma string com seus dados separados por '%' e os objetos de cliente separados por '\r\n'. Os dados são escreitos no arquivo com a ajuda do
             * StreamWriter
             * Depois disso, fecha o Stream e o StreamWriter
             */
            if (!(Clientes.Count == 0))
            {
                Stream clientes = File.Open("Clientes.txt", FileMode.Create);
                StreamWriter escritor = new StreamWriter(clientes);
                string todosClientes = "";
                foreach (Cliente c in Clientes)
                {
                    todosClientes += c.Nome + "%" + c.Cpf + "%" + c.Telefone + "%" + c.Endereco + "\r\n";
                }
                escritor.WriteLine(todosClientes);
                escritor.Close();
                clientes.Close();
            }
            else
            {
                File.Delete("Clientes.txt");
            }
        }
        public static void SalvarVeiculos()
        {
            /*
             *O método verifica se existe algum veículo salva na hashset. Caso não tenha nenhum (o que pode ocorrer ao se excluir o último veículo), o arquivo 'Estoque' que existia
             * é excluído. Se houver algum veiculo, o programa instancia uma Stream que irá criar um arquivo que recebe o nome de todos os veículos.
             * Os veículos são salvos em uma string com seus dados separados por '%' e os objetos de veículo separados por '\r\n'. Os dados são escreitos no arquivo com a ajuda do
             * StreamWriter
             * Depois disso, fecha o Stream e o StreamWriter
             */
            if (!(Veiculos.Count == 0))
            {
                FileStream veiculos = File.Open("Estoque.txt", FileMode.Create);
                StreamWriter escritor = new StreamWriter(veiculos);
                string todosVeiculos = "";
                foreach (Veiculo v in Veiculos)
                {
                    string tipo = "";
                    if (v is Carro)
                    {
                        tipo = "Carro";
                    }
                    else
                    {
                        tipo = "Moto";
                    }
                    todosVeiculos += tipo + "%" + v.Marca + "%" + v.Modelo + "%" + v.Ano + "%" + v.Preco + "%" + v.Quantidade + "\r\n";
                }
                escritor.WriteLine(todosVeiculos);
                escritor.Close();
                veiculos.Close();
            }
            else
            {
                File.Delete("Estoque.txt");
            }
        }
        public static void SalvarVendedores()
        {
            /*
             *O método verifica se existe algum vendedor salva na hashset. Caso não tenha nenhum (o que pode ocorrer ao se excluir o último vendedor), o arquivo 'Vendedores' que existia
             * é excluído. Se houver algum vendedor, o programa instancia uma Stream que irá criar um arquivo que recebe o nome de todos os vendedores.
             * Os vendedores são salvos em uma string com seus dados separados por '%' e os objetos de veículo separados por '\r\n'. Os dados são escreitos no arquivo com a ajuda do
             * StreamWriter
             * Depois disso, fecha o Stream e o StreamWriter
             */
            FileStream vendedores = File.Open("Vendedores.txt", FileMode.Create);
                StreamWriter escritor = new StreamWriter(vendedores);
                string todosVendedores = "";
                foreach (Vendedor v in Vendedores)
                {
                    todosVendedores += v.Nome + "%" + v.Registro  + "\r\n";
                }
                escritor.WriteLine(todosVendedores);
                escritor.Close();
                vendedores.Close();            
        }
        //Métodos para carregar dados
        private static void CarregarClientes()
        {
            /*
             * Verifica inicialmente se o arquivo txt existe. Se sim, divide seus dados em linhas com cada uma contendo os dados necessários para instanciar um objeto
             * Depois disso, o programa obtem os dados e instancia um objeto para cada conjunto de dados. Finalmente, o objeto é adisionado na hashset da classe
             */
            if (File.Exists("Clientes.txt"))
            {
                Stream clientes = File.Open("Clientes.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(clientes);
                string linha = leitor.ReadLine();
                while(linha != null && linha != "")
                {
                    string[] dados = linha.Split('%');
                    Cliente cliente = new Cliente(dados[0], dados[1], dados[2], dados[3]);
                    Clientes.Add(cliente);
                    linha = leitor.ReadLine();
                }

                leitor.Close();
                clientes.Close();
            }
        }
        private static void CarregarVeiculos()
        {
            /*
             * Verifica inicialmente se o arquivo txt existe. Se sim, divide seus dados em linhas com cada uma contendo os dados necessários para instanciar um objeto
             * Depois disso, o programa obtem os dados e instancia um objeto para cada conjunto de dados. Finalmente, o objeto é adisionado na hashset da classe
             */
            if (File.Exists("Estoque.txt"))
            {
                Stream veiculos = File.Open("Estoque.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(veiculos);
                string linha = leitor.ReadLine();
                while (linha != null && linha != "")
                {
                    Veiculo veiculo = new Carro("", "", "", 0, 0);
                    string[] dados = linha.Split('%');
                    if(dados[0] == "Carro")
                    {
                        veiculo = new Carro(dados[1], dados[2], dados[3], Convert.ToDouble(dados[4]), Convert.ToInt32(dados[5]));
                    }
                    else
                    {
                        veiculo = new Moto(dados[1], dados[2], dados[3], Convert.ToDouble(dados[4]), Convert.ToInt32(dados[5]));
                    }
                    Veiculos.Add(veiculo);
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                veiculos.Close();
            }
        }
        private static void CarregarVendedores()
        {
            /*
             * Verifica inicialmente se o arquivo txt existe. Se sim, divide seus dados em linhas com cada uma contendo os dados necessários para instanciar um objeto
             * Depois disso, o programa obtem os dados e instancia um objeto para cada conjunto de dados. Finalmente, o objeto é adisionado na hashset da classe
             */
            if (File.Exists("Vendedores.txt"))
            {
                Stream vendedores = File.Open("Vendedores.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(vendedores);
                string linha = leitor.ReadLine();
                while (linha != null && linha != "")
                {
                    string[] dados = linha.Split('%');
                    Vendedor vendedor = new Vendedor(dados[0], Convert.ToInt32(dados[1]));
                    Vendedores.Add(vendedor);
                    linha = leitor.ReadLine();
                }

                leitor.Close();
                vendedores.Close();
            }
        }
        //Método para registrar venda
        public static void RegistrarVenda(Vendedor vendedor, Cliente cliente, Veiculo veiculo)
        {
            string tipo = "";
            string data = DateTime.Today.ToString("dd/MM/yy");
            if (veiculo is Carro)
            {
                tipo = "Carro:     ";
            }
            else
            {
                tipo = "Moto:     ";
            }
            string venda = data  + "\r\n" + "Vendedor:     " + vendedor.Registro + "     " + vendedor.Nome + "\r\n";
            venda += "Cliente:     " + cliente.Nome + "\r\n";
            venda += tipo + veiculo.Marca + "     " + veiculo.Modelo + "       " + veiculo.Ano + "\r\n";
            try
            {
                File.AppendAllText("Vendas.txt", venda);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
