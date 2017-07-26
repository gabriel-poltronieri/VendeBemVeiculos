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
        RegistroDePessoas<Cliente> nossosClientes = new RegistroDePessoas<Cliente>();
        Cliente clienteSelecionado;
        private FormularioVenda formularioComDadosDeVenda;

        public FormularioCliente(FormularioVenda formulario)
        {
            InitializeComponent();
            this.formularioComDadosDeVenda = formulario;
        }

        private void FormularioCliente_Load(object sender, EventArgs e)
        {            
            LimitarOTamanhoDoCampoDeCPF();
            AtualizaAListaDeClientesPeloCPF();            
        }
        private void LimitarOTamanhoDoCampoDeCPF()
        {
            textoCpf.MaxLength = 11;
        }
        private void AtualizaAListaDeClientesPeloCPF(string cpf = null)
        {
            SortedSet<Cliente> clientesParaLista = SelecionaClientesParaLista(cpf);
            CarregarElementosNaLista(clientesParaLista);
        }
        private SortedSet<Cliente> SelecionaClientesParaLista(string cpf)
        {
            if (CpfEhNuloOuVazio(cpf))
            {
                return this.nossosClientes.ConjuntoDeDados;
            }
            FiltroDePessoa<Cliente> filtrodeCliente = new FiltroDePessoa<Cliente>(this.nossosClientes);
            return filtrodeCliente.FiltrarPeloDado(cpf);
        }
        private void CarregarElementosNaLista(SortedSet<Cliente> registroFiltrado)
        {
            this.listaClientes.Items.Clear();
            foreach (Cliente c in registroFiltrado)
            {
                this.listaClientes.Items.Add(c);
            }
        }
        private void botaoBusca_Click(object sender, EventArgs e)
        {
            string cpfDesejado = textoCpf.Text;
            AtualizaAListaDeClientesPeloCPF(cpfDesejado);
        }
        private void botaoSeleciona_Click(object sender, EventArgs e)
        {
            if (ExisteUmClienteSelecionado())
            {
                this.formularioComDadosDeVenda.SelecionarCliente(this.clienteSelecionado);
                FechaOFormulario();
            }
        }
        private void listaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.clienteSelecionado = (Cliente)listaClientes.SelectedItem;
        }
        
        private bool CpfEhNuloOuVazio(string cpf)
        {
            return (cpf == null) || (cpf=="");
        }
        private bool ExisteUmClienteSelecionado()
        {
            return this.clienteSelecionado != null;
        }
        private void FechaOFormulario()
        {
            this.Close();
        }

       
    }
}