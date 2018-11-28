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
    public partial class AlteraAula : Form
    {
        string strIDAula = "";
        string strAntigoHorario = "";
        string strAntigaTurma = "";
        string strAntigoBloco = "";
        string strAntigoProfessor = "";
        string strAntigoConteudo = "";

        public AlteraAula(string strIDAula, string strAntigoHorario, string strAntigaTurma, string strAntigoBloco, string strAntigoProfessor, string strAntigoConteudo)
        {
            InitializeComponent();
            this.strIDAula = strIDAula;
            this.strAntigoHorario = strAntigoHorario;
            this.strAntigaTurma = strAntigaTurma;
            this.strAntigoBloco = strAntigoBloco;
            this.strAntigoProfessor = strAntigoProfessor;
            this.strAntigoConteudo = strAntigoConteudo;
            refreshComboBox();
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

                cbbHorario.SelectedItem = this.strAntigoHorario;
                cbbProfessor.SelectedItem = this.strAntigoProfessor;
                cbbTurma.SelectedItem = this.strAntigaTurma+"/"+this.strAntigoBloco;
                rtbConteudo.Text = this.strAntigoConteudo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
