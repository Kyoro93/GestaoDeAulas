using GestaoDeAulas.Modelo;
using System;
using System.Collections.Generic;

namespace GestaoDeAulas.Controle
{
    class DatabaseRelatorioAulas
    {
        private List<Aula> aulas { get; }

        public DatabaseRelatorioAulas()
        {
            ConexaoMySQL conn = new ConexaoMySQL();
            aulas = new List<Aula>();
            foreach(string s in conn.SelectAulas(DateTime.Today.AddMonths(-1).ToString("yyyy-MM-dd HH:mm:ss"), DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss")))
            {
                int intIdAulaAg = Convert.ToInt32(s.Split(';')[0]);
                string strHorario = s.Split(';')[1];
                string strProfessor = s.Split(';')[2];
                string strNome = s.Split(';')[3];
                string strBloco = s.Split(';')[4];
                string strConteudo = s.Split(';')[5];
                string strData = s.Split(';')[6];

                Aula a = new Aula(intIdAulaAg, strHorario, strProfessor, strNome, strBloco, strConteudo, strData);
                aulas.Add(a);
            }

        }

        public List<Aula> ListAll()
        {
            return this.aulas;
        }

    }
}
