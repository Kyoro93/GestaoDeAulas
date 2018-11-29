namespace GestaoDeAulas.Visao
{
    partial class AlteraAula
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.rtbConteudo = new System.Windows.Forms.RichTextBox();
            this.cbbTurma = new System.Windows.Forms.ComboBox();
            this.cbbProfessor = new System.Windows.Forms.ComboBox();
            this.cbbHorario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(361, 73);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(361, 19);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Salvar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // rtbConteudo
            // 
            this.rtbConteudo.Location = new System.Drawing.Point(15, 137);
            this.rtbConteudo.Name = "rtbConteudo";
            this.rtbConteudo.Size = new System.Drawing.Size(581, 287);
            this.rtbConteudo.TabIndex = 17;
            this.rtbConteudo.Text = "";
            // 
            // cbbTurma
            // 
            this.cbbTurma.FormattingEnabled = true;
            this.cbbTurma.Location = new System.Drawing.Point(72, 70);
            this.cbbTurma.Name = "cbbTurma";
            this.cbbTurma.Size = new System.Drawing.Size(164, 21);
            this.cbbTurma.TabIndex = 16;
            // 
            // cbbProfessor
            // 
            this.cbbProfessor.FormattingEnabled = true;
            this.cbbProfessor.Location = new System.Drawing.Point(72, 43);
            this.cbbProfessor.Name = "cbbProfessor";
            this.cbbProfessor.Size = new System.Drawing.Size(164, 21);
            this.cbbProfessor.TabIndex = 15;
            // 
            // cbbHorario
            // 
            this.cbbHorario.FormattingEnabled = true;
            this.cbbHorario.Location = new System.Drawing.Point(72, 16);
            this.cbbHorario.Name = "cbbHorario";
            this.cbbHorario.Size = new System.Drawing.Size(164, 21);
            this.cbbHorario.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Conteúdo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Turma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Professor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Horário:";
            // 
            // AlteraAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 440);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.rtbConteudo);
            this.Controls.Add(this.cbbTurma);
            this.Controls.Add(this.cbbProfessor);
            this.Controls.Add(this.cbbHorario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlteraAula";
            this.Text = "AlteraAula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.RichTextBox rtbConteudo;
        private System.Windows.Forms.ComboBox cbbTurma;
        private System.Windows.Forms.ComboBox cbbProfessor;
        private System.Windows.Forms.ComboBox cbbHorario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}