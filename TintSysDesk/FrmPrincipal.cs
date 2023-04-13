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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.MdiParent= this;
            frmCliente.Show();
        }

        private void manterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();   
            frmProduto.MdiParent = this;    
            frmProduto.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedido frmPedido = new FrmPedido();  
            frmPedido.MdiParent = this;
            frmPedido.Show();
        }
    }
}
