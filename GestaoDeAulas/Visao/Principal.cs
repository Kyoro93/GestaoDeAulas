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
            refreshDataGridView();
            
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
                string strIdAulaAgendada = s.Split(';')[0];
                string strHorario = s.Split(';')[1];
                string strProfessor = s.Split(';')[2];
                string strTurma = s.Split(';')[3];
                string strBloco = s.Split(';')[4];
                string strConteudo = s.Split(';')[5];
                dgvAulasAgendadas.Rows.Add(strIdAulaAgendada, strHorario, strProfessor, strTurma, strBloco, strConteudo);
            }
            conn = null;
        }

        private void refreshDataGridViewWithSearch(string strParametro)
        {
            ConexaoMySQL conn = new ConexaoMySQL();
            List<string> aulas = conn.SelectAulas(strParametro);

            dgvAulasAgendadas.Rows.Clear();
            foreach (string s in aulas)
            {
                string strIdAulaAgendada = s.Split(';')[0];
                string strHorario = s.Split(';')[1];
                string strProfessor = s.Split(';')[2];
                string strTurma = s.Split(';')[3];
                string strBloco = s.Split(';')[4];
                string strConteudo = s.Split(';')[5];
                dgvAulasAgendadas.Rows.Add(strIdAulaAgendada, strHorario, strProfessor, strTurma, strBloco, strConteudo);
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

        private void dgvAulasAgendadas_DoubleClick(object sender, EventArgs e)
        {
            string strTurma = dgvAulasAgendadas.Rows[0].Cells[0].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            refreshDataGridViewWithSearch(txbPesquisa.Text);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            new InsereAula().ShowDialog();
            refreshDataGridView();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                string strIDAula = dgvAulasAgendadas.SelectedCells[0].Value.ToString();
                string strHorario = dgvAulasAgendadas.SelectedCells[1].Value.ToString();
                string strProfessor = dgvAulasAgendadas.SelectedCells[2].Value.ToString();
                string strTurma = dgvAulasAgendadas.SelectedCells[3].Value.ToString();
                string strBloco = dgvAulasAgendadas.SelectedCells[4].Value.ToString();
                string strConteudo = dgvAulasAgendadas.SelectedCells[5].Value.ToString();
                new AlteraAula(strIDAula, strHorario, strTurma, strBloco, strProfessor, strConteudo).ShowDialog();
                refreshDataGridView();
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("Você deve selecionar pelo menos 1 item para alterar");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string strIDAUla = dgvAulasAgendadas.SelectedCells[0].Value.ToString();
                if (MessageBox.Show("Deseja realmente remover a aula de ID \"" + strIDAUla + "\"?", "Confirme para continuar",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    ConexaoMySQL conn = new ConexaoMySQL();
                    conn.DeleteAula(strIDAUla);
                    conn = null;
                    MessageBox.Show("A aula de ID " + strIDAUla + " foi removida com sucesso.");
                    refreshDataGridView();
                }
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("Você deve selecionar pelo menos 1 item para excluir");
            }
        }
    }
}
