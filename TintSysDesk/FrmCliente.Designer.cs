namespace TintSysDesk
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcCliente = new System.Windows.Forms.TabControl();
            this.tpgDados = new System.Windows.Forms.TabPage();
            this.tpgEnderecos = new System.Windows.Forms.TabPage();
            this.tpgTelefones = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mktCpf = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbcCliente.SuspendLayout();
            this.tpgDados.SuspendLayout();
            this.tpgEnderecos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCliente
            // 
            this.tbcCliente.Controls.Add(this.tpgDados);
            this.tbcCliente.Controls.Add(this.tpgEnderecos);
            this.tbcCliente.Controls.Add(this.tpgTelefones);
            this.tbcCliente.Location = new System.Drawing.Point(33, 40);
            this.tbcCliente.Name = "tbcCliente";
            this.tbcCliente.SelectedIndex = 0;
            this.tbcCliente.Size = new System.Drawing.Size(585, 318);
            this.tbcCliente.TabIndex = 0;
            // 
            // tpgDados
            // 
            this.tpgDados.Controls.Add(this.mktCpf);
            this.tpgDados.Controls.Add(this.checkBox1);
            this.tpgDados.Controls.Add(this.txtEmail);
            this.tpgDados.Controls.Add(this.txtNome);
            this.tpgDados.Controls.Add(this.txtId);
            this.tpgDados.Controls.Add(this.button3);
            this.tpgDados.Controls.Add(this.button2);
            this.tpgDados.Controls.Add(this.btnInserir);
            this.tpgDados.Controls.Add(this.label4);
            this.tpgDados.Controls.Add(this.label3);
            this.tpgDados.Controls.Add(this.label2);
            this.tpgDados.Controls.Add(this.label1);
            this.tpgDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgDados.Location = new System.Drawing.Point(4, 22);
            this.tpgDados.Name = "tpgDados";
            this.tpgDados.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDados.Size = new System.Drawing.Size(577, 292);
            this.tpgDados.TabIndex = 0;
            this.tpgDados.Text = "Dados Pessoais";
            this.tpgDados.UseVisualStyleBackColor = true;
            // 
            // tpgEnderecos
            // 
            this.tpgEnderecos.Controls.Add(this.dataGridView1);
            this.tpgEnderecos.Controls.Add(this.button1);
            this.tpgEnderecos.Location = new System.Drawing.Point(4, 22);
            this.tpgEnderecos.Name = "tpgEnderecos";
            this.tpgEnderecos.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEnderecos.Size = new System.Drawing.Size(577, 292);
            this.tpgEnderecos.TabIndex = 1;
            this.tpgEnderecos.Text = "Endereços";
            this.tpgEnderecos.UseVisualStyleBackColor = true;
            // 
            // tpgTelefones
            // 
            this.tpgTelefones.Location = new System.Drawing.Point(4, 22);
            this.tpgTelefones.Name = "tpgTelefones";
            this.tpgTelefones.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTelefones.Size = new System.Drawing.Size(347, 198);
            this.tpgTelefones.TabIndex = 2;
            this.tpgTelefones.Text = "Telefones";
            this.tpgTelefones.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(290, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 20);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(87, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(283, 22);
            this.txtEmail.TabIndex = 20;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(87, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(283, 22);
            this.txtNome.TabIndex = 19;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(87, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(81, 22);
            this.txtId.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(40, 229);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 15;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // mktCpf
            // 
            this.mktCpf.Location = new System.Drawing.Point(87, 141);
            this.mktCpf.Mask = "000.000.000-99";
            this.mktCpf.Name = "mktCpf";
            this.mktCpf.Size = new System.Drawing.Size(123, 22);
            this.mktCpf.TabIndex = 24;
            this.mktCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 83);
            this.dataGridView1.TabIndex = 1;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcCliente);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.tbcCliente.ResumeLayout(false);
            this.tpgDados.ResumeLayout(false);
            this.tpgDados.PerformLayout();
            this.tpgEnderecos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCliente;
        private System.Windows.Forms.TabPage tpgDados;
        private System.Windows.Forms.TabPage tpgEnderecos;
        private System.Windows.Forms.TabPage tpgTelefones;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mktCpf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}