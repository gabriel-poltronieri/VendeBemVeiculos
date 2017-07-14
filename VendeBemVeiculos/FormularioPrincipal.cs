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
            //adicionando vendedores
            Vendedor joao = new Vendedor("Joao");
            Vendedor pedro = new Vendedor("Pedro");
            Vendedor carlos = new Vendedor("Carlos");

            vendedores = new List<Vendedor>();
            vendedores.Add(joao);
            vendedores.Add(pedro);
            vendedores.Add(carlos);

            //Adicionando veículos iniciais
            Veiculo spin = new Carro("Volkswagen", "Gol", "2015", 35000.0, 4);
            Veiculo honda = new Carro("Volkswagen", "Gol", "2013", 40000.0, 3);
            Veiculo uno = new Carro("Fiat", "Uno", "2012", 30000, 3);
            Veiculo palio = new Carro("Fiat", "Palio", "2013", 30000, 7);
            Veiculo fiesta = new Carro("Ford", "Fiesta", "2016", 40000, 2);
            Veiculo yamaha = new Moto("Yamaha", "XT660R", "2010", 20000, 4);
            Veiculo moto = new Moto("Honda", "CBR 450", "1995", 11000, 4);

            veiculos.Add(spin);
            veiculos.Add(honda);
            veiculos.Add(uno);
            veiculos.Add(palio);
            veiculos.Add(fiesta);
            Veiculos.Add(yamaha);
            Veiculos.Add(moto);

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
        
        private void botaoEstoque_Click(object sender, EventArgs e)
        {
            FormularioEstoque formEstoque = new FormularioEstoque(this);
            formEstoque.Show();
        }
    }
}
