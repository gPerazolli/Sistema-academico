namespace ui_wfa_sys_acedemico
{
    partial class frmUsuariosPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuariosPesquisa));
            gridUsuarios = new DataGridView();
            btnVoltar = new Button();
            btnSelecionar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // gridUsuarios
            // 
            gridUsuarios.AllowUserToAddRows = false;
            gridUsuarios.AllowUserToDeleteRows = false;
            gridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsuarios.Location = new Point(24, 31);
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.ReadOnly = true;
            gridUsuarios.RowHeadersWidth = 51;
            gridUsuarios.RowTemplate.Height = 29;
            gridUsuarios.Size = new Size(474, 209);
            gridUsuarios.TabIndex = 9;
            gridUsuarios.CellContentClick += gridUsuarios_CellContentClick;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(369, 263);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(129, 33);
            btnVoltar.TabIndex = 35;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(211, 263);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(129, 33);
            btnSelecionar.TabIndex = 36;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click_1;
            // 
            // frmUsuariosPesquisa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(538, 308);
            Controls.Add(btnSelecionar);
            Controls.Add(btnVoltar);
            Controls.Add(gridUsuarios);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(556, 355);
            MinimizeBox = false;
            MinimumSize = new Size(556, 355);
            Name = "frmUsuariosPesquisa";
            StartPosition = FormStartPosition.CenterParent;
            Text = ":: Pesquisa de Usuarios ::";
            Load += frmCadastroUsuariosPesquisa_Load;
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridUsuarios;
        private Button btnVoltar;
        private Button btnSelecionar;
    }
}