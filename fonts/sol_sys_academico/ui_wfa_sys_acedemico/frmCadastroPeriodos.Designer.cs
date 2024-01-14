namespace ui_wfa_sys_acedemico
{
    partial class frmCadastroPeriodos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroPeriodos));
            lbId = new Label();
            tbId = new TextBox();
            tbNome = new TextBox();
            lbNome = new Label();
            tbSigla = new TextBox();
            lbSigla = new Label();
            gridPeriodos = new DataGridView();
            btnNovo = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            label1 = new Label();
            btnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridPeriodos).BeginInit();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(34, 104);
            lbId.Name = "lbId";
            lbId.Size = new Size(24, 20);
            lbId.TabIndex = 0;
            lbId.Text = "ID";
            lbId.Click += label1_Click;
            // 
            // tbId
            // 
            tbId.BackColor = SystemColors.InactiveCaption;
            tbId.Enabled = false;
            tbId.Location = new Point(34, 127);
            tbId.Name = "tbId";
            tbId.Size = new Size(67, 27);
            tbId.TabIndex = 1;
            tbId.TextChanged += tbId_TextChanged;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(34, 195);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(383, 27);
            tbNome.TabIndex = 3;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(34, 172);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(57, 20);
            lbNome.TabIndex = 2;
            lbNome.Text = "Nome :";
            // 
            // tbSigla
            // 
            tbSigla.CharacterCasing = CharacterCasing.Upper;
            tbSigla.Location = new Point(452, 195);
            tbSigla.MaxLength = 2;
            tbSigla.Name = "tbSigla";
            tbSigla.Size = new Size(129, 27);
            tbSigla.TabIndex = 4;
            // 
            // lbSigla
            // 
            lbSigla.AutoSize = true;
            lbSigla.Location = new Point(452, 172);
            lbSigla.Name = "lbSigla";
            lbSigla.Size = new Size(49, 20);
            lbSigla.TabIndex = 4;
            lbSigla.Text = "Sigla :";
            // 
            // gridPeriodos
            // 
            gridPeriodos.AllowUserToAddRows = false;
            gridPeriodos.AllowUserToDeleteRows = false;
            gridPeriodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPeriodos.Location = new Point(34, 236);
            gridPeriodos.Name = "gridPeriodos";
            gridPeriodos.ReadOnly = true;
            gridPeriodos.RowHeadersWidth = 51;
            gridPeriodos.RowTemplate.Height = 29;
            gridPeriodos.Size = new Size(547, 248);
            gridPeriodos.TabIndex = 8;
            gridPeriodos.CellContentClick += gridCursos_CellContentClick;
            gridPeriodos.SelectionChanged += gridCursos_SelectionChanged;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(619, 235);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 45);
            btnNovo.TabIndex = 10;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(619, 286);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 45);
            btnGravar.TabIndex = 11;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(619, 337);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 45);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(619, 388);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 45);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(619, 439);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 45);
            btnExcluir.TabIndex = 14;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(277, 29);
            label1.Name = "label1";
            label1.Size = new Size(150, 46);
            label1.TabIndex = 15;
            label1.Text = "Períodos";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(619, 127);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 45);
            btnPesquisar.TabIndex = 16;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // frmCadastroPeriodos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(744, 509);
            Controls.Add(btnPesquisar);
            Controls.Add(label1);
            Controls.Add(tbSigla);
            Controls.Add(tbNome);
            Controls.Add(lbSigla);
            Controls.Add(lbId);
            Controls.Add(lbNome);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(tbId);
            Controls.Add(btnGravar);
            Controls.Add(btnNovo);
            Controls.Add(gridPeriodos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(762, 556);
            MinimizeBox = false;
            MinimumSize = new Size(762, 556);
            Name = "frmCadastroPeriodos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " :: Cadastro Períodos ::";
            Load += frmCadastroCursos_Load;
            ((System.ComponentModel.ISupportInitialize)gridPeriodos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbId;
        private TextBox tbId;
        private TextBox tbNome;
        private Label lbNome;
        private TextBox tbSigla;
        private Label lbSigla;
        private DataGridView gridPeriodos;
        private Button btnNovo;
        private Button btnGravar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnExcluir;
        private Label label1;
        private Button btnPesquisar;
    }
}