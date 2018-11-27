namespace GestaoDeAulas.Visao
{
    partial class GerenciaProfessores
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
            this.btnAdicionarProfessor = new System.Windows.Forms.Button();
            this.btnRemoverProfessor = new System.Windows.Forms.Button();
            this.btnAlterarProfessor = new System.Windows.Forms.Button();
            this.dgvProfessores = new System.Windows.Forms.DataGridView();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionarProfessor
            // 
            this.btnAdicionarProfessor.Location = new System.Drawing.Point(102, 35);
            this.btnAdicionarProfessor.Name = "btnAdicionarProfessor";
            this.btnAdicionarProfessor.Size = new System.Drawing.Size(98, 37);
            this.btnAdicionarProfessor.TabIndex = 0;
            this.btnAdicionarProfessor.Text = "Adicionar";
            this.btnAdicionarProfessor.UseVisualStyleBackColor = true;
            this.btnAdicionarProfessor.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnRemoverProfessor
            // 
            this.btnRemoverProfessor.Location = new System.Drawing.Point(310, 35);
            this.btnRemoverProfessor.Name = "btnRemoverProfessor";
            this.btnRemoverProfessor.Size = new System.Drawing.Size(98, 37);
            this.btnRemoverProfessor.TabIndex = 1;
            this.btnRemoverProfessor.Text = "Remover";
            this.btnRemoverProfessor.UseVisualStyleBackColor = true;
            this.btnRemoverProfessor.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAlterarProfessor
            // 
            this.btnAlterarProfessor.Location = new System.Drawing.Point(206, 35);
            this.btnAlterarProfessor.Name = "btnAlterarProfessor";
            this.btnAlterarProfessor.Size = new System.Drawing.Size(98, 37);
            this.btnAlterarProfessor.TabIndex = 4;
            this.btnAlterarProfessor.Text = "Alterar";
            this.btnAlterarProfessor.UseVisualStyleBackColor = true;
            this.btnAlterarProfessor.Click += new System.EventHandler(this.btnAlterarProfessor_Click);
            // 
            // dgvProfessores
            // 
            this.dgvProfessores.AllowUserToAddRows = false;
            this.dgvProfessores.AllowUserToDeleteRows = false;
            this.dgvProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOME});
            this.dgvProfessores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfessores.Location = new System.Drawing.Point(0, 0);
            this.dgvProfessores.Name = "dgvProfessores";
            this.dgvProfessores.ReadOnly = true;
            this.dgvProfessores.Size = new System.Drawing.Size(499, 332);
            this.dgvProfessores.TabIndex = 2;
            this.dgvProfessores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NOME
            // 
            this.NOME.HeaderText = "Nome";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProfessores);
            this.panel1.Location = new System.Drawing.Point(12, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 332);
            this.panel1.TabIndex = 3;
            // 
            // GerenciaProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 454);
            this.Controls.Add(this.btnAlterarProfessor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemoverProfessor);
            this.Controls.Add(this.btnAdicionarProfessor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GerenciaProfessores";
            this.Text = "Gerenciamento de Professores";
            this.Load += new System.EventHandler(this.GerenciaProfessores_Enter);
            this.Shown += new System.EventHandler(this.GerenciaProfessores_Enter);
            this.Enter += new System.EventHandler(this.GerenciaProfessores_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarProfessor;
        private System.Windows.Forms.Button btnRemoverProfessor;
        private System.Windows.Forms.Button btnAlterarProfessor;
        private System.Windows.Forms.DataGridView dgvProfessores;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.Panel panel1;
    }
}