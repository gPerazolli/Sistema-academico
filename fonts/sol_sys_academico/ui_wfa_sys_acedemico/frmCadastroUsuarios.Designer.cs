namespace ui_wfa_sys_acedemico
{
    partial class frmCadastroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuarios));
            label1 = new Label();
            lbNome = new Label();
            tbNome = new TextBox();
            lbLogin = new Label();
            tbLogin = new TextBox();
            lbSenha = new Label();
            tbSenha = new TextBox();
            lbConfirmarSenha = new Label();
            tbConfirmarSenha = new TextBox();
            btnSalvar = new Button();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            btnNovo = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(237, 22);
            label1.Name = "label1";
            label1.Size = new Size(147, 46);
            label1.TabIndex = 22;
            label1.Text = "Usuários";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(30, 87);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(57, 20);
            lbNome.TabIndex = 24;
            lbNome.Text = "Nome :";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(30, 110);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(317, 27);
            tbNome.TabIndex = 23;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(30, 168);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(53, 20);
            lbLogin.TabIndex = 26;
            lbLogin.Text = "Login :";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(30, 191);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(143, 27);
            tbLogin.TabIndex = 25;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(241, 168);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(56, 20);
            lbSenha.TabIndex = 28;
            lbSenha.Text = "Senha :";
            // 
            // tbSenha
            // 
            tbSenha.Location = new Point(241, 191);
            tbSenha.MaxLength = 8;
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '*';
            tbSenha.Size = new Size(152, 27);
            tbSenha.TabIndex = 27;
            // 
            // lbConfirmarSenha
            // 
            lbConfirmarSenha.AutoSize = true;
            lbConfirmarSenha.Location = new Point(447, 168);
            lbConfirmarSenha.Name = "lbConfirmarSenha";
            lbConfirmarSenha.Size = new Size(126, 20);
            lbConfirmarSenha.TabIndex = 30;
            lbConfirmarSenha.Text = "Confirmar Senha :";
            // 
            // tbConfirmarSenha
            // 
            tbConfirmarSenha.Location = new Point(447, 191);
            tbConfirmarSenha.MaxLength = 8;
            tbConfirmarSenha.Name = "tbConfirmarSenha";
            tbConfirmarSenha.PasswordChar = '*';
            tbConfirmarSenha.Size = new Size(166, 27);
            tbConfirmarSenha.TabIndex = 29;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(144, 259);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(108, 33);
            btnSalvar.TabIndex = 32;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnGravar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(496, 55);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(117, 52);
            btnPesquisar.TabIndex = 33;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(370, 259);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(108, 33);
            btnExcluir.TabIndex = 34;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(30, 259);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(108, 33);
            btnNovo.TabIndex = 35;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnLimpar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(258, 259);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 33);
            btnEditar.TabIndex = 36;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(505, 254);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 42);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmCadastroUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(637, 322);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnSalvar);
            Controls.Add(lbConfirmarSenha);
            Controls.Add(tbConfirmarSenha);
            Controls.Add(lbSenha);
            Controls.Add(tbSenha);
            Controls.Add(lbLogin);
            Controls.Add(tbLogin);
            Controls.Add(lbNome);
            Controls.Add(tbNome);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(655, 369);
            MinimizeBox = false;
            MinimumSize = new Size(655, 369);
            Name = "frmCadastroUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":: Cadastro Usuários ::";
            Load += frmCadastroUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbNome;
        private TextBox tbNome;
        private Label lbLogin;
        private TextBox tbLogin;
        private Label lbSenha;
        private TextBox tbSenha;
        private Label lbConfirmarSenha;
        private TextBox tbConfirmarSenha;
        private Button btnSalvar;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnCancelar;
    }
}