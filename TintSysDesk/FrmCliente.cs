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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            tpgEnderecos.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente  = new Cliente(); 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtId.Text);
        }
    }
}
