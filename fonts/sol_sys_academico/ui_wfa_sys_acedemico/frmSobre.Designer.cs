namespace ui_wfa_sys_acedemico
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            lbVersao = new Label();
            label1 = new Label();
            btnFechar = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbVersao
            // 
            lbVersao.AutoSize = true;
            lbVersao.Location = new Point(6, 70);
            lbVersao.Name = "lbVersao";
            lbVersao.Size = new Size(209, 20);
            lbVersao.TabIndex = 0;
            lbVersao.Text = "Versao do Sistema: 1.0.1.0.0.10";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(315, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 1;
            label1.Text = "Sistema Acadêmico";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(676, 295);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(116, 47);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SISTEMA_ACADEMICO_ICONE;
            pictureBox1.Location = new Point(12, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbVersao);
            groupBox1.Location = new Point(244, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 270);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 0);
            label8.Name = "label8";
            label8.Size = new Size(424, 100);
            label8.TabIndex = 6;
            label8.Text = resources.GetString("label8.Text");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 156);
            label7.Name = "label7";
            label7.Size = new Size(203, 20);
            label7.TabIndex = 5;
            label7.Text = "Designer: Guilherme Perazolli";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 136);
            label6.Name = "label6";
            label6.Size = new Size(243, 20);
            label6.TabIndex = 4;
            label6.Text = "Desenvolvedor: Guilherme Perazolli";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 116);
            label5.Name = "label5";
            label5.Size = new Size(207, 20);
            label5.TabIndex = 3;
            label5.Text = "Equipe de Desenvolvimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 187);
            label4.Name = "label4";
            label4.Size = new Size(182, 20);
            label4.TabIndex = 2;
            label4.Text = "Informações de Contato:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 207);
            label3.Name = "label3";
            label3.Size = new Size(271, 40);
            label3.TabIndex = 1;
            label3.Text = "E-mail: contato@sistemacademico.com\r\nSite: www.sistemacademico.com\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 322);
            label2.Name = "label2";
            label2.Size = new Size(193, 20);
            label2.TabIndex = 1;
            label2.Text = "© 2023 Sistema Acadêmico";
            // 
            // frmSobre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(804, 354);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnFechar);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(822, 401);
            MinimizeBox = false;
            MinimumSize = new Size(822, 401);
            Name = "frmSobre";
            StartPosition = FormStartPosition.CenterParent;
            Text = ":: Sobre ::";
            Load += frmSobre_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbVersao;
        private Label label1;
        private Button btnFechar;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
    }
}