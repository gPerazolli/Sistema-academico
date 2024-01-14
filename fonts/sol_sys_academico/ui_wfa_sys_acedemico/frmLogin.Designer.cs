namespace ui_wfa_sys_acedemico
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lbLogin = new Label();
            lbUsuario = new Label();
            label3 = new Label();
            tbLogin = new TextBox();
            tbSenha = new TextBox();
            pictureBox1 = new PictureBox();
            btnEntrar = new Button();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogin.Location = new Point(241, 23);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(90, 38);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Login";
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsuario.Location = new Point(241, 127);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(67, 20);
            lbUsuario.TabIndex = 1;
            lbUsuario.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(241, 179);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(314, 124);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(175, 27);
            tbLogin.TabIndex = 3;
            // 
            // tbSenha
            // 
            tbSenha.Location = new Point(314, 176);
            tbSenha.MaxLength = 8;
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '*';
            tbSenha.Size = new Size(175, 27);
            tbSenha.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(314, 220);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(84, 46);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSair
            // 
            btnSair.FlatAppearance.BorderColor = Color.White;
            btnSair.Location = new Point(404, 220);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(84, 46);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(566, 310);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox1);
            Controls.Add(tbSenha);
            Controls.Add(tbLogin);
            Controls.Add(label3);
            Controls.Add(lbUsuario);
            Controls.Add(lbLogin);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            MaximumSize = new Size(584, 357);
            MinimizeBox = false;
            MinimumSize = new Size(584, 357);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":: Controle de Acesso ::";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogin;
        private Label lbUsuario;
        private Label label3;
        private TextBox tbLogin;
        private TextBox tbSenha;
        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Button btnSair;
    }
}