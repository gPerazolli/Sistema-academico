namespace ui_wfa_sys_acedemico
{
    partial class frmCadastroDisciplinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroDisciplinas));
            gridDisciplinas = new DataGridView();
            tbId = new TextBox();
            tbNome = new TextBox();
            tbSigla = new TextBox();
            btnNovo = new Button();
            btnGravar = new Button();
            tbObs = new TextBox();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            lbId = new Label();
            lbNome = new Label();
            lbSigla = new Label();
            lbObs = new Label();
            label1 = new Label();
            btnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridDisciplinas).BeginInit();
            SuspendLayout();
            // 
            // gridDisciplinas
            // 
            gridDisciplinas.AllowUserToAddRows = false;
            gridDisciplinas.AllowUserToDeleteRows = false;
            gridDisciplinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDisciplinas.Location = new Point(34, 281);
            gridDisciplinas.Name = "gridDisciplinas";
            gridDisciplinas.ReadOnly = true;
            gridDisciplinas.RowHeadersWidth = 51;
            gridDisciplinas.RowTemplate.Height = 29;
            gridDisciplinas.Size = new Size(569, 249);
            gridDisciplinas.TabIndex = 0;
            gridDisciplinas.SelectionChanged += gridDisciplinas_SelectionChanged;
            // 
            // tbId
            // 
            tbId.BackColor = SystemColors.InactiveCaption;
            tbId.Enabled = false;
            tbId.Location = new Point(34, 104);
            tbId.Name = "tbId";
            tbId.Size = new Size(65, 27);
            tbId.TabIndex = 1;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(34, 165);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(317, 27);
            tbNome.TabIndex = 2;
            // 
            // tbSigla
            // 
            tbSigla.CharacterCasing = CharacterCasing.Upper;
            tbSigla.Location = new Point(34, 232);
            tbSigla.MaxLength = 2;
            tbSigla.Name = "tbSigla";
            tbSigla.Size = new Size(108, 27);
            tbSigla.TabIndex = 3;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(621, 281);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 45);
            btnNovo.TabIndex = 10;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(621, 332);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 45);
            btnGravar.TabIndex = 11;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // tbObs
            // 
            tbObs.Location = new Point(393, 165);
            tbObs.Multiline = true;
            tbObs.Name = "tbObs";
            tbObs.Size = new Size(210, 64);
            tbObs.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(621, 383);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 45);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(621, 434);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 45);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(621, 485);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 45);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(34, 81);
            lbId.Name = "lbId";
            lbId.Size = new Size(24, 20);
            lbId.TabIndex = 17;
            lbId.Text = "ID";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(34, 142);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(57, 20);
            lbNome.TabIndex = 18;
            lbNome.Text = "Nome :";
            // 
            // lbSigla
            // 
            lbSigla.AutoSize = true;
            lbSigla.Location = new Point(34, 209);
            lbSigla.Name = "lbSigla";
            lbSigla.Size = new Size(49, 20);
            lbSigla.TabIndex = 19;
            lbSigla.Text = "Sigla :";
            // 
            // lbObs
            // 
            lbObs.AutoSize = true;
            lbObs.Location = new Point(393, 142);
            lbObs.Name = "lbObs";
            lbObs.Size = new Size(100, 20);
            lbObs.TabIndex = 20;
            lbObs.Text = "Observações :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(288, 40);
            label1.Name = "label1";
            label1.Size = new Size(176, 46);
            label1.TabIndex = 21;
            label1.Text = "Disciplinas";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(621, 104);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 45);
            btnPesquisar.TabIndex = 22;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // frmCadastroDisciplinas
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
            Controls.Add(gridDisciplinas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(762, 595);
            MinimizeBox = false;
            MinimumSize = new Size(762, 595);
            Name = "frmCadastroDisciplinas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":: Cadastro Disciplinas ::";
            Load += frmCadastroDisciplinas_Load;
            ((System.ComponentModel.ISupportInitialize)gridDisciplinas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridDisciplinas;
        private TextBox tbId;
        private TextBox tbNome;
        private TextBox tbSigla;
        private Button btnNovo;
        private Button btnGravar;
        private TextBox tbObs;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnExcluir;
        private Label lbId;
        private Label lbNome;
        private Label lbSigla;
        private Label lbObs;
        private Label label1;
        private Button btnPesquisar;
    }
}