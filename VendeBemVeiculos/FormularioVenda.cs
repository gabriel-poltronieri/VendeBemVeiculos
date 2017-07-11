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
    public partial class FormularioVenda : Form
    {

        //Devinindo as Propriedades e Atributos
        HashSet<Veiculo> veiculos = new HashSet<Veiculo>();
        private HashSet<Veiculo> filtroVeiculo = new HashSet<Veiculo>();
        private HashSet<Veiculo> filtroMarca = new HashSet<Veiculo>();
        private HashSet<Veiculo> filtroModelo = new HashSet<Veiculo>();
        public Vendedor Vendedor { get; set; }
        public Veiculo Veiculo { get; set; }
        private FormularioPrincipal formPrincipal;


        public FormularioVenda(FormularioPrincipal formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }
        
        

        private void FormularioVenda_Load(object sender, EventArgs e)
        {

            this.formPrincipal.Hide();

            //adicionando vendedores
            Vendedor joao = new Vendedor("Joao");
            Vendedor pedro = new Vendedor("Pedro");
            Vendedor carlos = new Vendedor("Carlos");
            List<Vendedor> vendedores = new List<Vendedor>();
            vendedores.Add(joao);
            vendedores.Add(pedro);
            vendedores.Add(carlos);
            //Definindo a propriedade como nula até que um vendedor seja selecionado
            this.Vendedor = null;
            //Passa os vendedores para o combobox de vendedores
            foreach(Vendedor v in vendedores)
            {
                comboVendedor.Items.Add(v);
            }

            //Adicionando veículos iniciais
            Veiculo spin = new Carro("Volkswagen", "Gol", 2015,  35000.0, 4);
            Veiculo honda = new Carro("Volkswagen", "Gol", 2013, 40000.0, 3);
            Veiculo uno = new Carro("Fiat", "Uno", 2012, 30000, 3);
            Veiculo palio = new Carro("Fiat", "Palio", 2013, 30000, 7);
            Veiculo fiesta = new Carro("Ford", "Fiesta", 2016, 40000, 2);
            veiculos.Add(spin);
            veiculos.Add(honda);
            veiculos.Add(uno);
            veiculos.Add(palio);
            veiculos.Add(fiesta);
            //Definindo a propriedade como nula até que um veículo seja selecionado
            this.Veiculo = null;

            //coloca valores no combobox
            comboVeiculo.Items.Add("Carros");
            comboVeiculo.Items.Add("Motos");
        }



        private void comboVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarca.Items.Clear();
            comboMarca.Text = "";      
            comboModelo.Items.Clear();
            comboModelo.Text = "";
            comboAno.Items.Clear();
            comboAno.Text = "";
            filtroVeiculo.Clear();
            labelValor.Text = "R$----";


         
            foreach(Veiculo v in veiculos)
            {
                switch (comboVeiculo.SelectedIndex)
                {
                    case 0:
                        if(v is Carro)
                        {
                            filtroVeiculo.Add(v);
                            if (!(comboMarca.Items.Contains(v.Marca)))
                            {
                                comboMarca.Items.Add(v.Marca);
                            }
                        }
                        break;
                    case 1:
                        if(v is Moto)
                        {
                            filtroVeiculo.Add(v);
                            if (!(comboMarca.Items.Contains(v.Marca)))
                            {
                                comboMarca.Items.Add(v.Marca);
                            }
                        }
                        break;
                }
            }
            
        }

        private void comboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboModelo.Items.Clear();
            comboModelo.Text = "";
            comboAno.Items.Clear();
            comboAno.Text = "";
            filtroMarca.Clear();
            labelValor.Text = "R$----";


            string marca = (string)comboMarca.SelectedItem;
            foreach(Veiculo v in filtroVeiculo)
            {
                if(v.Marca == marca)
                {
                    filtroMarca.Add(v);
                    if (!(comboModelo.Items.Contains(v.Modelo)))
                    {
                        comboModelo.Items.Add(v.Modelo);
                    }
                }
            }
         
        }

        private void comboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboAno.Items.Clear();
            comboAno.Text = "";
            filtroModelo.Clear();
            labelValor.Text = "R$----";


            string modelo = (string)comboModelo.SelectedItem;
            foreach (Veiculo v in filtroMarca)
            {
                if (v.Modelo == modelo)
                {
                    filtroModelo.Add(v);
                    if (!(comboAno.Items.Contains(v.Ano)))
                    {
                        comboAno.Items.Add(v.Ano);
                    }
                }
            }
            
        }

        private void comboAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            Veiculo selecionado = new Carro("","",0,0,0);
            foreach (Veiculo v in filtroModelo)
            {
                if (v.Ano == (int)comboAno.SelectedItem)
                {
                    selecionado = v;
                }
            }

            labelValor.Text = "R$" + selecionado.Preco ;
            this.Veiculo = selecionado;
            
        }

        private void botaoPagamento_Click(object sender, EventArgs e)
        {
            if ((this.Vendedor != null) && (this.Veiculo != null))
            {
                FormularioPagamento formPagamento = new FormularioPagamento(this);
                formPagamento.ShowDialog();
            }
        }

        private void comboVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Vendedor = (Vendedor)comboVendedor.SelectedItem;
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.formPrincipal.Show();
            this.Close();
        }
    }
}
