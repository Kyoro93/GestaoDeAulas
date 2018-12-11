using GestaoDeAulas.Controle;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestaoDeAulas.Visao
{
    public partial class AlteraAula : Form
    {
        int intIDAula;
        string strAntigoHorario = "";
        string strAntigaTurma = "";
        string strAntigoBloco = "";
        string strAntigoProfessor = "";
        string strAntigoConteudo = "";
        string strAntigaData = "";

        public AlteraAula(int intIDAula, string strAntigoHorario, string strAntigaTurma, string strAntigoBloco, string strAntigoProfessor, string strAntigoConteudo, string strAntigaData)
        {
            InitializeComponent();
            this.intIDAula = intIDAula;
            this.strAntigoHorario = strAntigoHorario;
            this.strAntigaTurma = strAntigaTurma;
            this.strAntigoBloco = strAntigoBloco;
            this.strAntigoProfessor = strAntigoProfessor;
            this.strAntigoConteudo = strAntigoConteudo;
            this.strAntigaData = Convert.ToDateTime(strAntigaData).ToString("yyyy-MM-dd H:mm:ss");
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
                mtcCalendario.SetSelectionRange(Convert.ToDateTime(strAntigaData.ToString()), Convert.ToDateTime(strAntigaData.ToString()));
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string strNovoHorario = cbbHorario.Text;
            string strNovoProfessor = cbbProfessor.Text;
            string strNovaTurma = cbbTurma.Text.Split('/')[0];
            string strNovoBloco = cbbTurma.Text.Split('/')[1];
            string strNovoConteudo = rtbConteudo.Text;
            string strNovaData = mtcCalendario.SelectionStart.ToString("yyyy-MM-dd H:mm:ss");
            
            if (!(strNovoHorario.Equals(strAntigoHorario) &&
               strNovoProfessor.Equals(strAntigoProfessor) &&
               strNovaTurma.Equals(strAntigaTurma) &&
               strNovoBloco.Equals(strAntigoBloco) &&
               strNovoConteudo.Equals(strAntigoConteudo) &&
               strNovaData.Equals(strAntigaData)))
            {

                try
                {
                    ConexaoMySQL conn = new ConexaoMySQL();
                    bool result = conn.UpdateAula(strNovoHorario, strNovoProfessor, strNovaTurma, strNovoBloco, strNovoConteudo, strNovaData, this.intIDAula);

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
            else
            {
                this.Close();
            }
        }

        private void AlteraAula_Load(object sender, EventArgs e)
        {

        }
    }
}
