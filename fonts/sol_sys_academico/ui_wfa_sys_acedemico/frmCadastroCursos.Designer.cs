namespace ui_wfa_sys_acedemico
{
    partial class frmCadastroCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCursos));
            label1 = new Label();
            lbObs = new Label();
            lbSigla = new Label();
            lbNome = new Label();
            lbId = new Label();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            tbObs = new TextBox();
            btnGravar = new Button();
            btnNovo = new Button();
            tbSigla = new TextBox();
            tbNome = new TextBox();
            tbId = new TextBox();
            gridCursos = new DataGridView();
            btnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridCursos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(299, 36);
            label1.Name = "label1";
            label1.Size = new Size(120, 46);
            label1.TabIndex = 37;
            label1.Text = "Cursos";
            label1.Click += label1_Click;
            // 
            // lbObs
            // 
            lbObs.AutoSize = true;
            lbObs.Location = new Point(392, 144);
            lbObs.Name = "lbObs";
            lbObs.Size = new Size(100, 20);
            lbObs.TabIndex = 36;
            lbObs.Text = "Observações :";
            // 
            // lbSigla
            // 
            lbSigla.AutoSize = true;
            lbSigla.Location = new Point(33, 211);
            lbSigla.Name = "lbSigla";
            lbSigla.Size = new Size(49, 20);
            lbSigla.TabIndex = 35;
            lbSigla.Text = "Sigla :";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(33, 144);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(57, 20);
            lbNome.TabIndex = 34;
            lbNome.Text = "Nome :";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(33, 83);
            lbId.Name = "lbId";
            lbId.Size = new Size(24, 20);
            lbId.TabIndex = 33;
            lbId.Text = "ID";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(621, 487);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 45);
            btnExcluir.TabIndex = 32;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(621, 436);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 45);
            btnEditar.TabIndex = 31;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(621, 385);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 45);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tbObs
            // 
            tbObs.Location = new Point(392, 167);
            tbObs.Multiline = true;
            tbObs.Name = "tbObs";
            tbObs.Size = new Size(210, 64);
            tbObs.TabIndex = 26;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(621, 335);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 45);
            btnGravar.TabIndex = 27;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(621, 284);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 45);
            btnNovo.TabIndex = 26;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // tbSigla
            // 
            tbSigla.CharacterCasing = CharacterCasing.Upper;
            tbSigla.Location = new Point(33, 234);
            tbSigla.MaxLength = 2;
            tbSigla.Name = "tbSigla";
            tbSigla.Size = new Size(108, 27);
            tbSigla.TabIndex = 25;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(33, 167);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(317, 27);
            tbNome.TabIndex = 24;
            // 
            // tbId
            // 
            tbId.BackColor = SystemColors.InactiveCaption;
            tbId.Enabled = false;
            tbId.Location = new Point(33, 106);
            tbId.Name = "tbId";
            tbId.Size = new Size(65, 27);
            tbId.TabIndex = 23;
            // 
            // gridCursos
            // 
            gridCursos.AllowUserToAddRows = false;
            gridCursos.AllowUserToDeleteRows = false;
            gridCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCursos.Location = new Point(33, 284);
            gridCursos.Name = "gridCursos";
            gridCursos.ReadOnly = true;
            gridCursos.RowHeadersWidth = 51;
            gridCursos.RowTemplate.Height = 29;
            gridCursos.Size = new Size(569, 248);
            gridCursos.TabIndex = 22;
            gridCursos.SelectionChanged += gridCursos_SelectionChanged;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(621, 106);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 45);
            btnPesquisar.TabIndex = 38;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // frmCadastroCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(744, 548);
            Controls.Add(btnPesquisar);
            Controls.Add(label1);
            Controls.Add(lbObs);
            Controls.Add(lbSigla);
            Controls.Add(lbNome);
            Controls.Add(lbId);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(tbObs);
            Controls.Add(btnGravar);
            Controls.Add(btnNovo);
            Controls.Add(tbSigla);
            Controls.Add(tbNome);
            Controls.Add(tbId);
            Controls.Add(gridCursos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(762, 595);
            MinimizeBox = false;
            MinimumSize = new Size(762, 595);
            Name = "frmCadastroCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":: Cadastro Periodos ::";
            Load += frmCadastroCursos_Load;
            ((System.ComponentModel.ISupportInitialize)gridCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbObs;
        private Label lbSigla;
        private Label lbNome;
        private Label lbId;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnCancelar;
        private TextBox tbObs;
        private Button btnGravar;
        private Button btnNovo;
        private TextBox tbSigla;
        private TextBox tbNome;
        private TextBox tbId;
        private DataGridView gridCursos;
        private Button btnPesquisar;
    }
}