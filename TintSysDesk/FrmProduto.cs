using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TintSysClass;

namespace TintSysDesk
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtId.Text!=string.Empty)
            {
                if (chkDescontinuado.Checked)
                   Produto.Arquivar(int.Parse(txtId.Text));
                else
                   Produto.Restaurar(int.Parse(txtId.Text));
                CarregaGrid();
            }
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text == "...")
            {
                txtId.ReadOnly = false;
                txtId.Focus();
                btnBuscar.Text = "Obter";
            }
            else if(txtId.Text!=String.Empty) 
            { 
                txtId.ReadOnly = true;
                btnBuscar.Text = "...";
                var produto = Produto.ObterPorId(int.Parse(txtId.Text));
                if (produto.Id>0)
                {
                    txtDescricao.Text = produto.Descricao;
                    txtDesconto.Text=produto.Desconto.ToString();
                    txtPreco.Text = produto.Preco.ToString();
                    txtCodBar.Text = produto.CodBar;
                    cmbUnidade.Text = produto.Unidade;
                    chkDescontinuado.Checked = produto.Descontinuado;
                    btnEditar.Enabled = true;
                }

                
            }
        }

        private void btnArquivar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           Produto produto = new Produto(
             int.Parse(txtId.Text),
             txtDescricao.Text,
             cmbUnidade.Text,
             txtCodBar.Text,
             double.Parse(txtPreco.Text),
             double.Parse(txtDesconto.Text),
             chkDescontinuado.Checked
             );
            produto.Atualizar();
            CarregaGrid();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Produto produto= new Produto(
                txtDescricao.Text,
                cmbUnidade.Text,
                txtCodBar.Text,
                double.Parse(txtPreco.Text),
                double.Parse(txtDesconto.Text)
                );
            produto.Inserir();
            if (produto.Id > 0)
            {
                txtId.Text = produto.Id.ToString();
                CarregaGrid();
                MessageBox.Show("Produto gravado com sucesso!");
                
            }
            else
                MessageBox.Show("Falha ao gravar o Produto!1");

        }
        private void CarregaGrid(string texto="") 
        {
            List<Produto> lista = null;
            if (texto!=string.Empty)
                 lista = Produto.Listar(texto);
            else
                lista = Produto.Listar();
            int cont = 0;
            dgvLista.Rows.Clear();
            foreach (Produto item in lista)
            {
                dgvLista.Rows.Add();
                dgvLista.Rows[cont].Cells[0].Value = item.Id;
                dgvLista.Rows[cont].Cells[1].Value = item.Descricao;
                dgvLista.Rows[cont].Cells[2].Value = item.Unidade;
                dgvLista.Rows[cont].Cells[3].Value = item.CodBar;
                dgvLista.Rows[cont].Cells[4].Value = item.Preco.ToString("R$ ##0.00");
                dgvLista.Rows[cont].Cells[5].Value = item.Desconto.ToString("#.##%");
                dgvLista.Rows[cont].Cells[6].Value = item.Descontinuado;
                cont++;
            }

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text.Length > 1)
            {
                CarregaGrid(txtPesquisar.Text);
            }
            else if(txtPesquisar.Text.Length < 2)
            {
                CarregaGrid();
            }
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dgv = (DataGridView)sender; 
            //dgvLista.Rows[e.RowIndex].Cells[e.ColumnIndex]
            if (e.ColumnIndex == 6)
            {
                bool x = Convert.ToBoolean(dgvLista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                int id = Convert.ToInt32(dgvLista.Rows[e.RowIndex].Cells[0].Value);
                if (x)
                   Produto.Restaurar(id);
                else
                   Produto.Arquivar(id);
                CarregaGrid();

            }
        }
    }
}
