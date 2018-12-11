using GestaoDeAulas.Modelo;
using System;
using System.Collections.Generic;

namespace GestaoDeAulas.Controle
{
    class RelatorioAulas
    {
        private List<Aula> aulas { get; }

        public RelatorioAulas()
        {
            ConexaoMySQL conn = new ConexaoMySQL();
            foreach(string s in conn.SelectAulas(DateTime.Today.AddMonths(-1).ToString(), DateTime.Today.ToString()))
            {
                int intIdAulaAg = Convert.ToInt32(s.Split(';')[0]);
                string strHorario = s.Split(';')[1];
                string strProfessor = s.Split(';')[2];
                string strNome = s.Split(';')[3];
                string strBloco = s.Split(';')[4];
                string strConteudo = s.Split(';')[5];

                Aula a = new Aula(intIdAulaAg, strHorario, strProfessor, strNome, strBloco, strConteudo);
                aulas.Add(a);
            }
        }

    }
}
