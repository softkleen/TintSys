namespace TintSysDesk
{
    partial class FrmUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNiveis = new System.Windows.Forms.DataGridView();
            this.clnIdNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDeleteNivel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtNomeNivel = new System.Windows.Forms.TextBox();
            this.txtIdNivel = new System.Windows.Forms.TextBox();
            this.btnEditarNivel = new System.Windows.Forms.Button();
            this.btnConsultarNivel = new System.Windows.Forms.Button();
            this.btnInserirNivel = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(54, 206);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(92, 58);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(81, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(92, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(283, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(92, 112);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(283, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(92, 139);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 7;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(254, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(295, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nível";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnEmail,
            this.clnNivel,
            this.clnAtivo});
            this.dgvUsuarios.Location = new System.Drawing.Point(51, 261);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(550, 200);
            this.dgvUsuarios.TabIndex = 10;
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "Id";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 40;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 174;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 174;
            // 
            // clnNivel
            // 
            this.clnNivel.Frozen = true;
            this.clnNivel.HeaderText = "Nível";
            this.clnNivel.Name = "clnNivel";
            this.clnNivel.ReadOnly = true;
            // 
            // clnAtivo
            // 
            this.clnAtivo.Frozen = true;
            this.clnAtivo.HeaderText = "Ativo";
            this.clnAtivo.Name = "clnAtivo";
            this.clnAtivo.ReadOnly = true;
            this.clnAtivo.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNiveis);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSigla);
            this.groupBox1.Controls.Add(this.txtNomeNivel);
            this.groupBox1.Controls.Add(this.txtIdNivel);
            this.groupBox1.Controls.Add(this.btnEditarNivel);
            this.groupBox1.Controls.Add(this.btnConsultarNivel);
            this.groupBox1.Controls.Add(this.btnInserirNivel);
            this.groupBox1.Location = new System.Drawing.Point(670, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 322);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Níveis";
            // 
            // dgvNiveis
            // 
            this.dgvNiveis.AllowUserToAddRows = false;
            this.dgvNiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdNivel,
            this.clnNomeNivel,
            this.clnSigla,
            this.clnDeleteNivel});
            this.dgvNiveis.Location = new System.Drawing.Point(0, 182);
            this.dgvNiveis.Name = "dgvNiveis";
            this.dgvNiveis.ReadOnly = true;
            this.dgvNiveis.RowHeadersVisible = false;
            this.dgvNiveis.Size = new System.Drawing.Size(320, 139);
            this.dgvNiveis.TabIndex = 7;
            this.dgvNiveis.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvNiveis_UserDeletedRow);
            // 
            // clnIdNivel
            // 
            this.clnIdNivel.Frozen = true;
            this.clnIdNivel.HeaderText = "ID";
            this.clnIdNivel.Name = "clnIdNivel";
            this.clnIdNivel.ReadOnly = true;
            this.clnIdNivel.Width = 40;
            // 
            // clnNomeNivel
            // 
            this.clnNomeNivel.Frozen = true;
            this.clnNomeNivel.HeaderText = "Nome";
            this.clnNomeNivel.Name = "clnNomeNivel";
            this.clnNomeNivel.ReadOnly = true;
            this.clnNomeNivel.Width = 120;
            // 
            // clnSigla
            // 
            this.clnSigla.Frozen = true;
            this.clnSigla.HeaderText = "Sigla";
            this.clnSigla.Name = "clnSigla";
            this.clnSigla.ReadOnly = true;
            this.clnSigla.Width = 80;
            // 
            // clnDeleteNivel
            // 
            this.clnDeleteNivel.Frozen = true;
            this.clnDeleteNivel.HeaderText = "Ação";
            this.clnDeleteNivel.Name = "clnDeleteNivel";
            this.clnDeleteNivel.ReadOnly = true;
            this.clnDeleteNivel.Text = "Excluir";
            this.clnDeleteNivel.Width = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Sigla";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(72, 78);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(100, 20);
            this.txtSigla.TabIndex = 5;
            // 
            // txtNomeNivel
            // 
            this.txtNomeNivel.Location = new System.Drawing.Point(72, 51);
            this.txtNomeNivel.Name = "txtNomeNivel";
            this.txtNomeNivel.Size = new System.Drawing.Size(196, 20);
            this.txtNomeNivel.TabIndex = 4;
            // 
            // txtIdNivel
            // 
            this.txtIdNivel.Location = new System.Drawing.Point(72, 24);
            this.txtIdNivel.Name = "txtIdNivel";
            this.txtIdNivel.Size = new System.Drawing.Size(56, 20);
            this.txtIdNivel.TabIndex = 3;
            // 
            // btnEditarNivel
            // 
            this.btnEditarNivel.FlatAppearance.BorderSize = 0;
            this.btnEditarNivel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnEditarNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditarNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarNivel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditarNivel.Image = global::TintSysDesk.Properties.Resources.Edit;
            this.btnEditarNivel.Location = new System.Drawing.Point(225, 125);
            this.btnEditarNivel.Name = "btnEditarNivel";
            this.btnEditarNivel.Size = new System.Drawing.Size(75, 51);
            this.btnEditarNivel.TabIndex = 2;
            this.btnEditarNivel.Text = "Editar";
            this.btnEditarNivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarNivel.UseVisualStyleBackColor = true;
            this.btnEditarNivel.Click += new System.EventHandler(this.btnEditarNivel_Click);
            // 
            // btnConsultarNivel
            // 
            this.btnConsultarNivel.FlatAppearance.BorderSize = 0;
            this.btnConsultarNivel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnConsultarNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConsultarNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarNivel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultarNivel.Image = global::TintSysDesk.Properties.Resources.Search;
            this.btnConsultarNivel.Location = new System.Drawing.Point(127, 125);
            this.btnConsultarNivel.Name = "btnConsultarNivel";
            this.btnConsultarNivel.Size = new System.Drawing.Size(75, 51);
            this.btnConsultarNivel.TabIndex = 1;
            this.btnConsultarNivel.Text = "Consultar";
            this.btnConsultarNivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarNivel.UseVisualStyleBackColor = true;
            this.btnConsultarNivel.Click += new System.EventHandler(this.btnConsultarNivel_Click);
            // 
            // btnInserirNivel
            // 
            this.btnInserirNivel.FlatAppearance.BorderSize = 0;
            this.btnInserirNivel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnInserirNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInserirNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirNivel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInserirNivel.Image = global::TintSysDesk.Properties.Resources.Add;
            this.btnInserirNivel.Location = new System.Drawing.Point(25, 125);
            this.btnInserirNivel.Name = "btnInserirNivel";
            this.btnInserirNivel.Size = new System.Drawing.Size(75, 51);
            this.btnInserirNivel.TabIndex = 0;
            this.btnInserirNivel.Text = "Inserir";
            this.btnInserirNivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInserirNivel.UseVisualStyleBackColor = true;
            this.btnInserirNivel.Click += new System.EventHandler(this.btnInserirNivel_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "teste",
            "tedyr",
            "etrgsdf",
            "sds"});
            this.comboBox2.Location = new System.Drawing.Point(470, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 536);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUsuarios";
            this.Text = "Administração de Usuários ";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNivel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNiveis;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSigla;
        private System.Windows.Forms.DataGridViewButtonColumn clnDeleteNivel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtNomeNivel;
        private System.Windows.Forms.TextBox txtIdNivel;
        private System.Windows.Forms.Button btnEditarNivel;
        private System.Windows.Forms.Button btnConsultarNivel;
        private System.Windows.Forms.Button btnInserirNivel;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
