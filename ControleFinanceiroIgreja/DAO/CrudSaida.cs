using System;
using System.Data;
using System.Data.SQLite;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.DAO
{
    class CrudSaida
    {
        public void altCatSaida(SQLiteConnection con, CatSaida cat)
        {
            SQLiteCommand cmd;

            if (cat.id == 0)
            {
                cmd = new SQLiteCommand("INSERT INTO TbCatSaida ([DESC])" +
                    "  VALUES(@DESC)", con);
            }
            else
            {
                cmd = new SQLiteCommand("UPDATE TbCatSaida" +
                    " SET[DESC] = @DESC" +
                    " WHERE ID = @ID", con);

            }

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", cat.id);
            cmd.Parameters.AddWithValue("@Desc", cat.desc);

            cmd.ExecuteNonQuery();

        }

        public DataTable livroCaixa(SQLiteConnection con, int ano, int mes, int dia)
        {

            string strSql = @"SELECT  Data as 'Data', Descricao as 'Referência',
                             0 as 'Entrada' , Sum(Valor) as 'Saída', 0 as 'Saldo'
                             from VWSaidas 
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



        public void removeSaida(SQLiteConnection con, int id)
        {
            SQLiteCommand cmd = new SQLiteCommand(" DELETE FROM TBSAIDA WHERE ID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.ExecuteNonQuery();

        }

        public DataTable listaCatSaida(SQLiteConnection con)
        {
            string strSql = @" SELECT  Id, [Desc] as 'Descrição'" +
                            @" from TbCatSaida";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);

        }


        public void altSaida(SQLiteConnection con, Saida sai)
        {
            SQLiteCommand cmd;

            if (sai.id == 0)
            {
                cmd = new SQLiteCommand("INSERT INTO TbSaida(IDCAT, VALOR, DATA, OBS)" +
                    " VALUES(@IDCATEGORIA, @VALOR, @DATA, @OBS)", con);
            }
            else
            {
                cmd = new SQLiteCommand("UPDATE TbSaida" +
                    "  SET IDCAT = @IDCATEGORIA," +
                    " VALOR = @VALOR," +
                    " DATA = @DATA," +
                    " OBS = @OBS " +
                    "WHERE ID = @ID", con);

            }

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", sai.id);
            cmd.Parameters.AddWithValue("@IdCategoria", sai.idCat);
            cmd.Parameters.AddWithValue("@Valor", sai.valor);
            cmd.Parameters.AddWithValue("@Data", sai.data);
            cmd.Parameters.AddWithValue("@Obs", sai.obs);


            cmd.ExecuteNonQuery();

        }


        public DataTable listaSaida(SQLiteConnection con, int ano, int mes)
        {
            string strSql = " SELECT  Id, DATA as 'Data', DESCRICAO AS 'Descrição', " +
                            " Valor as 'Valor', OBS as 'Obs'" +
                            " from VWSaidas " +
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


        public int getIdCatSaida(SQLiteConnection con, int idSaida)
        {
            string strSql = @" SELECT  IdCat " +
                            @" from TbSaida " +
                            @" where Id = " + idSaida; //adicionar where year()=@yy and month()=@mm
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);



            return (Convert.ToInt32(dt.Rows[0]["IdCat"].ToString()));

        }

        public DataTable listaSaidaGeral(SQLiteConnection con, int ano, int mes)
        {
            string strSql = " SELECT  Descricao, " +
                            " round(Sum(Valor), 2) as 'Total' " +
                            " from VWSaidas " +
                            " where CAST(STRFTIME('%Y', DATA) AS INTEGER) = @ano " +
                            " AND CAST(STRFTIME('%m', DATA) AS INTEGER) = @mes " +
                            " GROUP BY DESCRICAO"; //adicionar where year()=@yy and month()=@mm
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

        public DataTable listaSaidaGeralAno(SQLiteConnection con, int ano, int mes)
        {
            string strSql = " SELECT  Descricao, " +
                            " ROUND(Sum(Valor), 2) as 'Total' " +
                            " from VwSaidas " +
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
