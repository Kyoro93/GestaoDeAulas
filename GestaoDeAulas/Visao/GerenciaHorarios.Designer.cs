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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.btnRemoverHorario = new System.Windows.Forms.Button();
            this.btnAdicionarHorario = new System.Windows.Forms.Button();
            this.ID_HORARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterarHorario
            // 
            this.btnAlterarHorario.Location = new System.Drawing.Point(206, 19);
            this.btnAlterarHorario.Name = "btnAlterarHorario";
            this.btnAlterarHorario.Size = new System.Drawing.Size(98, 37);
            this.btnAlterarHorario.TabIndex = 8;
            this.btnAlterarHorario.Text = "Alterar";
            this.btnAlterarHorario.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvHorarios);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 332);
            this.panel1.TabIndex = 7;
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_HORARIO,
            this.HORARIO});
            this.dgvHorarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHorarios.Location = new System.Drawing.Point(0, 0);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.ReadOnly = true;
            this.dgvHorarios.Size = new System.Drawing.Size(499, 332);
            this.dgvHorarios.TabIndex = 2;
            // 
            // btnRemoverHorario
            // 
            this.btnRemoverHorario.Location = new System.Drawing.Point(310, 19);
            this.btnRemoverHorario.Name = "btnRemoverHorario";
            this.btnRemoverHorario.Size = new System.Drawing.Size(98, 37);
            this.btnRemoverHorario.TabIndex = 6;
            this.btnRemoverHorario.Text = "Remover";
            this.btnRemoverHorario.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarHorario
            // 
            this.btnAdicionarHorario.Location = new System.Drawing.Point(102, 19);
            this.btnAdicionarHorario.Name = "btnAdicionarHorario";
            this.btnAdicionarHorario.Size = new System.Drawing.Size(98, 37);
            this.btnAdicionarHorario.TabIndex = 5;
            this.btnAdicionarHorario.Text = "Adicionar";
            this.btnAdicionarHorario.UseVisualStyleBackColor = true;
            // 
            // ID_HORARIO
            // 
            this.ID_HORARIO.HeaderText = "ID_HORARIO";
            this.ID_HORARIO.Name = "ID_HORARIO";
            this.ID_HORARIO.ReadOnly = true;
            // 
            // HORARIO
            // 
            this.HORARIO.HeaderText = "HORARIO";
            this.HORARIO.Name = "HORARIO";
            this.HORARIO.ReadOnly = true;
            // 
            // GerenciaHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 435);
            this.Controls.Add(this.btnAlterarHorario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemoverHorario);
            this.Controls.Add(this.btnAdicionarHorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GerenciaHorarios";
            this.Text = "GerenciaHorarios";
            this.Load += new System.EventHandler(this.GerenciaHorarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarHorario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.Button btnRemoverHorario;
        private System.Windows.Forms.Button btnAdicionarHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HORARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO;
    }
}