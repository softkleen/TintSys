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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var n = Nivel.ObterPorId(2);
            label1.Text = n.Id.ToString();
            label2.Text = n.Nome;
            label3.Text = n.Sigla;


            comboBox1.DataSource = Nivel.Listar();
            comboBox1.DisplayMember= "Nome";
            comboBox1.ValueMember = "Id";

            

            //Nivel nivel = new Nivel("Administrador", "ADM");
            //nivel.Inserir();
            //if (nivel.Id>0)
            //MessageBox.Show(nivel.Id.ToString());


        }

   

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text= comboBox1.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            Nivel nivel= new Nivel(1, "Estoquista", "EST");
           
            nivel.Atualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel();
            int msg = nivel.Excluir(2);
            if (msg==1)
                MessageBox.Show("Nível excluído com sucesso!");
            else if(msg==2)
                MessageBox.Show("Falha ao excluir o nível! Está associado a um Usuário");
            else 
                MessageBox.Show("Falha ao excluir o nível!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuario usuario = Usuario.ObterPorId(Convert.ToInt32(textBox3.Text));
            textBox2.Text= usuario.Id +" - "+ usuario.Nome.ToString() +" - "+ usuario.Nivel.Nome;

        }
    }
}
