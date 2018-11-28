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
    public partial class AlteraTurma : Form
    {
        string strAntigaTurma = "";
        string strAntigoBloco = "";

        public AlteraTurma(string strAntigaTurma, string strAntigoBloco)
        {
            InitializeComponent();
            this.strAntigaTurma = strAntigaTurma;
            this.strAntigoBloco = strAntigoBloco;
            txbNovaTurma.Text = strAntigaTurma;
            txbNovoBloco.Text = strAntigoBloco;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string strNovaTurma = txbNovaTurma.Text;
            string strNovoBloco = txbNovoBloco.Text;

            try
            {
                ConexaoMySQL conn = new ConexaoMySQL();
                bool result = conn.UpdateTurma(strNovaTurma, this.strAntigaTurma, strNovoBloco, this.strAntigoBloco);

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlteraTurma_Load(object sender, EventArgs e)
        {

        }
    }
}
