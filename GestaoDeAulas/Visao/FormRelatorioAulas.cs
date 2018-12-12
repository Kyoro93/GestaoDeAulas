using GestaoDeAulas.Controle;
using GestaoDeAulas.Modelo;
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
    public partial class FormRelatorioAulas : Form
    {

        List<Aula> lista = new List<Aula>();

        public FormRelatorioAulas()
        {
            InitializeComponent();
        }

        private void FormRelatorioAulas_Load(object sender, EventArgs e)
        {
            lista = new DatabaseRelatorioAulas().ListAll();
            RelatorioAulas rpt = new RelatorioAulas();
            rpt.SetDataSource(lista);
            crvAulas.ReportSource = rpt;
        }
    }
}
