using System;
using System.Data;
using System.Data.SQLite;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.DAO
{
    class CrudVisitantes
    {
        public DataTable listaVisitantes(SQLiteConnection con)
        {


            string strSql = " SELECT Id, Nome AS 'Nome', DtNasc as 'DtNasc', Visitado as 'Última', Recebidas, Realizadas " +
                            " from VWVisitantes" +
                            " ORDER BY NOME";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        public DataTable aniversariantes(SQLiteConnection con, int mes)
        {
            string strSql = @"SELECT  		
                                 V.NOME, 		
                                 V.TEL1 + '/' + V.TEL2,
                                 (SELECT STRFTIME('%d',DTNASC) FROM TbVisitantes V2 
                                        WHERE V.ID = V2.ID 
                                        AND CAST(STRFTIME('%m', DTNASC) AS INTEGER)= @MES) 
                                    AS 'NASCIMENTO', 		
                                 (SELECT STRFTIME('%d', DTCASAMENTO) FROM TbVisitantes V2 
                                        WHERE V.NOME = V2.NOME 
                                        AND CAST(STRFTIME('%m', DTCASAMENTO) AS INTEGER) = @MES) 
                                    AS 'CASAMENTO' 	
                                 FROM TbVisitantes V 	
                                 WHERE  		
                                 (
                                    CAST(STRFTIME('%m', DTNASC) AS INTGER) = @MES 		
                                    OR CAST(STRFTIME('%m', DTCASAMENTO) AS INTEGER) = @MES
                                  )";

            /*string strSql2 = " SELECT Nome, Telefones, Nascimento, Casamento " +
                                " FROM FCANIVERSARIANTESVIS(@mes) " +
                                " ORDER BY NASCIMENTO, CASAMENTO";*/
            SQLiteCommand cmd = new SQLiteCommand(strSql);
            cmd.Parameters.AddWithValue("@MES", mes);
            cmd.Connection = con;
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        public DataTable niverDinamico(SQLiteConnection con, DateTime dtIni, DateTime dtFim)
        {
            string strSql = " SELECT Id, Nome, Tel1, Tel2 , " +
                     " CONVERT(NVARCHAR(2), DAY([DBO].FCDATANIVER(DTNASC)))+'/' + CONVERT(NVARCHAR(2), MONTH([DBO].FCDATANIVER(DTNASC))) AS 'Data' " +
                     " FROM TbVisitantes" +
                     " WHERE[DBO].FCDATANIVER(DTNASC) BETWEEN @DTINI AND @DTFIM" +
                     " ORDER BY [DBO].FCDATANIVER(DTNASC)";

            strSql = @"select Id, Nome as 'Nome', Tel1 as 'Tel1', Tel2 as 'Tel2', 
STRFTIME('%d', DTNASC)||'/'||STRFTIME('%m', DTNASC) as 'Data',
date(STRFTIME('%Y',date('now'))||'-'||STRFTIME('%m', DTNASC) || '-' || STRFTIME('%d', DTNASC)||'') as 'DtNiver'
                            from TbVisitantes 
where
DtNiver between @DTINI AND @DTFIM
                            order by DtNiver";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.Parameters.AddWithValue("@DTINI", dtIni);
            cmd.Parameters.AddWithValue("@DTFIM", dtFim);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        internal Visitantes getVisitante(SQLiteConnection con, int id)
        {
            Visitantes vi = new Visitantes();

            string strSql = " SELECT * " +
                                " FROM TbVisitantes WHERE ID = @ID ";
            SQLiteCommand cmd = new SQLiteCommand(strSql);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Connection = con;
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            vi.id = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
            vi.nome = dt.Rows[0]["Nome"].ToString();
            vi.dtnasc = DateTime.Parse(dt.Rows[0]["DtNasc"].ToString());
            vi.sexo = dt.Rows[0]["SEXO"].ToString();
            vi.dtCasamento = dt.Rows[0]["DtCasamento"].ToString();
            vi.estadoCivil = dt.Rows[0]["Estado_Civil"].ToString().Trim();
            vi.endereco = dt.Rows[0]["Endereco"].ToString();
            vi.bairro = dt.Rows[0]["Bairro"].ToString();
            vi.cidade = dt.Rows[0]["Cidade"].ToString();
            vi.uf = dt.Rows[0]["UF"].ToString();
            vi.cep = dt.Rows[0]["CEP"].ToString();
            vi.tel1 = dt.Rows[0]["Tel1"].ToString();
            vi.tel2 = dt.Rows[0]["Tel2"].ToString();
            vi.email = dt.Rows[0]["Email"].ToString();
            vi.profissao = dt.Rows[0]["Profissao"].ToString();
            vi.localNascimento = dt.Rows[0]["Local_Nascimento"].ToString();

            vi.obs = dt.Rows[0]["Obs"].ToString();

            return (vi);
        }

        public void alteraVisitante(SQLiteConnection con, Visitantes vi)
        {

            string strSql;

            if (vi.id == 0)
            {
                strSql = @"INSERT INTO TbVisitantes (NOME, DTNASC, SEXO, ENDERECO, BAIRRO, CIDADE, CEP, UF, 
                            TEL1, TEL2, EMAIL, DTCASAMENTO, ESTADO_CIVIL, 
                            OBS, PROFISSAO, LOCAL_NASCIMENTO)
      VALUES (@NOME, @DTNASC, @SEXO, @ENDERECO, @BAIRRO, @CIDADE, @CEP, @UF, 
            @TEL1, @TEL2, @EMAIL, @DTCASAMENTO, @Estado_Civil, 
            @Obs, @Profissao, @Local_Nascimento)";
            }
            else
            {
                strSql = @"UPDATE TbVisitantes
    SET NOME = @NOME,
        DTNASC = @DTNASC,
        SEXO = @SEXO,
        ENDERECO = @ENDERECO,
        BAIRRO = @BAIRRO,
        CIDADE = @CIDADE,
        TEL1 = @TEL1,
        TEL2 = @TEL2,
        EMAIL = @EMAIL,
        CEP = @CEP,
        UF = @UF,
        DTCASAMENTO = @DTCASAMENTO,
        ESTADO_CIVIL = @EstadoCivil,
        OBS = @Obs,
        PROFISSAO = @Profissao,
        LOCAL_NASCIMENTO = @LocalNascimento
    WHERE ID = @ID";
            }


            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", vi.id);
            cmd.Parameters.AddWithValue("@NOME", vi.nome);
            cmd.Parameters.AddWithValue("@DTNASC", vi.dtnasc);
            cmd.Parameters.AddWithValue("@SEXO", vi.sexo);
            cmd.Parameters.AddWithValue("@ENDERECO", vi.endereco);
            cmd.Parameters.AddWithValue("@BAIRRO", vi.bairro);
            cmd.Parameters.AddWithValue("@CIDADE", vi.cidade);
            cmd.Parameters.AddWithValue("@CEP", vi.cep);
            cmd.Parameters.AddWithValue("@UF", vi.uf);
            cmd.Parameters.AddWithValue("@TEL1", vi.tel1);
            cmd.Parameters.AddWithValue("@TEL2", vi.tel2);
            cmd.Parameters.AddWithValue("@ESTADO_CIVIL", vi.estadoCivil);
            cmd.Parameters.AddWithValue("@OBS", vi.obs);
            cmd.Parameters.AddWithValue("@LOCAL_NASCIMENTO", vi.localNascimento);
            cmd.Parameters.AddWithValue("@PROFISSAO", vi.profissao);

            if (vi.dtCasamento == null)
            {
                cmd.Parameters.Add("@DTCASAMENTO", DbType.DateTime);
                cmd.Parameters["@DTCASAMENTO"].Value =
                    ((object)vi.dtCasamento) ?? DBNull.Value;
            }
            else
            {
                cmd.Parameters.AddWithValue("@DTCASAMENTO", DateTime.Parse(vi.dtCasamento));
            }

            cmd.Parameters.AddWithValue("@EMAIL", vi.email);

            cmd.ExecuteNonQuery();
        }

        public void removeVisitante(SQLiteConnection con, int id)

        {
            string strSql = @"DELETE FROM TbVisitas
		WHERE IDVISITANTE = @ID;

	DELETE FROM TbVisitantes
		WHERE ID = @ID";

            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.ExecuteNonQuery();
        }

        public DataTable listaVisitas(SQLiteConnection con, int idVisitante)
        {


            string strSql = " SELECT Id, Data, Tipo, Obs " +
                            " from TbVisitas WHERE IDVISITANTE = " + idVisitante +
                            " ORDER BY DATA";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        public void alteraVisita(SQLiteConnection con, Visitas vi)
        {

            string strSql;

            if (vi.id == 0)
            {
                strSql = @" INSERT INTO TbVisitas (IDVISITANTE, DATA, TIPO, OBS)
                             VALUES (@IDVISITANTE, @DATA, @TIPO, @OBS)";
            }
            else
            {
                strSql = @"UPDATE TbVisitas
                            SET IDVISITANTE = @IDVISITANTE,
                                DATA = @DATA,
                                TIPO = @TIPO,
                                OBS = @OBS
                            WHERE ID = @ID";
            }


            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", vi.id);
            cmd.Parameters.AddWithValue("@DATA", vi.data);
            cmd.Parameters.AddWithValue("@OBS", vi.obs);
            cmd.Parameters.AddWithValue("@TIPO", vi.tipo);
            cmd.Parameters.AddWithValue("@IDVISITANTE", vi.idVisitante);

            cmd.ExecuteNonQuery();
        }

        public void removeVisita(SQLiteConnection con, int id)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM TBVISITAS WHERE ID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.ExecuteNonQuery();
        }


    }
}
