using System;
using ControleFinanceiroIgreja.TAD;
using System.Data.SQLite;
using System.Data;

namespace ControleFinanceiroIgreja.DAO
{
    class CrudMembro
    {

        public DataTable niverDinamico(SQLiteConnection con, DateTime dtIni, DateTime dtFim)
        {
            string strSql = " SELECT Id, Nome, Tel1, Tel2 , " +
                     " CONVERT(NVARCHAR(2), DAY([DBO].FCDATANIVER(DTNASC)))+'/' + CONVERT(NVARCHAR(2), MONTH([DBO].FCDATANIVER(DTNASC))) AS 'Data' " +
                     " FROM TbMembros" +
                     " WHERE[DBO].FCDATANIVER(DTNASC) BETWEEN @DTINI AND @DTFIM" +
                     " AND INATIVO = 0 " +
                     " ORDER BY [DBO].FCDATANIVER(DTNASC)";

            strSql = @"select Id, NOME as 'Nome', TEL1 as 'Tel1', TEL2 as 'Tel2', 
STRFTIME('%d', DTNASC)||'/'||STRFTIME('%m', DTNASC) as 'Data',
date(STRFTIME('%Y',date('now'))||'-'||STRFTIME('%m', DTNASC) || '-' || STRFTIME('%d', DTNASC)||'') as 'DtNiver'
                            from TbMembros 
where
DtNiver between @DTINI AND @DTFIM
and inativo = 0
                            order by DtNiver";
            SQLiteCommand cmd = new SQLiteCommand(strSql);
            cmd.Parameters.AddWithValue("@DTINI", dtIni);
            cmd.Parameters.AddWithValue("@DTFIM", dtFim);
            cmd.Connection = con;
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        public void alteraMembro(SQLiteConnection con, Membro mem)
        {
            SQLiteCommand cmd;

            if (mem.id == 0)
            {
                cmd = new SQLiteCommand("INSERT INTO TbMembros (NOME, DTNASC, CPF, RG, SEXO, ENDERECO, BAIRRO, " +
                    " CIDADE, CEP, UF, TEL1, TEL2, EMAIL, DTMEMBRO, DTCASAMENTO, " +
                    " IDADMISSAO, IDSTATUS, NOMEPAI, NOMEMAE, ESTADOCIVIL, TITELEITOR, " +
                    " OBS, PROFISSAO, LOCALNASCIMENTO, PROCEDENCIA) " +
                   " VALUES(@NOME, @DTNASC, @CPF, @RG, @SEXO, @ENDERECO, @BAIRRO, " +
                  " @CIDADE, @CEP, @UF, @TEL1, @TEL2, @EMAIL, @DTMEMBRO, @DTCASAMENTO," +
                 " @IdAdmissao, @IdSituacao, @NomePai, @NomeMae, @EstadoCivil, @TitEleitor, " +
                   " @Obs, @Profissao, @LocalNascimento, @Procedencia)", con);
            }
            else
            {
                cmd = new SQLiteCommand(" UPDATE TbMembros " +
                                   " SET NOME = @NOME," +
                                    "    DTNASC = @DTNASC," +
                                     "   CPF = @CPF," +
                                      "  RG = @RG," +
                                       " SEXO = @SEXO," +
                                        " ENDERECO = @ENDERECO," +
                                "        BAIRRO = @BAIRRO," +
                                 "       CIDADE = @CIDADE," +
                                  "      TEL1 = @TEL1," +
                                   "     TEL2 = @TEL2," +
                                    "    EMAIL = @EMAIL," +
                                     "   DTMEMBRO = @DTMEMBRO," +
                                      "  CEP = @CEP," +
                                       " UF = @UF," +
                                        " DTCASAMENTO = @DTCASAMENTO," +
                                "        IDADMISSAO = @IdAdmissao," +
                                 "       IDSTATUS = @IdSituacao," +
                                  "      NOMEPAI = @NomePai," +
                                   "     NOMEMAE = @NomeMae," +
                                    "    ESTADOCIVIL = @EstadoCivil," +
                                     "   TITELEITOR = @TitEleitor," +
                                      "  OBS = @Obs," +
                                       " PROFISSAO = @Profissao," +
                                        " LOCALNASCIMENTO = @LocalNascimento," +
                                     "   PROCEDENCIA = @Procedencia" +
                                     " WHERE ID = @ID", con);
            }




            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", mem.id);
            cmd.Parameters.AddWithValue("@NOME", mem.nome);
            cmd.Parameters.AddWithValue("@DtNasc", mem.dtnasc);
            cmd.Parameters.AddWithValue("@cpf", mem.cpf);
            cmd.Parameters.AddWithValue("@rg", mem.rg);
            cmd.Parameters.AddWithValue("@sexo", mem.sexo);
            cmd.Parameters.AddWithValue("@endereco", mem.endereco);
            cmd.Parameters.AddWithValue("@bairro", mem.bairro);
            cmd.Parameters.AddWithValue("@cidade", mem.cidade);
            cmd.Parameters.AddWithValue("@cep", mem.cep);
            cmd.Parameters.AddWithValue("@uf", mem.uf);
            cmd.Parameters.AddWithValue("@tel1", mem.tel1);
            cmd.Parameters.AddWithValue("@tel2", mem.tel2);
            cmd.Parameters.AddWithValue("@nomePai", mem.nomePai);
            cmd.Parameters.AddWithValue("@nomeMae", mem.nomeMae);
            cmd.Parameters.AddWithValue("@EstadoCivil", mem.estadoCivil);
            cmd.Parameters.AddWithValue("@TitEleitor", mem.titEleitor);
            cmd.Parameters.AddWithValue("@Obs", mem.obs);
            cmd.Parameters.AddWithValue("@Profissao", mem.profissao);
            cmd.Parameters.AddWithValue("@LocalNascimento", mem.localNascimento);
            cmd.Parameters.AddWithValue("@Procedencia", mem.procedencia);

            if (mem.idAdmissao == 0)
            {
                cmd.Parameters.Add("@IDADMISSAO", DbType.Int32);
                cmd.Parameters["@IDADMISSAO"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.AddWithValue("@IDADMISSAO", mem.idAdmissao);
            }

            if (mem.idStatus == 0)
            {
                cmd.Parameters.Add("@IDSITUACAO", DbType.Int32);
                cmd.Parameters["@IDSITUACAO"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.AddWithValue("@IDSITUACAO", mem.idStatus);
            }


            if (mem.dtmembro == null)
            {
                cmd.Parameters.Add("@dtmembro", DbType.DateTime);
                cmd.Parameters["@dtmembro"].Value =
                    ((object)mem.dtmembro) ?? DBNull.Value;
            }
            else
            {
                cmd.Parameters.AddWithValue("@dtmembro", DateTime.Parse(mem.dtmembro));
            }

            if (mem.dtCasamento == null)
            {
                cmd.Parameters.Add("@dtcasamento", DbType.DateTime);
                cmd.Parameters["@dtcasamento"].Value =
                    ((object)mem.dtCasamento) ?? DBNull.Value;
            }
            else
            {
                cmd.Parameters.AddWithValue("@dtcasamento", DateTime.Parse(mem.dtCasamento));
            }

            cmd.Parameters.AddWithValue("@email", mem.email);

            cmd.ExecuteNonQuery();
        }

        public void altAdmissao(SQLiteConnection con, Admissao adm)
        {
            SQLiteCommand cmd;
            if (adm.id == 0)
            {
                cmd = new SQLiteCommand("INSERT INTO TbAdmissaoMembro([DESC]) " +
                                        " VALUES(@DESC)", con);
            }
            else
            {
                cmd = new SQLiteCommand("UPDATE TbAdmissaoMembro" +
                " SET[DESC] = @DESC" +
                " WHERE ID = @ID", con);
            }


            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", adm.id);
            cmd.Parameters.AddWithValue("@Desc", adm.desc);

            cmd.ExecuteNonQuery();

        }

        public void altStatus(SQLiteConnection con, Status st)
        {
            SQLiteCommand cmd;
            if (st.id == 0)
            {
                cmd = new SQLiteCommand("INSERT INTO TbSituacaoMembro([DESC]) " +
                                        " VALUES(@DESC)", con);
            }
            else
            {
                cmd = new SQLiteCommand("UPDATE TbSituacaoMembro" +
                " SET[DESC] = @DESC" +
                " WHERE ID = @ID", con);
            }


            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", st.id);
            cmd.Parameters.AddWithValue("@Desc", st.desc);

            cmd.ExecuteNonQuery();

        }

        public void altHistorico(SQLiteConnection con, Historico hs)
        {
            SQLiteCommand cmd;
            if (hs.id == 0)
            {
                cmd = new SQLiteCommand("INSERT INTO TbHistorico (IdMembro, Data, [Desc])" +
                                            " VALUES(@IDMEMBRO, @DATA, @DESC)", con);
            }
            else
            {
                cmd = new SQLiteCommand("UPDATE TbHistorico" +
                                " SET IdMembro = @IDMEMBRO," +
                                  "  Data = @DATA," +
                                   " [Desc] = @DESC" +
                                " WHERE Id = @ID", con);
            }


            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", hs.id);
            cmd.Parameters.AddWithValue("@Desc", hs.desc);
            cmd.Parameters.AddWithValue("@IdMembro", hs.idMembro);
            cmd.Parameters.AddWithValue("@Data", hs.data);

            cmd.ExecuteNonQuery();

        }

        public DataTable listaHistorico(SQLiteConnection con, int idMembro)
        {


            string strSql = " SELECT Id, Data, " +
                            " [Desc] as 'Descrição' " +
                            " from TbHistorico " +
                            " WHERE IdMembro = " + idMembro +
                            " ORDER BY DATA";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 120000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        public Historico getHistorico(SQLiteConnection con, int id)
        {
            Historico h = new Historico();

            string strSql = " SELECT * " +
                                " FROM TbHistorico WHERE ID = @ID ";
            SQLiteCommand cmd = new SQLiteCommand(strSql);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Connection = con;
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            h.id = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
            h.desc = dt.Rows[0]["Desc"].ToString();
            h.data = DateTime.Parse(dt.Rows[0]["Data"].ToString());
            h.idMembro = Convert.ToInt32(dt.Rows[0]["IdMembro"].ToString());

            return (h);
        }

        public void removeHistorico(SQLiteConnection con, int id)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM TbHistorico WHERE ID = " + id, con);
            cmd.CommandType = CommandType.Text;


            cmd.ExecuteNonQuery();
        }


        public DataTable listaMembros(SQLiteConnection con, string sort = "")
        {


            string strSql = " SELECT Id, Nome, DtNasc, " +
                            " Sexo, EstadoCivil, Dtmembro as 'Membro desde', " +
                            " Situacao, Inativo " +
                            " from VwMembros " +
                            sort;
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        public DataTable membrosSexos(SQLiteConnection con)
        {


            string strSql = " SELECT COUNT(ID) AS 'TOTAL', SEXO " +
                                " FROM TbMembros " +
                                " GROUP BY SEXO ";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        public Membro getMembro(SQLiteConnection con, int id)
        {
            Membro mem = new Membro();

            string strSql = " SELECT * " +
                                " FROM VwMembros WHERE ID = @ID ";
            SQLiteCommand cmd = new SQLiteCommand(strSql);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Connection = con;
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            mem.id = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
            mem.nome = dt.Rows[0]["Nome"].ToString();
            mem.dtnasc = DateTime.Parse(dt.Rows[0]["DtNasc"].ToString());
            mem.cpf = dt.Rows[0]["CPF"].ToString();
            mem.rg = dt.Rows[0]["RG"].ToString();
            mem.sexo = dt.Rows[0]["SEXO"].ToString();
            mem.dtCasamento = dt.Rows[0]["DtCasamento"].ToString();

            mem.endereco = dt.Rows[0]["Endereco"].ToString();
            mem.bairro = dt.Rows[0]["Bairro"].ToString();
            mem.cidade = dt.Rows[0]["Cidade"].ToString();
            mem.uf = dt.Rows[0]["UF"].ToString();
            mem.cep = dt.Rows[0]["CEP"].ToString();
            mem.tel1 = dt.Rows[0]["Tel1"].ToString();
            mem.tel2 = dt.Rows[0]["Tel2"].ToString();
            mem.email = dt.Rows[0]["Email"].ToString();
            mem.inativo = Convert.ToBoolean(dt.Rows[0]["Inativo"].ToString());

            mem.dtmembro = dt.Rows[0]["DtMembro"].ToString();
            mem.idAdmissao = dt.Rows[0]["IdAdm"].ToString() == "" ? 0 :
                        Convert.ToInt32(dt.Rows[0]["IdAdm"].ToString());

            mem.admissao = dt.Rows[0]["Admissao"].ToString();
            mem.status = dt.Rows[0]["Situacao"].ToString();
            mem.idStatus = dt.Rows[0]["IdSit"].ToString() == "" ? 0 :
                        Convert.ToInt32(dt.Rows[0]["IdSit"].ToString());

            mem.nomePai = dt.Rows[0]["NomePai"].ToString();
            mem.nomeMae = dt.Rows[0]["NomeMae"].ToString();
            mem.estadoCivil = dt.Rows[0]["EstadoCivil"].ToString().Trim();
            mem.titEleitor = dt.Rows[0]["TitEleitor"].ToString();
            mem.obs = dt.Rows[0]["Obs"].ToString();
            mem.profissao = dt.Rows[0]["Profissao"].ToString();
            mem.localNascimento = dt.Rows[0]["LocalNascimento"].ToString();
            mem.procedencia = dt.Rows[0]["Procedencia"].ToString();

            return (mem);
        }

        public DataTable aniversariantes(SQLiteConnection con, int mes)
        {

            string strSql = " SELECT " +
             "M.NOME, " +
             " (SELECT STRFTIME('%d', DTNASC)  FROM TbMembros M2  WHERE M.Id = M2.Id  AND STRFTIME('%m', DTNASC) = @MES  AND INATIVO = 0)  AS 'NASCIMENTO',  " +
             " (SELECT STRFTIME('%d', DTCASAMENTO) FROM TbMembros M2 WHERE M.Id = M2.Id AND STRFTIME('%m', DTCASAMENTO) = @MES AND INATIVO = 0) AS 'CASAMENTO'" +
             " FROM TbMembros M WHERE(STRFTIME('%m', DTNASC) = @MES OR STRFTIME('%m', DTCASAMENTO) = @MES) AND INATIVO = 0";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            if (mes < 10)
                cmd.Parameters.AddWithValue("@mes", "0" + mes.ToString());
            else
                cmd.Parameters.AddWithValue("@mes", mes.ToString());
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        public DataTable listaAdmissao(SQLiteConnection con)
        {
            string strSql = @" SELECT  Id, [Desc] as 'Descrição'" +
                            @" from TbAdmissaoMembro";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);

        }

        public DataTable listaStatus(SQLiteConnection con)
        {
            string strSql = @" SELECT  Id, [Desc] as 'Descrição'" +
                            @" from TbSituacaoMembro";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);

        }

        public void statusMembro(SQLiteConnection con, int id)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE TbMembros" +
                                                    " SET INATIVO = ~INATIVO " +
                                                    " WHERE ID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.ExecuteNonQuery();
        }

        public DataTable RelatorioMembros(SQLiteConnection con)
        {


            string strSql = " SELECT IFNULL(A.[DESC],'NÃO CADASTRADA') AS 'Situacao', " +
                            " COUNT(M.ID) AS 'Qtde' " +
                            " FROM TbSituacaoMembro A " +
                            "  JOIN TbMembros M " +//RIGHT JOIN --- PENSAR
                            "    ON M.IDSTATUS = A.ID " +
                            " WHERE M.INATIVO = 0 " +
                            " GROUP BY A.[DESC] " +
                            " ORDER BY A.[DESC] ";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        public DataTable RelatorioQtdeMembros(SQLiteConnection con)
        {


            string strSql = " SELECT COUNT(M.ID) AS 'TOTAL', " +
                            " (SELECT COUNT(ID) FROM TbMembros WHERE DTMEMBRO IS NOT NULL AND INATIVO = 0) AS 'MEMBROS', " +
                            " (SELECT COUNT(ID) FROM TbMembros WHERE ESTADOCIVIL = 'CASADO'  AND INATIVO = 0) AS 'CASADOS', " +
                            " (SELECT COUNT(ID) FROM TbMembros WHERE ESTADOCIVIL = 'SOLTEIRO'  AND INATIVO = 0) AS 'SOLTEIROS', " +
                            " (SELECT COUNT(ID) FROM TbMembros WHERE ESTADOCIVIL = 'DIVORCIADO'  AND INATIVO = 0) AS 'DIVORCIADOS', " +
                            " (SELECT COUNT(ID) FROM TbMembros WHERE ESTADOCIVIL = 'VIÚVO'  AND INATIVO = 0) AS 'VIUVOS', " +
                            " (SELECT COUNT(ID) FROM TbMembros WHERE ESTADOCIVIL = 'OUTRO'  AND INATIVO = 0) AS 'OUTROS', " +
                            " (SELECT COUNT(ID) FROM TbMembros WHERE INATIVO = 1) AS 'INATIVOS' " +
                            " FROM TbMembros M ";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

    }//Class

}//NameSpace
