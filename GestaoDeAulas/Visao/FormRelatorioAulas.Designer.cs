namespace GestaoDeAulas.Visao
{
    partial class FormRelatorioAulas
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
            this.crvAulas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvAulas
            // 
            this.crvAulas.ActiveViewIndex = -1;
            this.crvAulas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvAulas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvAulas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvAulas.Location = new System.Drawing.Point(0, 0);
            this.crvAulas.Name = "crvAulas";
            this.crvAulas.Size = new System.Drawing.Size(800, 450);
            this.crvAulas.TabIndex = 0;
            // 
            // FormRelatorioAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvAulas);
            this.Name = "FormRelatorioAulas";
            this.Text = "FormRelatorioAulas";
            this.Load += new System.EventHandler(this.FormRelatorioAulas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvAulas;
    }
}