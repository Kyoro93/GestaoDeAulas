using GestaoDeAulas.Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeAulas.Visao
{
    public partial class GerenciaProfessores : Form
    {
        public GerenciaProfessores()
        {
            InitializeComponent();
        }

        private void refreshDataGridView()
        {
            ConexaoMySQL conn = new ConexaoMySQL();
            List<string> professores = conn.SelectProfessores();

            dgvProfessores.Rows.Clear();
            foreach (string s in professores)
            {
                dgvProfessores.Rows.Add(s);
            }
            conn = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int intIndex = dgvProfessores.CurrentCell.RowIndex;
            string strProfessor = dgvProfessores.SelectedCells[0].Value.ToString();
            ConexaoMySQL conn = new ConexaoMySQL();
            conn.DeleteProfessores(strProfessor);
            conn = null;
            refreshDataGridView();
            MessageBox.Show("O professor "+strProfessor + " foi removido com sucesso.");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new InsereProfessor().ShowDialog();
            refreshDataGridView();
        }

        private void GerenciaProfessores_Enter(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
    }
}
