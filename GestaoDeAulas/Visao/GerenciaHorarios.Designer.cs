namespace GestaoDeAulas.Visao
{
    partial class GerenciaHorarios
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
            this.btnAlterarHorario = new System.Windows.Forms.Button();
            this.btnRemoverHorario = new System.Windows.Forms.Button();
            this.btnAdicionarHorario = new System.Windows.Forms.Button();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlterarHorario
            // 
            this.btnAlterarHorario.Location = new System.Drawing.Point(190, 40);
            this.btnAlterarHorario.Name = "btnAlterarHorario";
            this.btnAlterarHorario.Size = new System.Drawing.Size(98, 37);
            this.btnAlterarHorario.TabIndex = 7;
            this.btnAlterarHorario.Text = "Alterar";
            this.btnAlterarHorario.UseVisualStyleBackColor = true;
            // 
            // btnRemoverHorario
            // 
            this.btnRemoverHorario.Location = new System.Drawing.Point(294, 40);
            this.btnRemoverHorario.Name = "btnRemoverHorario";
            this.btnRemoverHorario.Size = new System.Drawing.Size(98, 37);
            this.btnRemoverHorario.TabIndex = 6;
            this.btnRemoverHorario.Text = "Remover";
            this.btnRemoverHorario.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarHorario
            // 
            this.btnAdicionarHorario.Location = new System.Drawing.Point(86, 40);
            this.btnAdicionarHorario.Name = "btnAdicionarHorario";
            this.btnAdicionarHorario.Size = new System.Drawing.Size(98, 37);
            this.btnAdicionarHorario.TabIndex = 5;
            this.btnAdicionarHorario.Text = "Adicionar";
            this.btnAdicionarHorario.UseVisualStyleBackColor = true;
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.HORA});
            this.dgvHorarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHorarios.Location = new System.Drawing.Point(0, 0);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.ReadOnly = true;
            this.dgvHorarios.Size = new System.Drawing.Size(497, 340);
            this.dgvHorarios.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvHorarios);
            this.panel2.Location = new System.Drawing.Point(12, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 340);
            this.panel2.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // HORA
            // 
            this.HORA.HeaderText = "HORA";
            this.HORA.Name = "HORA";
            this.HORA.ReadOnly = true;
            // 
            // GerenciaHorarios
            // 
            this.ClientSize = new System.Drawing.Size(521, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAlterarHorario);
            this.Controls.Add(this.btnRemoverHorario);
            this.Controls.Add(this.btnAdicionarHorario);
            this.Name = "GerenciaHorarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HORARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO;
        private System.Windows.Forms.Button btnAlterarHorario;
        private System.Windows.Forms.Button btnRemoverHorario;
        private System.Windows.Forms.Button btnAdicionarHorario;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
    }
}