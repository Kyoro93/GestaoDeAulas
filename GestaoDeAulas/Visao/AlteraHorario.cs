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
    }
}
