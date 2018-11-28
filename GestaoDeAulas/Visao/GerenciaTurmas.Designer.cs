namespace GestaoDeAulas.Visao
{
    partial class GerenciaTurmas
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTurmas = new System.Windows.Forms.DataGridView();
            this.btnAlterarHorario = new System.Windows.Forms.Button();
            this.btnRemoverHorario = new System.Windows.Forms.Button();
            this.btnAdicionarHorario = new System.Windows.Forms.Button();
            this.ID_TURMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BLOCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TURMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTurmas);
            this.panel2.Location = new System.Drawing.Point(12, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 340);
            this.panel2.TabIndex = 13;
            // 
            // dgvTurmas
            // 
            this.dgvTurmas.AllowUserToAddRows = false;
            this.dgvTurmas.AllowUserToDeleteRows = false;
            this.dgvTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurmas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TURMA,
            this.BLOCO,
            this.TURMA});
            this.dgvTurmas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTurmas.Location = new System.Drawing.Point(0, 0);
            this.dgvTurmas.Name = "dgvTurmas";
            this.dgvTurmas.ReadOnly = true;
            this.dgvTurmas.Size = new System.Drawing.Size(497, 340);
            this.dgvTurmas.TabIndex = 8;
            // 
            // btnAlterarHorario
            // 
            this.btnAlterarHorario.Location = new System.Drawing.Point(190, 40);
            this.btnAlterarHorario.Name = "btnAlterarHorario";
            this.btnAlterarHorario.Size = new System.Drawing.Size(98, 37);
            this.btnAlterarHorario.TabIndex = 12;
            this.btnAlterarHorario.Text = "Alterar";
            this.btnAlterarHorario.UseVisualStyleBackColor = true;
            this.btnAlterarHorario.Click += new System.EventHandler(this.btnAlterarHorario_Click);
            // 
            // btnRemoverHorario
            // 
            this.btnRemoverHorario.Location = new System.Drawing.Point(294, 40);
            this.btnRemoverHorario.Name = "btnRemoverHorario";
            this.btnRemoverHorario.Size = new System.Drawing.Size(98, 37);
            this.btnRemoverHorario.TabIndex = 11;
            this.btnRemoverHorario.Text = "Remover";
            this.btnRemoverHorario.UseVisualStyleBackColor = true;
            this.btnRemoverHorario.Click += new System.EventHandler(this.btnRemoverHorario_Click);
            // 
            // btnAdicionarHorario
            // 
            this.btnAdicionarHorario.Location = new System.Drawing.Point(86, 40);
            this.btnAdicionarHorario.Name = "btnAdicionarHorario";
            this.btnAdicionarHorario.Size = new System.Drawing.Size(98, 37);
            this.btnAdicionarHorario.TabIndex = 10;
            this.btnAdicionarHorario.Text = "Adicionar";
            this.btnAdicionarHorario.UseVisualStyleBackColor = true;
            this.btnAdicionarHorario.Click += new System.EventHandler(this.btnAdicionarHorario_Click);
            // 
            // ID_TURMA
            // 
            this.ID_TURMA.HeaderText = "ID_TURMA";
            this.ID_TURMA.Name = "ID_TURMA";
            this.ID_TURMA.ReadOnly = true;
            // 
            // BLOCO
            // 
            this.BLOCO.HeaderText = "BLOCO";
            this.BLOCO.Name = "BLOCO";
            this.BLOCO.ReadOnly = true;
            // 
            // TURMA
            // 
            this.TURMA.HeaderText = "TURMA";
            this.TURMA.Name = "TURMA";
            this.TURMA.ReadOnly = true;
            // 
            // GerenciaTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAlterarHorario);
            this.Controls.Add(this.btnRemoverHorario);
            this.Controls.Add(this.btnAdicionarHorario);
            this.Name = "GerenciaTurmas";
            this.Text = "Gerenciamento de Turmas";
            this.Load += new System.EventHandler(this.GerenciaTurmas_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTurmas;
        private System.Windows.Forms.Button btnAlterarHorario;
        private System.Windows.Forms.Button btnRemoverHorario;
        private System.Windows.Forms.Button btnAdicionarHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TURMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BLOCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TURMA;
    }
}