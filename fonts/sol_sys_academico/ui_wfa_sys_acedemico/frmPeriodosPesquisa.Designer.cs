namespace ui_wfa_sys_acedemico
{
    partial class frmPeriodosPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeriodosPesquisa));
            btnSelecionar = new Button();
            btnVoltar = new Button();
            btnBuscar = new Button();
            tbPesquisa = new TextBox();
            gridPeriodos = new DataGridView();
            panel1 = new Panel();
            lbOpcoes = new Label();
            rbId = new RadioButton();
            rbNome = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)gridPeriodos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(381, 441);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(94, 51);
            btnSelecionar.TabIndex = 17;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(517, 441);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 51);
            btnVoltar.TabIndex = 16;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(517, 57);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 51);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbPesquisa
            // 
            tbPesquisa.Location = new Point(197, 69);
            tbPesquisa.Name = "tbPesquisa";
            tbPesquisa.Size = new Size(278, 27);
            tbPesquisa.TabIndex = 14;
            // 
            // gridPeriodos
            // 
            gridPeriodos.AllowUserToAddRows = false;
            gridPeriodos.AllowUserToDeleteRows = false;
            gridPeriodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPeriodos.Location = new Point(45, 149);
            gridPeriodos.Name = "gridPeriodos";
            gridPeriodos.ReadOnly = true;
            gridPeriodos.RowHeadersWidth = 51;
            gridPeriodos.RowTemplate.Height = 29;
            gridPeriodos.Size = new Size(566, 269);
            gridPeriodos.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lbOpcoes);
            panel1.Controls.Add(rbId);
            panel1.Controls.Add(rbNome);
            panel1.Location = new Point(45, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(105, 84);
            panel1.TabIndex = 18;
            // 
            // lbOpcoes
            // 
            lbOpcoes.AutoSize = true;
            lbOpcoes.Location = new Point(3, 1);
            lbOpcoes.Name = "lbOpcoes";
            lbOpcoes.Size = new Size(62, 20);
            lbOpcoes.TabIndex = 16;
            lbOpcoes.Text = "Opções:";
            // 
            // rbId
            // 
            rbId.AutoSize = true;
            rbId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbId.Location = new Point(16, 45);
            rbId.Name = "rbId";
            rbId.Size = new Size(48, 27);
            rbId.TabIndex = 15;
            rbId.TabStop = true;
            rbId.Text = "ID";
            rbId.UseVisualStyleBackColor = true;
            rbId.CheckedChanged += rbId_CheckedChanged;
            // 
            // rbNome
            // 
            rbNome.AutoSize = true;
            rbNome.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbNome.Location = new Point(16, 24);
            rbNome.Name = "rbNome";
            rbNome.Size = new Size(78, 27);
            rbNome.TabIndex = 14;
            rbNome.TabStop = true;
            rbNome.Text = "Nome";
            rbNome.UseVisualStyleBackColor = true;
            rbNome.CheckedChanged += rbNome_CheckedChanged;
            // 
            // frmPeriodosPesquisa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(676, 504);
            Controls.Add(panel1);
            Controls.Add(btnSelecionar);
            Controls.Add(btnVoltar);
            Controls.Add(btnBuscar);
            Controls.Add(tbPesquisa);
            Controls.Add(gridPeriodos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(694, 551);
            MinimizeBox = false;
            MinimumSize = new Size(694, 551);
            Name = "frmPeriodosPesquisa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":: Pesquisa de Periodos ::";
            Load += frmPeriodosPesquisa_Load;
            ((System.ComponentModel.ISupportInitialize)gridPeriodos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelecionar;
        private Button btnVoltar;
        private Button btnBuscar;
        private TextBox tbPesquisa;
        private DataGridView gridPeriodos;
        private Panel panel1;
        private Label lbOpcoes;
        private RadioButton rbId;
        private RadioButton rbNome;
    }
}