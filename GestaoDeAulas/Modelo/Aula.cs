using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeAulas.Modelo
{
    class Aula
    {
        public int intIdAulaAgendada { get; set; }
        public string strHorario { get; set; }
        public string strProfessor { get; set; }
        public string strNome { get; set; }
        public string strBloco { get; set; }
        public string strConteudo { get; set; }
        public string strData { get; set; }

        public Aula(int intIdAulaAgendada, string strHorario, string strProfessor, string strNome, string strBloco, string strConteudo, string strData)
        {
            this.intIdAulaAgendada = intIdAulaAgendada;
            this.strHorario = strHorario;
            this.strProfessor = strProfessor;
            this.strNome = strNome;
            this.strBloco = strBloco;
            this.strConteudo = strConteudo;
            this.strData = strData;
        }
    }
}
