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
        private static List<Vendedor> vendedores = new List<Vendedor>();
        private static HashSet<Veiculo> veiculos = new HashSet<Veiculo>();
        private static HashSet<Cliente> clientes = new HashSet<Cliente>();

        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void BotaoVenda_Click(object sender, EventArgs e)
        {
            FormularioVenda formVenda = new FormularioVenda(this);
            formVenda.Show();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            CarregarVendedores();
                        
            CarregarVeiculos();

            CarregarClientes();
        }

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

        public static void SalvarClientes()
        {
            if (!(Clientes.Count == 0))
            {
                FileStream clientes = File.Open("Clientes.txt", FileMode.Create);
                StreamWriter escritor = new StreamWriter(clientes);
                string todosClientes = "";
                foreach (Cliente c in Clientes)
                {
                    todosClientes += c.Nome + "%" + c.Cpf + "%" + c.Telefone + "%" + c.Endereco + "\n";
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
            if (!(Veiculos.Count == 0))
            {
                FileStream veiculos = File.Open("Veiculos.txt", FileMode.Create);
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
                    todosVeiculos += tipo + "%" + v.Marca + "%" + v.Modelo + "%" + v.Ano + "%" + v.Preco + "%" + v.Quantidade + "\n";
                }
                escritor.WriteLine(todosVeiculos);
                escritor.Close();
                veiculos.Close();
            }
            else
            {
                File.Delete("Veiculos.txt");
            }
        }

        public static void SalvarVendedores()
        {
                FileStream vendedores = File.Open("Vendedores.txt", FileMode.Create);
                StreamWriter escritor = new StreamWriter(vendedores);
                string todosVendedores = "";
                foreach (Vendedor v in Vendedores)
                {
                    todosVendedores += v.Nome + "%" + v.Senha + "%" + v.Registro + "%" + "\n";
                }
                escritor.WriteLine(todosVendedores);
                escritor.Close();
                vendedores.Close();            
        }

        private static void CarregarClientes()
        {
            //Verifica inicialmente se o arquivo txt existe
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
            //Verifica inicialmente se o arquivo txt existe
            if (File.Exists("Veiculos.txt"))
            {
                Stream veiculos = File.Open("Veiculos.txt", FileMode.Open);
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
            //Verifica inicialmente se o arquivo txt existe
            if (File.Exists("Vendedores.txt"))
            {
                Stream vendedores = File.Open("Vendedores.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(vendedores);
                string linha = leitor.ReadLine();
                while (linha != null && linha != "")
                {
                    string[] dados = linha.Split('%');
                    Vendedor vendedor = new Vendedor(dados[0], dados[1], Convert.ToInt32(dados[2]));
                    Vendedores.Add(vendedor);
                    linha = leitor.ReadLine();
                }

                leitor.Close();
                vendedores.Close();
            }
        }

        private void botaoEstoque_Click(object sender, EventArgs e)
        {
            FormularioEstoque formEstoque = new FormularioEstoque(this);
            formEstoque.Show();
        }

        private void botaoVendedores_Click(object sender, EventArgs e)
        {
            FormularioVendedores formVendedores = new FormularioVendedores();
            formVendedores.Show();
        }

        public static void RegistrarVenda(Vendedor vendedor, Cliente cliente, Veiculo veiculo)
        {
            string tipo = "";
            string data = DateTime.Today.ToString("dd-MM-yy");
            string nome = data + "Vendas.txt";
            if (veiculo is Carro)
            {
                tipo = "Carro:     ";
            }
            else
            {
                tipo = "Moto:     ";
            }
            Stream vendas = File.Open(nome, FileMode.Create);            
            StreamWriter escritor = new StreamWriter(vendas);
            string venda = data  + "\n" + "Vendedor:     " + vendedor.Registro + "     " + vendedor.Nome + "\n";
            venda += "Cliente:     " + cliente.Nome + "\n";
            venda += tipo + veiculo.Marca + "     " + veiculo.Modelo + "       " + veiculo.Ano + "\n";
            escritor.Write(venda);
            escritor.Close();
            vendas.Close();
        }
    }
}
