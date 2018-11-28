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
    public partial class InsereHorario : Form
    {
        public InsereHorario()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string strHorario = txbHorario.Text;
            try
            {
                ConexaoMySQL conn = new ConexaoMySQL();
                bool result = conn.InsertHorario(strHorario);

                if (!result)
                {
                    MessageBox.Show("Erro ao inserir.");
                }
                else
                {
                    MessageBox.Show("Inserido com sucesso.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.Name + " - Error: " + ex.Message);
            }
        }

        private void InsereHorario_Load(object sender, EventArgs e)
        {

        }
    }
}
