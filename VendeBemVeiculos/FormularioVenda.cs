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
        //atributos e propriedades
        private HashSet<Veiculo> filtro = new HashSet<Veiculo>(); //funcionará como um filtro dos veículos até chegar no desejado
        public Vendedor Vendedor { get; private set; }  //vendedor precisa ser não nulo para ir pro formulário de pagamentos
        public Veiculo Veiculo { get; private set; }    //veículo precisa ser não nulo para ir pro formulário de pagamentos
        public Cliente Cliente { get; set; }            //cliente precisa ser não nulo para ir pro formulário de pagamentos
        private FormularioPrincipal formPrincipal;      //formulário principal
        private int radioButton = 0;                    //indica se o radioButton será para um filtro de carros/motos

        //Construtor que pode aceitar veículo
        public FormularioVenda(FormularioPrincipal formPrincipal, Veiculo veiculo = null, Vendedor vendedor = null)
        {
            this.formPrincipal = formPrincipal;
            this.Veiculo = veiculo;
            this.Vendedor = vendedor;
            InitializeComponent();
        }

        //O que acontece quando o formulário carrega
        private void FormularioVenda_Load(object sender, EventArgs e)
        {
           
            //Verifica se o construtor possui vendedor
            if(this.Vendedor != null)
            {
                comboVendedor.Text = this.Vendedor.ToString();
            }

            //Passa os vendedores para o combobox de vendedores
            foreach(Vendedor v in FormularioPrincipal.Vendedores)
            {
                comboVendedor.Items.Add(v);
            }

            //Verifica se o construtor trouxe um veículo já selecionado
            if (this.Veiculo != null)
            {
                //Carrega os dados do veículo nos campos
                comboModelo.Text = this.Veiculo.Modelo;
                comboMarca.Text = this.Veiculo.Marca;
                comboAno.Text = this.Veiculo.Ano;
                labelValor.Text = Convert.ToString(this.Veiculo.Preco);
            }
            //no padrão, o carro fica selecionado
            else
            {
                radioCarro.Checked = true;
            }
        }

        //Seleção de RadioButtons
        private void radioCarro_CheckedChanged(object sender, EventArgs e)
        {
            //Quando selecionado, o Radio Button deve indicar que foi selecionado com o int correto, realizar o filtro e limpar os campos
            radioButton = 0;
            FiltrarVeiculo(radioButton, true, true, true);
            Limpar(true, true);
        }
        private void radioMoto_CheckedChanged(object sender, EventArgs e)
        {
                //Quando selecionado, o Radio Button deve indicar que foi selecionado com o int correto, realizar o filtro e limpar os campos
                radioButton = 1;
                FiltrarVeiculo(radioButton, true, true, true);
                Limpar(true, true);           
        }

        //Mudanças no ComboBox
        private void ComboVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seleciona diretamente um vendedor a partir do combo box
            this.Vendedor = (Vendedor)comboVendedor.SelectedItem;
        }
        private void comboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //realiza um filtro para o tipo de veículo e outro para a marca, além de limpar os campos do modelo, ano e preço
            FiltrarVeiculo(radioButton, false, true, true);
            Limpar(true, false);
        }
        private void comboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //realiza um filtro para o tipo de veículo, para a marca e para o modelo, além de limpar os campos do ano e preço
            FiltrarVeiculo(radioButton, false, false, true);
            Limpar(false, false);
        }
        private void comboAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cria um veículo genérico que possa receber o objeto final filtrado
            Veiculo selecionado = new Carro("", "", "", 0, 0);
            //obtém o ano selecionado e realiza o filtro
            string ano = (string)comboAno.SelectedItem;
            var filtroAno = this.filtro.Where(v => v.Ano == ano);
            //só pode existir um objeto com todas as características do filtro, por isso o seleciono a partir da posição zero
            selecionado = filtroAno.ElementAt(0);
            //passa o preço para o campo apropriado e coloca o veículo como propriedade da classe
            labelValor.Text = "R$" + selecionado.Preco;
            this.Veiculo = selecionado;

        }
       

        //Selção de botões
        private void botaoBuscaCliente_Click(object sender, EventArgs e)
        {
            //Instancia um formulário que retornará o cliente selecionado
            FormularioCliente formCliente = new FormularioCliente(this);
            formCliente.Show();
        }
        private void botaoPagamento_Click(object sender, EventArgs e)
        {
            //Deve verificar se todos os dados foram fornecidos corretamente antes de instanciar o formulário da forma de pagamento
            if ((this.Vendedor != null) && (this.Veiculo != null) && (this.Cliente != null))
            {
                FormularioPagamento formPagamento = new FormularioPagamento(this);
                formPagamento.Show();
            }
            //Mensagem caso não tenha todos os dados
            else
            {
                MessageBox.Show("Informe todos os dados");
            }
        }
        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            //fecha esse formulário e retorna o principal
            this.formPrincipal.Show();
            this.Close();
        }

        //Outros métodos         
        private void FiltrarVeiculo(int radioButton, bool filtroRadio, bool filtroMarca, bool filtroModelo)
        {         
            //Primeiro: o atributo do filtro deve ser limpo para que os itens corretos sejam adicionados a ele
            this.filtro.Clear();
            //Essa primeira peneira retorna o tipo de veículo dependendo da seleção do radioButton
            foreach (Veiculo v in FormularioPrincipal.Veiculos)
            { 
                if (radioButton == 0)
                {
                    if (v is Carro)
                    {
                        this.filtro.Add(v);
                    }
                }
                else if (radioButton == 1)
                {
                    if (v is Moto)
                    {
                        this.filtro.Add(v);

                    }
                }
            }
            //Esse filtro será verdadeiro caso deseje que não tenha itens no comboMarca
            if (filtroRadio)
            {
                comboMarca.Items.Clear();
            }
            //Passa os veículos da primeira peneira para o comboMarca
            foreach (Veiculo v in this.filtro)
            {
                if (!(comboMarca.Items.Contains(v.Marca)))
                {
                    comboMarca.Items.Add(v.Marca);
                }
            }
            
            //Obtém a string da marca selecionada
            string marca = (string)comboMarca.SelectedItem;
            //Realiza a segunda peneira: apenas veículos da marca selecionada passam
            var sohMarca = this.filtro.Where(v => v.Marca == marca).ToList();
            //Limpa o filtro para que adicionar os itens nele novamente
            this.filtro.Clear();
            //Se a filtroMarca for Verdadeira, apagará os itens de comboModelo. Não desejamos que isso aconteça caso um novo modelo ou ano seja selecionado.
            if (filtroMarca)
            {
                comboModelo.Items.Clear();
            }
            //Passa os valores para o comboModelo
            foreach (Veiculo v in sohMarca)
            {
                this.filtro.Add(v);
                if (!(comboModelo.Items.Contains(v.Modelo)))
                {
                    comboModelo.Items.Add(v.Modelo);
                }
            }
            //Pega o modelo
            string modelo = (string)comboModelo.SelectedItem;
            //Realiza a terceira peneira
            var fsohModelo = this.filtro.Where(w => w.Modelo == modelo).ToList();
            //Limpa o filtro para que adicionar os itens nele novamente
            this.filtro.Clear();
            //Se a filtroModelo for Verdadeira, apagará os itens de comboAno. Não desejamos que isso aconteça caso um novo ano seja selecionado.
            if (filtroModelo)
            {
                comboAno.Items.Clear();
            }
            //Passa os valores para comboAno
            foreach (Veiculo v in fsohModelo)
            {
                this.filtro.Add(v);
                if (!(comboAno.Items.Contains(v.Ano)))
                {
                    comboAno.Items.Add(v.Ano);
                }
            }
            
            
        }
        private void Limpar(bool limpaModelo, bool limpaMarca)
        {
            //Método para limpar os campos necessários sempre que um novo filtro é selecionado
            comboAno.Text = "";
            labelValor.Text = "R$----";
            if (limpaModelo)
            {
                comboModelo.Text = "";
                if (limpaMarca)
                {
                    comboMarca.Text = "";
                }
            }
        }
        public void SelecionaCliente(Cliente cliente)
        {
            //Método para selecionar o cliente que pode ser acessado por outras classes
            this.Cliente = cliente;
            this.textoCliente.Text = this.Cliente.Nome;
        }

        

       

      
    }
}
