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
    public sealed partial class GerenciaHorarios : Form
    {
        private static readonly GerenciaHorarios instance = new GerenciaHorarios();

        private GerenciaHorarios()
        {
            InitializeComponent();
            refreshDataGridView();
        }

        public static GerenciaHorarios Instance
        {
            get
            {
                return instance;
            }
        }

        private void refreshDataGridView()
        {
            ConexaoMySQL conn = new ConexaoMySQL();
            List<string> horarios = conn.SelectHorarios();

            dgvHorarios.Rows.Clear();
            foreach (string s in horarios)
            {
                dgvHorarios.Rows.Add(s);
            }
            conn = null;
        }

        private void btnRemoverHorario_Click(object sender, EventArgs e)
        {
            int intIndex = dgvHorarios.CurrentCell.RowIndex;
            string strHorario = dgvHorarios.SelectedCells[0].Value.ToString();
            if (MessageBox.Show("Deseja realmente remover o horário \"" + strHorario + "\"?", "Confirme para continuar",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ConexaoMySQL conn = new ConexaoMySQL();
                conn.DeleteHorario(strHorario);
                conn = null;
                MessageBox.Show("O horário " + strHorario + " foi removido com sucesso.");
                refreshDataGridView();
            }
        }

        private void GerenciaHorarios_Enter(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void GerenciaHorarios_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarHorario_Click(object sender, EventArgs e)
        {
            new InsereHorario().ShowDialog();
            refreshDataGridView();
        }

        private void btnAlterarHorario_Click(object sender, EventArgs e)
        {
            int intIndex = dgvHorarios.CurrentCell.RowIndex;
            string strHorario = dgvHorarios.SelectedCells[0].Value.ToString();
            new AlteraHorario(strHorario).ShowDialog();
            refreshDataGridView();
        }
    }
}
