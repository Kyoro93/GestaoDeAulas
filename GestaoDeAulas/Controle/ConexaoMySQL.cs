using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//Add MySql Library
using MySql.Data.MySqlClient;

namespace GestaoDeAulas.Controle
{
    class ConexaoMySQL
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public ConexaoMySQL()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "sql174.main-hosting.eu";
            database = "u237556805_lp2";
            uid = "u237556805_lp2";
            password = "lp2123";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert()
        {
            string query = "INSERT INTO Teste (NOME) VALUES('Samuel - "+DateTime.Now+"')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }

        /// <summary>
        /// PROFESSORES
        /// </summary>
        /// <param name="professor"></param>
        /// 


        public List<string> SelectProfessores()
        {
            string query = "SELECT * FROM PROFESSOR";

            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["NOME"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public void DeleteProfessor(string nome)
        {
            string query = "DELETE FROM PROFESSOR WHERE NOME LIKE '"+nome+"'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public bool InsertProfessor(string strNome)
        {
            string query = "INSERT INTO PROFESSOR (NOME) VALUES('" + strNome + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                int result = cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

                if (result > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool UpdateProfessor(string strNovoNome, string strAntigoNome)
        {
            string query = "UPDATE PROFESSOR SET NOME = \""+strNovoNome+"\" WHERE NOME LIKE \"" + strAntigoNome + "\"";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                int result = cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

                if (result > 0)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// AULAS
        /// </summary>
        /// <param name="aula"></param>
        /// 

        public List<string> SelectAulas()
        {
            string query = "SELECT " +
                                    "AULA_AGENDADA.ID_AULA_AGENDADA, " +
                                    "HORARIO_AULA.HORARIO, " +
                                    "AULA_AGENDADA.PROFESSOR, " +
                                    "TURMA.NOME, " +
                                    "TURMA.BLOCO, " +
                                    "AULA_AGENDADA.CONTEUDO " +
                            "FROM " +
                                    "`AULA_AGENDADA` " +
                                    "JOIN HORARIO_AULA ON HORARIO_AULA.ID_HORARIO = AULA_AGENDADA.ID_HORARIO " +
                                    "JOIN TURMA ON TURMA.ID_TURMA = AULA_AGENDADA.ID_TURMA ";

            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    // TODO: Arrumar as colunas para retornar tudo da aula
                    list.Add(dataReader["ID_AULA_AGENDADA"] + ";" +
                        dataReader["HORARIO"] + ";" +
                        dataReader["PROFESSOR"] + ";" +
                        dataReader["NOME"] + ";" +
                        dataReader["BLOCO"] + ";" +
                        dataReader["CONTEUDO"]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string> SelectAulas(string strParametro)
        {
            string query = "SELECT " +
                                    "AULA_AGENDADA.ID_AULA_AGENDADA, " +
                                    "HORARIO_AULA.HORARIO, " +
                                    "AULA_AGENDADA.PROFESSOR, " +
                                    "TURMA.NOME, " +
                                    "TURMA.BLOCO, " +
                                    "AULA_AGENDADA.CONTEUDO " +
                            "FROM " +
                                    "AULA_AGENDADA " +
                                    "JOIN HORARIO_AULA ON HORARIO_AULA.ID_HORARIO = AULA_AGENDADA.ID_HORARIO " +
                                    "JOIN TURMA ON TURMA.ID_TURMA = AULA_AGENDADA.ID_TURMA " +
                            "WHERE " +
                                    "HORARIO_AULA.HORARIO LIKE '%" + strParametro + "%' OR " +
                                    "AULA_AGENDADA.PROFESSOR LIKE '%" + strParametro + "%' OR " +
                                    "TURMA.NOME LIKE '%" + strParametro + "%' OR " +
                                    "TURMA.BLOCO LIKE '%" + strParametro + "%' OR "  +
                                    "AULA_AGENDADA.CONTEUDO LIKE '%" + strParametro + "%' ";

            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    // TODO: Arrumar as colunas para retornar tudo da aula
                    list.Add(dataReader["ID_AULA_AGENDADA"] + ";" +
                        dataReader["HORARIO"] + ";" +
                        dataReader["PROFESSOR"] + ";" +
                        dataReader["NOME"] + ";" +
                        dataReader["BLOCO"] + ";" +
                        dataReader["CONTEUDO"]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public bool InsertAula(string strHorario, string strProfessor, string strTurma, string strBloco, string strConteudo)
        {
            string query = "INSERT INTO `AULA_AGENDADA` (`ID_HORARIO`, `PROFESSOR`, `ID_TURMA`, `CONTEUDO`) VALUES ((SELECT ID_HORARIO FROM HORARIO_AULA WHERE HORARIO LIKE '" + strHorario +"'), '" + strProfessor +"', (SELECT ID_TURMA FROM TURMA WHERE NOME LIKE '" + strTurma +"' AND BLOCO LIKE '" + strBloco + "'), '" + strConteudo +"')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                int result = cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

                if (result > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void DeleteAula(string strIDAula)
        {
            string query = "DELETE FROM AULA_AGENDADA WHERE ID_AULA_AGENDADA = " + strIDAula + "";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// HORARIOS
        /// </summary>
        /// <param name="horario"></param>
        /// 

        public List<string> SelectHorarios()
        {
            string query = "SELECT * FROM HORARIO_AULA";

            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["ID_HORARIO"] + ";" + dataReader["HORARIO"]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public bool InsertHorario(string strHorario)
        {
            string query = "INSERT INTO HORARIO_AULA (HORARIO) VALUES('" + strHorario + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                int result = cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

                if (result > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool UpdateHorario(string strNovoHorario, string strAntigoHorario)
        {
            string query = "UPDATE HORARIO_AULA SET HORARIO = \"" + strNovoHorario + "\" WHERE HORARIO LIKE \"" + strAntigoHorario + "\"";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                int result = cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

                if (result > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void DeleteHorario(string horario)
        {
            string query = "DELETE FROM HORARIO_AULA WHERE HORARIO = \"" + horario + "\"";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// TURMAS
        /// </summary>
        /// <param name="turmas"></param>
        /// 

        public List<string> SelectTurmas()
        {
            string query = "SELECT * FROM TURMA";

            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["ID_TURMA"] + ";" + dataReader["NOME"] + ";" + dataReader["BLOCO"]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public bool InsertTurma(string strTurma, string strBloco)
        {
            string query = "INSERT INTO TURMA (NOME, BLOCO) VALUES('" + strTurma + "', '" + strBloco + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                int result = cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

                if (result > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool UpdateTurma(string strNovaTurma, string strAntigaTurma, string strNovoBloco, string strAntigoBloco)
        {
            string query = "UPDATE TURMA SET NOME = \"" + strNovaTurma + "\", BLOCO = \"" + strNovoBloco + "\" WHERE NOME LIKE \"" + strAntigaTurma + "\" AND BLOCO LIKE \"" + strAntigoBloco + "\"";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                int result = cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

                if (result > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void DeleteTurma(string strTurma, string strBloco)
        {
            string query = "DELETE FROM TURMA WHERE NOME LIKE \"" + strTurma + "\" AND BLOCO LIKE \"" + strBloco + "\"";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
    }
}