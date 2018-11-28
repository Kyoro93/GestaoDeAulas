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
    public partial class InsereAula : Form
    {
        private static readonly InsereAula instance = new InsereAula();

        public InsereAula()
        {
            InitializeComponent();
            refreshComboBox();
        }

        public static InsereAula Instance
        {
            get
            {
                return instance;
            }
        }

        private void refreshComboBox()
        {
            try
            {
                ConexaoMySQL conn = new ConexaoMySQL();
                List<string> horarios = conn.SelectHorarios();
                List<string> professores = conn.SelectProfessores();
                List<string> turmas = conn.SelectTurmas();

                foreach (string s in horarios)
                {
                    cbbHorario.Items.Add(s.Split(';')[1]);
                }

                foreach (string s in professores)
                {
                    cbbProfessor.Items.Add(s);
                }

                foreach (string s in turmas)
                {
                    cbbTurma.Items.Add(s.Split(';')[1] + "/" + s.Split(';')[2]);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void InsereAula_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            

            try
            {
                string strHorario = cbbHorario.Text;
                string strProfessor = cbbProfessor.Text;
                string strTurma = cbbTurma.Text.Split('/')[0];
                string strBloco = cbbTurma.Text.Split('/')[1];
                string strConteudo = rtbConteudo.Text;

                ConexaoMySQL conn = new ConexaoMySQL();
                
                bool result = conn.InsertAula(strHorario, strProfessor, strTurma, strBloco, strConteudo);

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
    }
}
