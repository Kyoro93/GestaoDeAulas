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
    public partial class AlteraProfessor : Form
    {
        string strAntigoNome = "";

        public AlteraProfessor(string strAntigoNome)
        {
            this.strAntigoNome = strAntigoNome;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string strNovoNome = txbNovoNome.Text;
            
            try
            {
                ConexaoMySQL conn = new ConexaoMySQL();
                bool result = conn.UpdateProfessor(strNovoNome, this.strAntigoNome);

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
