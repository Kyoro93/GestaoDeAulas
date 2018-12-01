using GestaoDeAulas.Controle;
using System;
using System.Windows.Forms;

namespace GestaoDeAulas.Visao
{
    public partial class AlteraHorario : Form
    {
        string strAntigoHorario = "";

        public AlteraHorario(string strAntigoHorario)
        {
            this.strAntigoHorario = strAntigoHorario;
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string strNovoHorario = txbNovoHorario.Text;

            try
            {
                ConexaoMySQL conn = new ConexaoMySQL();
                bool result = conn.UpdateHorario(strNovoHorario, this.strAntigoHorario);

                if (!result)
                {
                    MessageBox.Show("Erro ao atualizar.");
                }
                else
                {
                    MessageBox.Show("Alterado com sucesso.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.Name + " - Error: " + ex.Message);
            }
        }

        private void AlteraHorario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
