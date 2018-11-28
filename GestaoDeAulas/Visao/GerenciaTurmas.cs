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
    public partial class GerenciaTurmas : Form
    {
        private static readonly GerenciaTurmas instance = new GerenciaTurmas();

        private GerenciaTurmas()
        {
            InitializeComponent();
            refreshDataGridView();
        }

        public static GerenciaTurmas Instance
        {
            get
            {
                return instance;
            }
        }

        private void refreshDataGridView()
        {
            ConexaoMySQL conn = new ConexaoMySQL();
            List<string> turmas = conn.SelectTurmas();

            dgvTurmas.Rows.Clear();
            foreach (string s in turmas)
            {
                string strIdTurma = s.Split(';')[0];
                string strTurma = s.Split(';')[1];
                string strBloco = s.Split(';')[2];
                dgvTurmas.Rows.Add(strIdTurma, strTurma, strBloco);
            }
            conn = null;
        }

        private void GerenciaTurmas_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarHorario_Click(object sender, EventArgs e)
        {
            new InsereTurma().ShowDialog();
            refreshDataGridView();
        }

        private void btnRemoverHorario_Click(object sender, EventArgs e)
        {
            try {
                string strTurma = dgvTurmas.SelectedCells[1].Value.ToString();
                string strBloco = dgvTurmas.SelectedCells[2].Value.ToString();
                if (MessageBox.Show("Deseja realmente remover a turma \"" + strTurma + "/" + strBloco + "\"?", "Confirme para continuar",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    ConexaoMySQL conn = new ConexaoMySQL();
                    conn.DeleteTurma(strTurma, strBloco);
                    conn = null;
                    MessageBox.Show("A turma " + strTurma + "/" + strBloco + " foi removido com sucesso.");
                    refreshDataGridView();
                }
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("Você deve selecionar pelo menos 1 item para excluir");
            }
        }

        private void btnAlterarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                string strTurma = dgvTurmas.SelectedCells[1].Value.ToString();
                string strBloco = dgvTurmas.SelectedCells[2].Value.ToString();
                new AlteraTurma(strTurma, strBloco).ShowDialog();
                refreshDataGridView();
            } catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("Você deve selecionar pelo menos 1 item para alterar");
            }
        }
    }
}
