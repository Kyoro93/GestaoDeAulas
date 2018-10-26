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
    public partial class InsereProfessor : Form
    {
        public InsereProfessor()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string strNome = txbNome.Text;
            try
            {
                ConexaoMySQL conn = new ConexaoMySQL();
                bool result = conn.InsertProfessores(strNome);

                if (!result)
                {
                    MessageBox.Show("Erro ao inserir.");
                }
                else
                {
                    MessageBox.Show("Inserido com sucesso.");
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(this.Name + " - Error: " + ex.Message);
            }
        }

        private void InsereProfessor_Load(object sender, EventArgs e)
        {

        }
    }
}
