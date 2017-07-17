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
    public partial class FormularioEstoque : Form
    {
        //atributos da classe
        private FormularioPrincipal formPrincipal;
        private Veiculo veiculo;
        private HashSet<Veiculo> lista = new HashSet<Veiculo>();
        //construtor recebe o formulario principal
        public FormularioEstoque(FormularioPrincipal formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }
        //Ao carregar, altera o valor doradiochecked e, consequentemente, chama o método RadioCarro_CheckedChanged
        private void FormularioEstoque_Load(object sender, EventArgs e)
        {
            RadioCarro.Checked = true;
        }
        //Botões do formulário
        private void BotaoSeleciona_Click(object sender, EventArgs e)
        {
            //verifica se o atributo não é nulo para carregar o formulário de vendas com seus dados
            if (this.veiculo != null)
            {
                FormularioVenda formVenda = new FormularioVenda(this.formPrincipal, this.veiculo);
                formVenda.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um veículo");
            }
        }
        private void BotaoBusca_Click(object sender, EventArgs e)
        {
            //lista usada como filtro para retornar a busca
            HashSet<Veiculo> filtro = new HashSet<Veiculo>();
            //limpa os itens visíveis
            this.ListaVeiculos.Items.Clear();
            //verifica se algum texto foi inserido
            if (TextoModelo.Text != "")
            {
                //em caso positivo, realiza o filtro
                string modelo = TextoModelo.Text;
                var f = FormularioPrincipal.Veiculos.Where(v => v.Modelo == modelo);
                foreach(Veiculo v in f)
                {
                    filtro.Add(v);
                }
            }
            else
            {
                //caso nenhum texto tenha sido inserido, apresenta todos os itens dentro do radio selecionado
                filtro = this.lista;
            }
            //por fim, os valores são passados para serem vistos na lista
            foreach (Veiculo v in filtro)
            {
                ListaVeiculos.Items.Add(v);
            }
        }
        private void BotaoNovo_Click(object sender, EventArgs e)
        {
            //Abre o formulário para um novo veículo
            FormularioNovoVeiculo formNovoVeiculo = new FormularioNovoVeiculo(this);
            formNovoVeiculo.Show();
        }
        private void BotaoExclui_Click(object sender, EventArgs e)
        {
            //Elimina o veículo casso ele tenha sido selecionado
            if (this.veiculo != null)
            {
                this.veiculo.Exclui();
                //se não houver mais o objeto na hashset principal, elimina ela da lista também
                if (!(FormularioPrincipal.Veiculos.Contains(this.veiculo)))
                {
                    this.lista.Remove(this.veiculo);
                }
                MessageBox.Show("Veículo excluído");
                AtualizaLista();
            }
            else
            {
                MessageBox.Show("Selecione um veículo");
            }
        }
        private void BotaoCancela_Click(object sender, EventArgs e)
        {
            //fecha a janela
            this.Close();
        }
        //ao selecionar um item, a propriedade veiculo muda para seu valor
        private void ListaVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.veiculo = (Veiculo)ListaVeiculos.SelectedItem;
        }
        //Os dois RadioButton funcionam de forma similar, filtrando o tipo de veículo para carro ou moto
        private void RadioCarro_CheckedChange(object sender, EventArgs e)
        {
            this.lista.Clear();
            foreach (Veiculo v in FormularioPrincipal.Veiculos)
            {
                if (v is Carro)
                {
                    this.lista.Add(v);
                }
            }
            AtualizaLista();
        }
        private void RadioMoto_CheckedChanged(object sender, EventArgs e)
        {
            this.lista.Clear();
            foreach (Veiculo v in FormularioPrincipal.Veiculos)
            {
                if (v is Moto)
                {
                    this.lista.Add(v);
                }
            }
            AtualizaLista();
        }
        //Métodos da classe
        public void AtualizaLista()
        {
            //limpa os itens da lista e os carrega novamente
            ListaVeiculos.Items.Clear();
            foreach (Veiculo c in this.lista)
            {
                ListaVeiculos.Items.Add(c);
            }
        }
        public void AdicionaItem(Veiculo veiculo)
        {
            //adiciona um item na lista, que virá do formulario de novo veiculo
            this.lista.Add(veiculo);
        }
    }
}
