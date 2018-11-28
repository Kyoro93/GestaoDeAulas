using GestaoDeAulas.Controle;
using GestaoDeAulas.Visao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeAulas
{
    public partial class Principal : Form
    {
        public Principal()
        {

            InitializeComponent();
            
        }

        private void gerenciamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshDataGridView()
        {
            ConexaoMySQL conn = new ConexaoMySQL();
            List<string> aulas = conn.SelectAulas();

            dgvAulasAgendadas.Rows.Clear();
            foreach (string s in aulas)
            {
                dgvAulasAgendadas.Rows.Add();
            }
            conn = null;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexaoMySQL conn = new ConexaoMySQL();
            conn.Insert();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciaProfessores _gerenciaProfessores1 = GerenciaProfessores.Instance;
            _gerenciaProfessores1.ShowDialog();
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciaHorarios _gerenciaHorarios1 = GerenciaHorarios.Instance;
            _gerenciaHorarios1.ShowDialog();
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciaTurmas _gerenciaTurmas1 = GerenciaTurmas.Instance;
            _gerenciaTurmas1.ShowDialog();
        }
    }
}
