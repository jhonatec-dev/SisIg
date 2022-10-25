using System;
using System.Data;
using System.Data.SQLite;
using System.Globalization;

namespace ControleFinanceiroIgreja.DAO
{
    class CrudLancamento
    {

        public DataTable anosLanc(SQLiteConnection con)
        {


            string strSql = "SELECT * FROM " +
                         " (SELECT DISTINCT strftime('%Y', E.Data) as 'ano'" +
                         " FROM TbEntrada E " +
                         " UNION " +
                         "  SELECT DISTINCT strftime('%Y', S.Data) as 'ano' " +
                         "  FROM TbSaida S )" +
                         " ORDER BY 'ano'";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        public DataTable dizimistas(SQLiteConnection con, int id, int ano, int mes)
        {


            string strSql = " SELECT DISTINCT M.NOME " +
                            " FROM TbEntrada E " +
                            " LEFT JOIN TbMembros M " +
                            " ON E.IDMEMBRO = M.ID " +
                            " WHERE " +
                            " E.IDCAT = @idCat" +
                            " AND CAST(STRFTIME('%Y', E.DATA) AS INTEGER) = @ano" +
                            " AND CAST(STRFTIME('%m',E.DATA) AS INTEGER) = @mes" +
                            " ORDER BY M.NOME";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.Parameters.AddWithValue("@idCat", id);
            cmd.Parameters.AddWithValue("@ano", ano);
            cmd.Parameters.AddWithValue("@mes", mes);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        /*
         SELECT DISTINCT E.IDMEMBRO, M.NOME
FROM TbEntrada E
LEFT JOIN TbMembros M
ON E.IDMEMBRO = M.ID
WHERE 
E.IDCAT = 1
AND YEAR(E.DATA) = 2016
AND MONTH(E.DATA) = 1
ORDER BY M.NOME
             */

        public decimal saldoAnterior(SQLiteConnection con, int ano, int mes)
        {

            decimal total, SaldoInicial, Entradas, Saidas = 0;
            string StrSaldoInicial, StrEntradas, StrSaidas;

            /*    " (select ifnull(sum(VALOR), 0) as 'Entradas' from VWEntradas" +
                                "  where (CAST(strftime('%Y', Data) AS INTEGER) < @ano)" +
                                "  or(CAST(strftime('%Y', Data) AS INTEGER) = @ano" +
                                "    and CAST(strftime('%m', Data) AS INTEGER) < @mes)) - " +
                                " (select ifnull(sum(VALOR), 0) as 'Entradas' from VwSaidas" +
                                "  where (CAST(strftime('%Y', Data) AS INTEGER) < @ano)" +
                                " or(CAST(strftime('%Y', Data) AS INTEGER) = @ano" +
                                " and CAST(strftime('%m', Data) AS INTEGER) < @mes)) AS 'SaldoAnterior'";
                               */

            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = "SELECT ifnull (SALDOINICIAL, 0) from TbIgreja ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            StrSaldoInicial = cmd.ExecuteScalar().ToString();

            cmd = new SQLiteCommand();
            cmd.CommandText = " select ifnull(sum(VALOR), 0) as 'Entradas' from VWEntradas" +
                                "  where (CAST(strftime('%Y', Data) AS INTEGER) < @ano)" +
                                "  or (CAST(strftime('%Y', Data) AS INTEGER) = @ano" +
                                "    and CAST(strftime('%m', Data) AS INTEGER) < @mes) ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@ano", ano);
            cmd.Parameters.AddWithValue("@mes", mes);
            StrEntradas = cmd.ExecuteScalar().ToString();

            cmd = new SQLiteCommand();
            cmd.CommandText = " select ifnull(sum(VALOR), 0) as 'Saidas' from VWSaidas" +
                                "  where (CAST(strftime('%Y', Data) AS INTEGER) < @ano)" +
                                "  or (CAST(strftime('%Y', Data) AS INTEGER) = @ano" +
                                "    and CAST(strftime('%m', Data) AS INTEGER) < @mes) ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@ano", ano);
            cmd.Parameters.AddWithValue("@mes", mes);
            StrSaidas = cmd.ExecuteScalar().ToString();





            try
            {


                SaldoInicial = Decimal.Parse(StrSaldoInicial, NumberStyles.Currency);
                Entradas = Decimal.Parse(StrEntradas, NumberStyles.Currency);
                Saidas = Decimal.Parse(StrSaidas, NumberStyles.Currency);

                total = SaldoInicial + Entradas - Saidas;
            }
            catch (Exception)
            {
                total = 0;
                // throw;
            }

            return (total);


        }

        public decimal totalEntrada(SQLiteConnection con, int ano, int mes)
        {

            decimal total = 0;

            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = "SELECT IFNULL(SUM(VALOR), 0) " +
                                    " FROM VWEntradas " +
                                    " WHERE CAST(strftime('%Y', DATA) AS INTEGER) = @ano " +
                                    " AND CAST(strftime('%m', DATA) AS INTEGER) = @mes";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ano", ano);
            cmd.Parameters.AddWithValue("@mes", mes);
            cmd.Connection = con;
            string strTotal = cmd.ExecuteScalar().ToString();

            try
            {
                total = Decimal.Parse(strTotal, NumberStyles.Currency);
            }
            catch (Exception)
            {
                total = 0;
                // throw;
            }

            return (total);


        }

        public decimal totalEntradaAnual(SQLiteConnection con, int ano)
        {

            decimal total = 0;
            string strSql;

            strSql = "SELECT IFNULL(SUM(VALOR), 0)" +
                                " FROM VWEntradas" +
                                " WHERE CAST(STRFTIME('%Y', DATA) AS INTEGER) = @ano";

            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SQLiteParameter("@ano", ano));

            string strTotal = cmd.ExecuteScalar().ToString();

            try
            {
                total = Decimal.Parse(strTotal, NumberStyles.Currency);
            }
            catch (Exception)
            {
                total = 0;
                // throw;
            }

            return (total);


        }

        public decimal totalEntradasRelAnual(SQLiteConnection con, int ano, int mes)
        {
            //gráfico de balancete...

            decimal total = 0;
            string strSql;


            strSql = "SELECT IFNULL(SUM(VALOR), 0) " +
                " FROM VWEntradas" +
                " WHERE DATA BETWEEN @dtIni AND @dtFim ";




            DateTime dtIni, dtFim;
            dtIni = new DateTime(ano, mes, 1);
            dtFim = dtIni.AddMonths(11);
            int dMes = DateTime.DaysInMonth(dtFim.Year, dtFim.Month);
            dtFim = dtFim.AddDays(dMes - 1);

            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@dtIni", dtIni);
            cmd.Parameters.AddWithValue("@dtFim", dtFim);

            string strTotal = cmd.ExecuteScalar().ToString();

            try
            {
                total = Decimal.Parse(strTotal, NumberStyles.Currency);
            }
            catch (Exception)
            {
                total = 0;
                // throw;
            }

            return (total);


        }

        public decimal totalSaidasRelAnual(SQLiteConnection con, int ano, int mes)
        {

            decimal total = 0;
            string strSql;


            strSql = "SELECT IFNULL(SUM(VALOR), 0) " +
                " FROM VwSaidas" +
                " WHERE DATA BETWEEN @dtIni AND @dtFim ";

            DateTime dtIni, dtFim;
            dtIni = new DateTime(ano, mes, 1);
            dtFim = dtIni.AddMonths(11);
            int dMes = DateTime.DaysInMonth(dtFim.Year, dtFim.Month);
            dtFim = dtFim.AddDays(dMes - 1);

            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@dtIni", dtIni);
            cmd.Parameters.AddWithValue("@dtFim", dtFim);

            string strTotal = cmd.ExecuteScalar().ToString();

            try
            {
                total = Decimal.Parse(strTotal, NumberStyles.Currency);
            }
            catch (Exception)
            {
                total = 0;
                // throw;
            }

            return (total);


        }

        public DataTable balancete(SQLiteConnection con, int ano)
        {

            /*
                             TABLE
                (
	                MES NVARCHAR(15),
	                ENTRADAS DECIMAL(18,2),
	                SAIDAS DECIMAL(18,2),
	                SALDOMES DECIMAL (18,2)
                )
                             */
            DataTable dt = new DataTable();
            dt.Columns.Add("Mes", typeof(string));
            dt.Columns.Add("Entradas", typeof(decimal));
            dt.Columns.Add("Saidas", typeof(decimal));
            dt.Columns.Add("SaldoMes", typeof(decimal));

            //Decimal Entradas, Saidas, SaldoMes;



            string strSql = @" SELECT  Mes, Entradas, Saidas, SaldoMes " +
                            @" from DBO.FCBALANCETE(" + ano + ")";





            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();


            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);

        }

        public DataTable relAnual(SQLiteConnection con, int ano, int mes)
        {
            //alterar funções

            //loop

            int cont = 0;
            Decimal Entrada, Saida, Saldo, Geral, SaldoAnt;

            /*
              string strSql = @" SELECT  [Mes/Ano] as 'Mes', Entradas, Saidas, SaldoMes, SaldoGeral " +
                            @" from DBO.FCRELANUAL(@ANO, @MES)";
             */

            DataTable dt = new DataTable();

            dt.Columns.Add("Mes");
            dt.Columns.Add("Entradas", typeof(decimal));
            dt.Columns.Add("Saidas", typeof(decimal));
            dt.Columns.Add("SaldoMes", typeof(decimal));
            dt.Columns.Add("SaldoGeral", typeof(decimal));

            while (cont < 12)
            {
                if (mes > 12)
                {
                    mes = 1;
                    ano++;
                }

                Entrada = totalEntrada(con, ano, mes);
                Saida = totalSaida(con, ano, mes);
                Saldo = Entrada - Saida;
                SaldoAnt = saldoAnterior(con, ano, mes);

                Geral = Saldo + SaldoAnt;


                //manipular uma tabela...

                //Funcoes.nomeMes(mes) + "/" + ano;

                DataRow linha = dt.NewRow();
                linha["Mes"] = Funcoes.nomeMes(mes) + "/" + ano;
                linha["Entradas"] = Entrada;
                linha["Saidas"] = Saida;
                linha["SaldoMes"] = Saldo;
                linha["SaldoGeral"] = Geral;
                dt.Rows.Add(linha);


                cont++;
                mes++;


            }

            return (dt);

        }

        public DataTable membrosEntrada(SQLiteConnection con, int ano, int idCat)
        {
            string strSql = "SELECT M.Nome as 'Membro', " +
              " (SELECT ROUND(SUM(E.VALOR), 2) FROM TbEntrada E " +
              "  WHERE M.ID = E.IDMEMBRO AND E.IDCAT = @IdCat " +
              "    AND CAST (STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO " +
              "    AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 1) AS 'Jan',"+
              " (SELECT ROUND(SUM(E.VALOR), 2) FROM TbEntrada E " +
              "  WHERE M.ID = E.IDMEMBRO AND E.IDCAT = @IdCat " +
              "    AND CAST (STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO " +
              "    AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 2) AS 'Fev'," +
              " (SELECT ROUND(SUM(E.VALOR), 2) FROM TbEntrada E " +
              "  WHERE M.ID = E.IDMEMBRO AND E.IDCAT = @IdCat " +
              "    AND CAST (STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO " +
              "    AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 3) AS 'Mar'," +
              " (SELECT ROUND(SUM(E.VALOR), 2) FROM TbEntrada E " +
              "  WHERE M.ID = E.IDMEMBRO AND E.IDCAT = @IdCat " +
              "    AND CAST (STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO " +
              "    AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 4) AS 'Abr'," +
              " (SELECT ROUND(SUM(E.VALOR), 2) FROM TbEntrada E " +
              "  WHERE M.ID = E.IDMEMBRO AND E.IDCAT = @IdCat " +
              "    AND CAST (STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO " +
              "    AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 5) AS 'Mai'," +
              " (SELECT ROUND(SUM(E.VALOR), 2) FROM TbEntrada E " +
              "  WHERE M.ID = E.IDMEMBRO AND E.IDCAT = @IdCat " +
              "    AND CAST (STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO " +
              "    AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 6) AS 'Jun'," +
              " (SELECT ROUND(SUM(E.VALOR), 2) FROM TbEntrada E " +
              "  WHERE M.ID = E.IDMEMBRO AND E.IDCAT = @IdCat " +
              "    AND CAST (STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO " +
              "    AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 7) AS 'Jul'," +
              " (SELECT ROUND(SUM(E.VALOR), 2) FROM TbEntrada E " +
              "  WHERE M.ID = E.IDMEMBRO AND E.IDCAT = @IdCat " +
              "    AND CAST (STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO " +
              "    AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 8) AS 'Ago'," +
              " (SELECT ROUND(SUM(E.VALOR), 2) FROM TbEntrada E " +
              "  WHERE M.ID = E.IDMEMBRO AND E.IDCAT = @IdCat " +
              "    AND CAST (STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO " +
              "    AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 9) AS 'Set'," +
              " (SELECT ROUND(SUM(E.VALOR), 2) FROM TbEntrada E " +
              "  WHERE M.ID = E.IDMEMBRO AND E.IDCAT = @IdCat " +
              "    AND CAST (STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO " +
              "    AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 10) AS 'Out'," +
              " (SELECT ROUND(SUM(E.VALOR), 2) FROM TbEntrada E " +
              "  WHERE M.ID = E.IDMEMBRO AND E.IDCAT = @IdCat " +
              "    AND CAST (STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO " +
              "    AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 11) AS 'Nov'," +
              " (SELECT ROUND(SUM(E.VALOR), 2) FROM TbEntrada E " +
              "  WHERE M.ID = E.IDMEMBRO AND E.IDCAT = @IdCat " +
              "    AND CAST (STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO " +
              "    AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 12) AS 'Dez'," +
              " (SELECT ROUND(SUM(E.VALOR), 2) FROM TbEntrada E " +
              " WHERE M.ID = E.IDMEMBRO AND E.IDCAT = @IdCat" +
              " AND CAST(STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO) AS 'Total'" +
           " FROM TbMembros M ORDER BY M.NOME ";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.Parameters.AddWithValue("@ANO", ano);
            cmd.Parameters.AddWithValue("@IdCat", idCat);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);

        }

        public DataTable entradasMembro(SQLiteConnection con, int ano, int idMembro)
        {
            string strSql = @"SELECT
                      CE.[DESC] as 'CATEGORIA' ,
                      (SELECT
                        SUM(VALOR)
                      FROM TbEntrada E
                      WHERE E.IDCAT = CE.ID
                      AND E.IDMEMBRO = @IDMEMBRO
                      AND CAST(STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO
                      AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 1) AS 'Jan',
                      (SELECT
                        SUM(VALOR)
                      FROM TbEntrada E
                      WHERE E.IDCAT = CE.ID
                      AND E.IDMEMBRO = @IDMEMBRO
                      AND CAST(STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO
                      AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 2) AS 'Fev',
                      (SELECT
                        SUM(VALOR)
                      FROM TbEntrada E
                      WHERE E.IDCAT = CE.ID
                      AND E.IDMEMBRO = @IDMEMBRO
                      AND CAST(STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO
                      AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 3) AS 'Mar',
                      (SELECT
                        SUM(VALOR)
                      FROM TbEntrada E
                      WHERE E.IDCAT = CE.ID
                      AND E.IDMEMBRO = @IDMEMBRO
                      AND CAST(STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO
                      AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 4) AS 'Abr',
                      (SELECT
                        SUM(VALOR)
                      FROM TbEntrada E
                      WHERE E.IDCAT = CE.ID
                      AND E.IDMEMBRO = @IDMEMBRO
                      AND CAST(STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO
                      AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 5) AS 'Mai',
                      (SELECT
                        SUM(VALOR)
                      FROM TbEntrada E
                      WHERE E.IDCAT = CE.ID
                      AND E.IDMEMBRO = @IDMEMBRO
                      AND CAST(STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO
                      AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 6) AS 'Jun',
                      (SELECT
                        SUM(VALOR)
                      FROM TbEntrada E
                      WHERE E.IDCAT = CE.ID
                      AND E.IDMEMBRO = @IDMEMBRO
                      AND CAST(STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO
                      AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 7) AS 'Jul',
                      (SELECT
                        SUM(VALOR)
                      FROM TbEntrada E
                      WHERE E.IDCAT = CE.ID
                      AND E.IDMEMBRO = @IDMEMBRO
                      AND CAST(STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO
                      AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 8) AS 'Ago',
                      (SELECT
                        SUM(VALOR)
                      FROM TbEntrada E
                      WHERE E.IDCAT = CE.ID
                      AND E.IDMEMBRO = @IDMEMBRO
                      AND CAST(STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO
                      AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 9) AS 'Set',
                      (SELECT
                        SUM(VALOR)
                      FROM TbEntrada E
                      WHERE E.IDCAT = CE.ID
                      AND E.IDMEMBRO = @IDMEMBRO
                      AND CAST(STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO
                      AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 10) AS 'Out',
                      (SELECT
                        SUM(VALOR)
                      FROM TbEntrada E
                      WHERE E.IDCAT = CE.ID
                      AND E.IDMEMBRO = @IDMEMBRO
                      AND CAST(STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO
                      AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 11) AS 'Nov',
                      (SELECT
                        SUM(VALOR)
                      FROM TbEntrada E
                      WHERE E.IDCAT = CE.ID
                      AND E.IDMEMBRO = @IDMEMBRO
                      AND CAST(STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO
                      AND CAST(STRFTIME('%m', E.DATA) AS INTEGER) = 12) AS 'Dez',
                      (SELECT
                        SUM(VALOR)
                      FROM TbEntrada E
                      WHERE E.IDCAT = CE.ID
                      AND E.IDMEMBRO = @IDMEMBRO
                      AND CAST(STRFTIME('%Y', E.DATA) AS INTEGER) = @ANO) as 'Total'
                    FROM TbCatEntrada CE ORDER BY CATEGORIA";

            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.Parameters.AddWithValue("@ANO", ano);
            cmd.Parameters.AddWithValue("@IDMEMBRO", idMembro);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);

        }

        public decimal totalSaida(SQLiteConnection con, int ano, int mes)
        {

            decimal total = 0;

            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = "SELECT IFNULL(SUM(VALOR), 0)" +
                              " FROM VWSaidas " +
                              " WHERE CAST(strftime('%Y', DATA) AS INTEGER) = @ano" +
                              " AND CAST(strftime('%m', DATA) AS INTEGER) = @mes";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ano", ano.ToString());
            cmd.Parameters.AddWithValue("@mes", mes.ToString());
            cmd.Connection = con;
            string strTotal = cmd.ExecuteScalar().ToString();

            try
            {
                total = Decimal.Parse(strTotal, NumberStyles.Currency);
            }
            catch (Exception)
            {
                total = 0;
                // throw;
            }

            return (total);


        }

        public decimal totalSaidaAnual(SQLiteConnection con, int ano)
        {

            decimal total = 0;
            string strSql;


            strSql = "SELECT IFNULL(SUM(VALOR), 0)" +
                                " FROM VWSaidas" +
                                " WHERE CAST(STRFTIME('%Y', DATA) AS INTEGER) = @ano";

            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SQLiteParameter("@ano", ano));
            string strTotal = cmd.ExecuteScalar().ToString();

            try
            {
                total = Decimal.Parse(strTotal, NumberStyles.Currency);
            }
            catch (Exception)
            {
                total = 0;
                // throw;
            }

            return (total);


        }

    }
}
