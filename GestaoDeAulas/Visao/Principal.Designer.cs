namespace GestaoDeAulas
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerenciamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAulas = new System.Windows.Forms.Panel();
            this.dgvAulasAgendadas = new System.Windows.Forms.DataGridView();
            this.mtcCalendario = new System.Windows.Forms.MonthCalendar();
            this.ID_AULA_AGENDADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TURMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BLOCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTEUDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAulas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulasAgendadas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerenciamentoToolStripMenuItem
            // 
            this.gerenciamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.professoresToolStripMenuItem,
            this.horáriosToolStripMenuItem,
            this.turmasToolStripMenuItem});
            this.gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            this.gerenciamentoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.gerenciamentoToolStripMenuItem.Text = "DADOS";
            this.gerenciamentoToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoToolStripMenuItem_Click);
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.professoresToolStripMenuItem.Text = "Professores";
            this.professoresToolStripMenuItem.Click += new System.EventHandler(this.professoresToolStripMenuItem_Click);
            // 
            // horáriosToolStripMenuItem
            // 
            this.horáriosToolStripMenuItem.Name = "horáriosToolStripMenuItem";
            this.horáriosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.horáriosToolStripMenuItem.Text = "Horários";
            this.horáriosToolStripMenuItem.Click += new System.EventHandler(this.horáriosToolStripMenuItem_Click);
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.turmasToolStripMenuItem.Text = "Turmas";
            this.turmasToolStripMenuItem.Click += new System.EventHandler(this.turmasToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.txbPesquisa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelAulas);
            this.panel1.Controls.Add(this.mtcCalendario);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 660);
            this.panel1.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(551, 193);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(310, 193);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(94, 193);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.Location = new System.Drawing.Point(104, 246);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(646, 26);
            this.txbPesquisa.TabIndex = 4;
            this.txbPesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar:";
            // 
            // panelAulas
            // 
            this.panelAulas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAulas.Controls.Add(this.dgvAulasAgendadas);
            this.panelAulas.Location = new System.Drawing.Point(3, 278);
            this.panelAulas.Name = "panelAulas";
            this.panelAulas.Size = new System.Drawing.Size(769, 379);
            this.panelAulas.TabIndex = 2;
            // 
            // dgvAulasAgendadas
            // 
            this.dgvAulasAgendadas.AllowUserToAddRows = false;
            this.dgvAulasAgendadas.AllowUserToDeleteRows = false;
            this.dgvAulasAgendadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulasAgendadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_AULA_AGENDADA,
            this.HORARIO,
            this.PROFESSOR,
            this.TURMA,
            this.BLOCO,
            this.CONTEUDO,
            this.DATA});
            this.dgvAulasAgendadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAulasAgendadas.Location = new System.Drawing.Point(0, 0);
            this.dgvAulasAgendadas.Name = "dgvAulasAgendadas";
            this.dgvAulasAgendadas.ReadOnly = true;
            this.dgvAulasAgendadas.Size = new System.Drawing.Size(769, 379);
            this.dgvAulasAgendadas.TabIndex = 1;
            this.dgvAulasAgendadas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dgvAulasAgendadas.DoubleClick += new System.EventHandler(this.dgvAulasAgendadas_DoubleClick);
            // 
            // mtcCalendario
            // 
            this.mtcCalendario.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.mtcCalendario.Location = new System.Drawing.Point(43, 9);
            this.mtcCalendario.MaxSelectionCount = 1;
            this.mtcCalendario.Name = "mtcCalendario";
            this.mtcCalendario.TabIndex = 0;
            this.mtcCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.mtcCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // ID_AULA_AGENDADA
            // 
            this.ID_AULA_AGENDADA.HeaderText = "ID_AULA_AGENDADA";
            this.ID_AULA_AGENDADA.Name = "ID_AULA_AGENDADA";
            this.ID_AULA_AGENDADA.ReadOnly = true;
            // 
            // HORARIO
            // 
            this.HORARIO.HeaderText = "HORARIO";
            this.HORARIO.Name = "HORARIO";
            this.HORARIO.ReadOnly = true;
            // 
            // PROFESSOR
            // 
            this.PROFESSOR.HeaderText = "PROFESSOR";
            this.PROFESSOR.Name = "PROFESSOR";
            this.PROFESSOR.ReadOnly = true;
            // 
            // TURMA
            // 
            this.TURMA.HeaderText = "TURMA";
            this.TURMA.Name = "TURMA";
            this.TURMA.ReadOnly = true;
            // 
            // BLOCO
            // 
            this.BLOCO.HeaderText = "BLOCO";
            this.BLOCO.Name = "BLOCO";
            this.BLOCO.ReadOnly = true;
            // 
            // CONTEUDO
            // 
            this.CONTEUDO.HeaderText = "CONTEUDO";
            this.CONTEUDO.Name = "CONTEUDO";
            this.CONTEUDO.ReadOnly = true;
            // 
            // DATA
            // 
            this.DATA.HeaderText = "DATA";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Sistema de Gestão de Aulas - Educativa";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAulas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulasAgendadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAulas;
        private System.Windows.Forms.DataGridView dgvAulasAgendadas;
        private System.Windows.Forms.MonthCalendar mtcCalendario;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_AULA_AGENDADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROFESSOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TURMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BLOCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTEUDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
    }
}

