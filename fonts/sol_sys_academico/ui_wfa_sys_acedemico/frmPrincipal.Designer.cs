namespace ui_wfa_sys_acedemico
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            testeToolStripMenuItem = new ToolStripMenuItem();
            disciplinasToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            periodosToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem1 = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnEncerrar = new Button();
            btnSair = new Button();
            groupBox1 = new GroupBox();
            lbData = new Label();
            lbBemVindo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { testeToolStripMenuItem, ajudaToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(762, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // testeToolStripMenuItem
            // 
            testeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinasToolStripMenuItem, cursosToolStripMenuItem, periodosToolStripMenuItem, usuariosToolStripMenuItem });
            testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            testeToolStripMenuItem.Size = new Size(88, 24);
            testeToolStripMenuItem.Text = "Cadastros";
            // 
            // disciplinasToolStripMenuItem
            // 
            disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            disciplinasToolStripMenuItem.Size = new Size(163, 26);
            disciplinasToolStripMenuItem.Text = "Disciplinas";
            disciplinasToolStripMenuItem.Click += disciplinasToolStripMenuItem_Click;
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(163, 26);
            cursosToolStripMenuItem.Text = "Periodos";
            cursosToolStripMenuItem.Click += cursosToolStripMenuItem_Click;
            // 
            // periodosToolStripMenuItem
            // 
            periodosToolStripMenuItem.Name = "periodosToolStripMenuItem";
            periodosToolStripMenuItem.Size = new Size(163, 26);
            periodosToolStripMenuItem.Text = "Cursos";
            periodosToolStripMenuItem.Click += periodosToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(163, 26);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem1
            // 
            ajudaToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            ajudaToolStripMenuItem1.Size = new Size(62, 24);
            ajudaToolStripMenuItem1.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(131, 26);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(762, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(90, 20);
            toolStripStatusLabel1.Text = "Versão: 1.0.1";
            // 
            // btnEncerrar
            // 
            btnEncerrar.BackColor = SystemColors.HighlightText;
            btnEncerrar.Image = (Image)resources.GetObject("btnEncerrar.Image");
            btnEncerrar.ImageAlign = ContentAlignment.TopRight;
            btnEncerrar.Location = new Point(3, 3);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(107, 85);
            btnEncerrar.TabIndex = 2;
            btnEncerrar.Text = "LogOff";
            btnEncerrar.TextAlign = ContentAlignment.BottomCenter;
            btnEncerrar.UseVisualStyleBackColor = true;
            btnEncerrar.Click += btnEncerrar_Click;
            // 
            // btnSair
            // 
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.TopCenter;
            btnSair.Location = new Point(116, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(107, 85);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(lbData);
            groupBox1.Controls.Add(lbBemVindo);
            groupBox1.Location = new Point(3, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1915, 163);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbData.ForeColor = SystemColors.ControlLightLight;
            lbData.Location = new Point(23, 82);
            lbData.Name = "lbData";
            lbData.Size = new Size(101, 46);
            lbData.TabIndex = 1;
            lbData.Text = "DATA";
            lbData.Click += lbData_Click;
            // 
            // lbBemVindo
            // 
            lbBemVindo.AutoSize = true;
            lbBemVindo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbBemVindo.ForeColor = SystemColors.ControlLightLight;
            lbBemVindo.Location = new Point(26, 23);
            lbBemVindo.Name = "lbBemVindo";
            lbBemVindo.Size = new Size(201, 46);
            lbBemVindo.TabIndex = 0;
            lbBemVindo.Text = "BEM VINDO";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnEncerrar);
            flowLayoutPanel1.Controls.Add(btnSair);
            flowLayoutPanel1.Location = new Point(1693, 33);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(229, 88);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(762, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = ":: Sistema Acadêmico  GUILHERME AUGUSTO PERAZOLLI COSTA  RA: N942819 ::  ";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem testeToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem1;
        private ToolStripMenuItem disciplinasToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem periodosToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button btnEncerrar;
        private GroupBox groupBox1;
        private Label lbData;
        private Label lbBemVindo;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private Button btnSair;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}