using System;
using System.Data;
using System.Data.SQLite;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.DAO
{
    class CrudEntrada
    {

        public void altCatEntrada(SQLiteConnection con, CatEntrada cat)
        {
            SQLiteCommand cmd;

            if (cat.id == 0)
            {
                cmd = new SQLiteCommand("INSERT INTO TbCatEntrada ([DESC])" +
                    "  VALUES(@DESC)", con);
            }
            else
            {
                cmd = new SQLiteCommand("UPDATE TbCatEntrada" +
                    " SET[DESC] = @DESC" +
                    " WHERE ID = @ID", con);

            }

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", cat.id);
            cmd.Parameters.AddWithValue("@Desc", cat.desc);

            cmd.ExecuteNonQuery();

        }

        public void removeEntrada(SQLiteConnection con, int id)
        {
            SQLiteCommand cmd = new SQLiteCommand(" DELETE FROM TBENTRADA WHERE ID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.ExecuteNonQuery();

        }


        public DataTable listaCatEntrada(SQLiteConnection con)
        {
            string strSql = @" SELECT  Id, [Desc] as 'Descrição'" +
                            @" from TbCatEntrada";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);

        }

        public DataTable livroCaixa(SQLiteConnection con, int ano, int mes, int dia)
        {

            string strSql = @"SELECT  Data as 'Data', Descricao as 'Referência',
                             Sum(Valor) as 'Entrada' , 0 as 'Saída', 0 as 'Saldo'
                             from VWEntradas 
                             where CAST(STRFTIME('%Y', DATA) AS INTEGER) = @ano 
                             and CAST(STRFTIME('%m', DATA) AS INTEGER) = @mes 
                             and CAST(STRFTIME('%d', DATA) AS INTEGER) = @dia 
                             GROUP BY  DESCRICAO
                             ORDER BY DESCRICAO";

            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.Parameters.AddWithValue("@ano", ano);
            cmd.Parameters.AddWithValue("@mes", mes);
            cmd.Parameters.AddWithValue("@dia", dia);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();


                 da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);



        }


        public void altEntrada(SQLiteConnection con, Entrada ent)
        {
            SQLiteCommand cmd;

            if (ent.id == 0)
            {
                cmd = new SQLiteCommand("INSERT INTO TbEntrada (IDCAT,IDMEMBRO, VALOR, DATA, OBS)" +
                    " VALUES(@IDCATEGORIA, @IDMEMBRO, @VALOR, @DATA, @OBS)", con);
            }
            else
            {
                cmd = new SQLiteCommand("UPDATE TbEntrada" +
                    " SET IDCAT = @IDCATEGORIA, IDMEMBRO = @IDMEMBRO," +
                    " VALOR = @VALOR, DATA = @DATA, OBS = @OBS" +
                    " WHERE ID = @ID", con);

            }

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", ent.id);
            cmd.Parameters.AddWithValue("@IdCategoria", ent.idcat);
            cmd.Parameters.AddWithValue("@Valor", ent.valor);
            cmd.Parameters.AddWithValue("@Data", ent.data);
            cmd.Parameters.AddWithValue("@IdMembro", ((ent.idmembro == 0) ? System.Data.SqlTypes.SqlInt32.Null : ent.idmembro));
            cmd.Parameters.AddWithValue("@Obs", ent.obs);


            cmd.ExecuteNonQuery();

        }


        public DataTable listaEntrada(SQLiteConnection con, int ano, int mes)
        {
            string strSql = " SELECT  Id, Data as 'Data', Membro, Descricao as 'Contribuição', " +
                            " Valor as 'Valor', Obs as 'Obs'" +
                            " from VWEntradas " +
                            " where CAST(strftime('%Y',DATA) AS INTEGER) = @ano " +
                            " AND CAST(strftime('%m',DATA) AS INTEGER) = @mes " +
                            " ORDER BY DATA ";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.Parameters.AddWithValue("@ano", ano);
            cmd.Parameters.AddWithValue("@mes", mes);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);

        }


        public int getIdMembroEntrada(SQLiteConnection con, int idEntrada)
        {
            string strSql = " SELECT  IdMembro " +
                            " from TbEntrada " +
                            " where Id = " + idEntrada; //adicionar where year()=@yy and month()=@mm
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);



            return (Convert.ToInt32(dt.Rows[0]["IdMembro"].ToString()));

        }

        public int getIdCatEntrada(SQLiteConnection con, int idEntrada)
        {
            string strSql = " SELECT  IdCat " +
                            " from TbEntrada " +
                            " where Id = @IdEnt"; //adicionar where year()=@yy and month()=@mm
            SQLiteCommand cmd = new SQLiteCommand(strSql);
            cmd.Parameters.AddWithValue("@IdEnt", idEntrada);
            cmd.Connection = con;
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);



            return (Convert.ToInt32(dt.Rows[0]["IdCat"].ToString()));

        }

        public DataTable listaEntradaGeral(SQLiteConnection con, int ano, int mes)
        {
            string strSql = @" SELECT  Descricao, " +
                            @" Sum(Valor) as 'Total' " +
                            @" from VWEntradas " +
                            @" where CAST(STRFTIME('%Y', DATA) AS INTEGER) = @ano " +
                            @" AND CAST(STRFTIME('%m', DATA) AS INTEGER) = @mes " +
                            @" GROUP BY DESCRICAO" +
                            @" ORDER BY DESCRICAO"; //adicionar where year()=@yy and month()=@mm
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.Parameters.AddWithValue("@ano", ano);
            cmd.Parameters.AddWithValue("@mes", mes);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);

        }


        public DataTable listaEntradaGeralAno(SQLiteConnection con, int ano, int mes)
        {
            string strSql = " SELECT  Descricao, " +
                            " Sum(Valor) as 'Total' " +
                            " from VWEntradas " +
                            " where DATA BETWEEN @dtIni AND @dtFim " +
                            " GROUP BY DESCRICAO" +
                            " ORDER BY DESCRICAO"; //adicionar where year()=@yy and month()=@mm

            DateTime dtIni, dtFim;
            dtIni = new DateTime(ano, mes, 1);
            dtFim = dtIni.AddMonths(11);
            int dMes = DateTime.DaysInMonth(dtFim.Year, dtFim.Month);
            dtFim = dtFim.AddDays(dMes - 1);

            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.Parameters.AddWithValue("@dtIni", dtIni);
            cmd.Parameters.AddWithValue("@dtFim", dtFim);
            cmd.CommandType = CommandType.Text;
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);

        }
    }
}
