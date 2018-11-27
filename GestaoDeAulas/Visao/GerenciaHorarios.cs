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
                String strID = s.Split(';')[0];
                String strHora = s.Split(';')[1];
                dgvHorarios.Rows.Add(strID, strHora);
            }
            conn = null;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int intIndex = dgvHorarios.CurrentCell.RowIndex;
            string strHorario = dgvHorarios.SelectedCells[0].Value.ToString();
            ConexaoMySQL conn = new ConexaoMySQL();
            conn.DeleteHorarios(strHorario);
            conn = null;
            refreshDataGridView();
            MessageBox.Show("O horario " + strHorario  + " foi removido com sucesso.");
        }

        private void GerenciaHorarios_Enter(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
    }
}
