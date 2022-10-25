using System;
using ControleFinanceiroIgreja.TAD;
using System.Data;
using System.Data.SQLite;

namespace ControleFinanceiroIgreja.DAO
{
    class CrudEscola
    {
        /////////////////////////////////////////// CLASSES /////////////////////////////////////////////////
        public DataTable listaClasses(SQLiteConnection con, bool inativos)
        {
            string strSql = " SELECT Id, Descricao as 'Descrição', Alunos, Professores, [Ultima Reuniao] as Ultima, Inativo" +
                            " from VWCLASSES " +
                            (inativos ? "" : " WHERE INATIVO = 0");
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return (dt);
        }

        public void altStatusClasse(SQLiteConnection con, int idClasse)
        {
            SQLiteCommand cmd = new SQLiteCommand("SPSTATUSCLASSE", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDCLASSE", idClasse);

            cmd.ExecuteNonQuery();

        }

        public void alteraClasse(SQLiteConnection con, Classe cla)
        {
            SQLiteCommand cmd = new SQLiteCommand("SPALTCLASSE", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", cla.id);
            cmd.Parameters.AddWithValue("@Desc", cla.desc);

            cmd.ExecuteNonQuery();
        }
        //////////////////////////////////////////////////////////// ALUNOS ///////////////////////////////////////////
        public DataTable listaAlunos(SQLiteConnection con, int idClasse, bool inativos)
        {


            string strSql = " SELECT Id, IdMembro, Nome, Presencas as 'Presenças', Faltas, Pontos, Inativo, IdColor" +
                            " from VwClasseMembros" +
                            " WHERE IDCLASSE = " + idClasse +
                            (inativos ? "" : " AND INATIVO = 0") +
                            " ORDER BY NOME";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return (dt);
        }

        public DataTable listaAlunosClasse(SQLiteConnection con, int idClasse, int ano, bool inativos)
        {


            string strSql = " SELECT Nome, IdColor, Jan, Fev, Mar, Abr, Mai, Jun, Jul, Ago, [Set], Out, Nov, Dez " +
                " FROM FCMEMBROSCLASSE(@ano, @idClasse)" +
                (inativos ? "" : "WHERE INATIVO = 0");
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            // cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idClasse", idClasse);
            cmd.Parameters.AddWithValue("@ano", ano);
            cmd.Parameters.AddWithValue("@inativos", inativos);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return (dt);
        }

        public DataTable listaAlunosReuniao(SQLiteConnection con, int idReuniao)
        {


            string strSql = " SELECT RM.Id, CM.IdColor ,RM.IdClasseMembros, M.Nome, RM.Presente " +
                            " from TbReuniaoMembros RM" +
                            //  " INNER JOIN TBREUNIAO R " +
                            //  " ON R.ID = RM.IDREUNIAO " +
                            " INNER JOIN TBCLASSEMEMBROS CM " +
                            " ON RM.IDCLASSEMEMBROS = CM.ID " +
                            " INNER JOIN TBMEMBROS M " +
                            " ON CM.IDMEMBRO = M.ID " +
                            " WHERE idReuniao = " + idReuniao;
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return (dt);
        }

        public void cadAluno(SQLiteConnection con, int idClasse, int idMembro)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO TBCLASSEMEMBROS (IDCLASSE, IDMEMBRO) " +
                                            " VALUES (@IDCLASSE, @IDMEMBRO) ", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@IDCLASSE", idClasse);
            cmd.Parameters.AddWithValue("@IDMEMBRO", idMembro);

            cmd.ExecuteNonQuery();
        }


        public void altStatusAluno(SQLiteConnection con, int idAluno)
        {
            SQLiteCommand cmd = new SQLiteCommand("SPSTATUSCLASSEMEMBRO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDCLASSEMEMBRO", idAluno);

            cmd.ExecuteNonQuery();

        }

        public void removeAluno(SQLiteConnection con, int idAluno)
        {
            SQLiteCommand cmd = new SQLiteCommand("SPREMOVECLASSEMEMBRO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDCLASSEMEMBRO", idAluno);

            cmd.ExecuteNonQuery();

        }


        /////////////////////////////////////////////////////////// PROFESSORES //////////////////////////////////////
        public DataTable listaProfessores(SQLiteConnection con, int idClasse)
        {
            string strSql = " SELECT Id, IdMembro, Nome" +
                            " from VwClasseProfessores " +
                            " WHERE IDCLASSE = " + idClasse;
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        public void removeProfessor(SQLiteConnection con, int idProfessor)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM TBCLASSEPROFESSORES WHERE ID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", idProfessor);

            cmd.ExecuteNonQuery();

        }

        public void cadProfessor(SQLiteConnection con, int idClasse, int idMembro)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO TBCLASSEPROFESSORES (IDCLASSE, IDMEMBRO) " +
                                            " VALUES (@IDCLASSE, @IDMEMBRO) ", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@IDCLASSE", idClasse);
            cmd.Parameters.AddWithValue("@IDMEMBRO", idMembro);

            cmd.ExecuteNonQuery();
        }

        ////////////////////////////////////////////////////  REUNIOES ///////////////////////////////////////////////////
        public DataTable listaReunioes(SQLiteConnection con, int idClasse, int ano = 0)
        {
            string strSql = " SELECT Id, Data, Presentes, Ausentes, Visitantes, Biblias, Revistas, Oferta, Obs as 'Observação'" +
                            " from VWReuniao " +
                            " WHERE IDCLASSE = " + idClasse +
                            (ano > 0 ? " AND YEAR(DATA) =  " + ano : "") +
                            " ORDER BY DATA";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return (dt);
        }

        public void removeReuniao(SQLiteConnection con, int idReuniao)
        {
            SQLiteCommand cmd = new SQLiteCommand("SPREMOVEREUNIAO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", idReuniao);

            cmd.ExecuteNonQuery();

        }

        public DataTable listaAnosReunioes(SQLiteConnection con, int idClasse)
        {
            string strSql = " SELECT DISTINCT YEAR(DATA) as Ano" +
                            " from VWReuniao " +
                            " WHERE IDCLASSE = " + idClasse;
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return (dt);
        }

        public void altReuniao(SQLiteConnection con, Reuniao reu, DataTable dtAlunos)
        {
            SQLiteCommand cmd = new SQLiteCommand("SPALTREUNIAO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", reu.id);
            cmd.Parameters.AddWithValue("@Data", reu.data);
            cmd.Parameters.AddWithValue("@IDClasse", reu.idClasse);
            cmd.Parameters.AddWithValue("@OBS", reu.obs);
            cmd.Parameters.AddWithValue("@OFERTA", reu.oferta);
            cmd.Parameters.AddWithValue("@REVISTAS", reu.revistas);
            cmd.Parameters.AddWithValue("@BIBLIAS", reu.biblias);
            cmd.Parameters.AddWithValue("@VISITANTES", reu.visitantes);

            SQLiteParameter parameter = new SQLiteParameter();
            parameter.ParameterName = "@ALUNOS";
          //  parameter.DbType = System.Data.DbType.Structured;
            parameter.Value = dtAlunos;
            cmd.Parameters.Add(parameter);

            cmd.ExecuteNonQuery();

        }

        public DataTable anosReunioes(SQLiteConnection con)
        {


            string strSql = "select distinct Year(Data) as 'ano' from TbReuniao order by ano asc";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        /////////////////////////////////////////////// pontos //////////////////////////////////
        public DataTable listaPontos(SQLiteConnection con, Aluno a)
        {
            string strSql = " SELECT Id, Qtde as 'Pontos', Data, Obs " +
                            " from TbPontosAluno " +
                            " WHERE IdClasseMembro =  " + a.id;
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return (dt);
        }


        public void altPontosAluno(SQLiteConnection con, PontoAluno pt)
        {
            SQLiteCommand cmd = new SQLiteCommand("SPAltPontosAlunos", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", pt.id);
            cmd.Parameters.AddWithValue("@IdClasseMembros", pt.idClasseMembro);
            cmd.Parameters.AddWithValue("@Qtde", pt.qtde);
            cmd.Parameters.AddWithValue("@Data", pt.data);
            cmd.Parameters.AddWithValue("@Obs", pt.obs);

            cmd.ExecuteNonQuery();

        }

        public PontoAluno getPonto(SQLiteConnection con, int id)
        {
            PontoAluno pt = new PontoAluno();

            string strSql = " SELECT * " +
                                " FROM TbPontosAluno WHERE ID = @ID ";
            SQLiteCommand cmd = new SQLiteCommand(strSql);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Connection = con;
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            pt.id = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
            pt.obs = dt.Rows[0]["Obs"].ToString();
            pt.data = DateTime.Parse(dt.Rows[0]["Data"].ToString());
            pt.qtde = Convert.ToInt32(dt.Rows[0]["Qtde"].ToString());

            return (pt);
        }

        public void removePonto(SQLiteConnection con, int id)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM TbPontosAluno WHERE ID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.ExecuteNonQuery();

        }


        public void resetaPontos(SQLiteConnection con, int idClasse)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE PA FROM TbPontosAluno PA " +
                                                " LEFT JOIN TbClasseMembros CM " +
                                                " ON PA.IdClasseMembro = CM.Id " +
                                                " WHERE CM.IdClasse = @IdClasse", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@IdClasse", idClasse);

            cmd.ExecuteNonQuery();

        }

        public void alteraColorAluno(SQLiteConnection con, int idColor, int idAluno)
        {

            SQLiteCommand cmd = new SQLiteCommand(" UPDATE TBCLASSEMEMBROS " +
                                            " SET IDCOLOR = @IDCOLOR" +
                                               " WHERE ID = @ID ", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@IDCOLOR", idColor);
            cmd.Parameters.AddWithValue("@ID", idAluno);

            cmd.ExecuteNonQuery();

        }
    }
}
