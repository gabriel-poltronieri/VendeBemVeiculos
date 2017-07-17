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
    public partial class FormularioVendedores : Form
    {
        FormularioPrincipal formPrincipal;
        Vendedor vendedor;
        //construtor recebe um formulario principal
        public FormularioVendedores(FormularioPrincipal formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }
        //Ao carregar, chama o método para atualizar a lista
        private void FormularioVendedores_Load(object sender, EventArgs e)
        {
            Atualiza();
        }
        //Quando um vendedor é selecionado, o atributo o recebe
        private void listaVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.vendedor = (Vendedor)listaVendedores.SelectedItem;
        }
        //Botões do formulário
        private void BotaoSeleciona_Click(object sender, EventArgs e)
        {
            //Deve verificar se um vendedor foi selecionado e em caso afirmativo, o carrega no formulário de vendas
            if (this.vendedor != null)
            {
                FormularioVenda formVenda = new FormularioVenda(this.formPrincipal, null, this.vendedor);
                formVenda.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um vendedor");
            }
        }
        private void BotaoBusca_Click(object sender, EventArgs e)
        {
            //instancia um int para ser usado nos blocos
            int registro = 0;
            //Pega o registro digitado na busca e verifica se ele é vazio
            if (textoRegistro.Text == "")
            {
                //caso seja, atualiza a lista de forma a mostrar todos os vendedores
                Atualiza();
            }
            else
            {
                try
                {
                    //pega o registro
                    registro = Convert.ToInt32(textoRegistro.Text);
                    //Realiza um filtro dos vendedores com base no registro digitado
                    var filtro = FormularioPrincipal.Vendedores.Where(c => c.Registro == registro);
                    try
                    {
                        //Só existe um Registro para cada vendedor. Se ele existir, ele será o elemento zero do filtro
                        Vendedor selecionado = (Vendedor)filtro.ElementAt(0);
                        //limpa a lista e mostra apenas o selecionado
                        this.listaVendedores.Items.Clear();
                        listaVendedores.Items.Add(selecionado);
                    }
                    catch
                    {
                        //Se o vendedor não for encontrado, não terá nenhum objeto em lista e um ArgumentOutOfRangeException será lançado
                        MessageBox.Show("Nenhum vendedor com o Registro buscado");
                    }
                }
                catch
                {
                    //trata os erros com uma mensagem para o usuário
                    MessageBox.Show("Entre com um valor numérico válido");
                }
            }
        }
        private void BotaoNovo_Click(object sender, EventArgs e)
        {
            //inicia um formulário de novo vendedor
            FormularioNovoVendedor formNovoVendedor = new FormularioNovoVendedor(this);
            formNovoVendedor.Show();
        }
        //método para carregar todos os vendedores da hashset
        public void Atualiza()
        {
            listaVendedores.Items.Clear();
            foreach (Vendedor v in FormularioPrincipal.Vendedores)
            {
                listaVendedores.Items.Add(v);
            }
        }


    }
}
