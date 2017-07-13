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

            veiculos.Add(spin);
            veiculos.Add(honda);
            veiculos.Add(uno);
            veiculos.Add(palio);
            veiculos.Add(fiesta);
            //adiciona clientes inciais
            Cliente rafael = new Cliente("Rafael", "14523698769", "11997845687", "Rua Tanto faz, 100");
            Cliente fabio = new Cliente("Fabrio", "14523965874", "11997863789", "Rua Tanto faz, 23");
            Cliente fabricio = new Cliente("Fabricio", "14536956622", "11997841234", "Rua Tanto faz, 45");
            clientes.Add(rafael);
            clientes.Add(fabio);
            clientes.Add(fabricio);

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
        
        private void botaoEstoque_Click(object sender, EventArgs e)
        {
            FormularioEstoque formEstoque = new FormularioEstoque(this);
            formEstoque.Show();
        }
    }
}
