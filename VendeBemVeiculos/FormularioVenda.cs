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

        //private HashSet<Veiculo> filtroVeiculo = new HashSet<Veiculo>();
       private HashSet<Veiculo> filtro = new HashSet<Veiculo>();
        //private HashSet<Veiculo> filtroModelo = new HashSet<Veiculo>();

        public Vendedor Vendedor { get; private set; }
        public Veiculo Veiculo { get; private set; }
        public Cliente Cliente { get; set; }
        public bool selecionouForma = false;

        private FormularioPrincipal formPrincipal;
        


        public FormularioVenda(FormularioPrincipal formPrincipal, Veiculo veiculo = null)
        {
            this.formPrincipal = formPrincipal;
            this.Veiculo = veiculo;
            InitializeComponent();
        }
        
        

        private void FormularioVenda_Load(object sender, EventArgs e)
        {

            this.formPrincipal.Hide();
            
            //Definindo a propriedade como nula até que um vendedor seja selecionado
            this.Vendedor = null;
            //Passa os vendedores para o combobox de vendedores
            foreach(Vendedor v in FormularioPrincipal.Vendedores)
            {
                comboVendedor.Items.Add(v);
            }

            if (this.Veiculo != null)
            {
                comboModelo.Text = this.Veiculo.Modelo;
                comboMarca.Text = this.Veiculo.Marca;
                comboAno.Text = this.Veiculo.Ano;
                labelValor.Text = Convert.ToString(this.Veiculo.Preco);

            }

            radioCarro.Checked = true;



            
            comboPagamento.Items.Add("Em Dinheiro");
            comboPagamento.Items.Add("Débito");
            comboPagamento.Items.Add("Crédito");
        }

        public void Atualiza()
        {
            comboMarca.Items.Clear();
            comboMarca.Text = "";
            comboModelo.Items.Clear();
            comboModelo.Text = "";
            comboAno.Items.Clear();
            comboAno.Text = "";
            labelValor.Text = "R$----";

            foreach (Veiculo v in this.filtro)
            {
                if (!(comboMarca.Items.Contains(v.Marca)))
                {
                    comboMarca.Items.Add(v.Marca);
                }
            }
            
        }

        public void SelecionaCliente(Cliente cliente)
        {
            this.Cliente = cliente;
            this.textoCliente.Text = this.Cliente.Nome;
        }

        private void ComboVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Vendedor = (Vendedor)comboVendedor.SelectedItem;
        }


        private void comboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboModelo.Items.Clear();
            comboModelo.Text = "";
            comboAno.Items.Clear();
            comboAno.Text = "";
            labelValor.Text = "R$----";
            string marca = (string)comboMarca.SelectedItem;
            var filtroMarca = this.filtro.Where(v => v.Marca == marca).ToList();
            this.filtro.Clear();
            foreach(Veiculo v in filtroMarca)
            {
                this.filtro.Add(v);
                if (!(comboModelo.Items.Contains(v.Modelo)))
                {
                    comboModelo.Items.Add(v.Modelo);
                }
            }
         
        }

        private void comboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboAno.Items.Clear();
            comboAno.Text = "";
            labelValor.Text = "R$----";


            string modelo = (string)comboModelo.SelectedItem;
            var filtroModelo = this.filtro.Where(w => w.Modelo == modelo).ToList();
            this.filtro.Clear();
            foreach (Veiculo v in filtroModelo)
            {
                this.filtro.Add(v);
                if (!(comboAno.Items.Contains(v.Ano)))
                {
                    comboAno.Items.Add(v.Ano);
                }
            }
            
        }

        private void comboAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            Veiculo selecionado = new Carro("","","",0,0);
            string ano = (string)comboAno.SelectedItem;
            var filtroAno = this.filtro.Where(v => v.Ano == ano);
            selecionado = filtroAno.ElementAt(0);

            labelValor.Text = "R$" + selecionado.Preco ;
            this.Veiculo = selecionado;
            
        }

        private void botaoPagamento_Click(object sender, EventArgs e)
        {
            if ((this.Vendedor != null) && (this.Veiculo != null) && (this.Cliente != null) && (selecionouForma))
            {
                FormularioPagamento formPagamento = new FormularioPagamento(this,comboPagamento.Text);
                formPagamento.Show();
            }
            else
            {
                MessageBox.Show("Informe todos os dados");
            }
        }

       
        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.formPrincipal.Show();
            this.Close();
        }

        private void botaoBuscaCliente_Click(object sender, EventArgs e)
        {
            FormularioCliente formCliente = new FormularioCliente(this);
            formCliente.Show();
        }

        private void comboPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecionouForma = true;
        }

        private void radioCarro_CheckedChanged(object sender, EventArgs e)
        {
            this.filtro.Clear();

            foreach(Veiculo v in FormularioPrincipal.Veiculos)
            {
                if(v is Carro)
                {
                    this.filtro.Add(v);
                }
            }

            Atualiza();
        }

        private void radioMoto_CheckedChanged(object sender, EventArgs e)
        {
            this.filtro.Clear();
            foreach (Veiculo v in FormularioPrincipal.Veiculos)
            {
                if (v is Moto)
                {
                    this.filtro.Add(v);
                }
            }

            Atualiza();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
