using System;
using ControleFinanceiroIgreja.TAD;
using System.Data.SQLite;
using System.Data;

namespace ControleFinanceiroIgreja.DAO
{
    class CrudCargos
    {


        public DataTable listaCargosOcupados(SQLiteConnection con, int ano = 0)
        {


            string strSql = " SELECT Id, Descricao, Membro, DtInicio as 'Inicio', DtFim as 'Fim' " +

                            " from VwCargosOcupados" +
                              (ano > 0 ? " WHERE @ANO BETWEEN CAST(STRFTIME('%Y', dtINICIO) AS INTEGER) AND CAST(STRFTIME('%Y', DTFIM) AS INTEGER)" : " ");
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.Parameters.AddWithValue("@ANO", ano);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        internal CargoMembro getCargoOcupado(SQLiteConnection con, int id)
        {
            CargoMembro co = new CargoMembro();

            string strSql = " SELECT * " +
                                " FROM TbCargoMembro WHERE ID = @ID ";
            SQLiteCommand cmd = new SQLiteCommand(strSql);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Connection = con;
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            co.id = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
            //co.descCargo = dt.Rows[0]["Descricao"].ToString();
            co.dtInicio = DateTime.Parse(dt.Rows[0]["DtInicio"].ToString());
            co.dtFim = DateTime.Parse(dt.Rows[0]["DtFim"].ToString());
            co.idMembro = Convert.ToInt32(dt.Rows[0]["IDMembro"].ToString());
            co.idCargo = Convert.ToInt32(dt.Rows[0]["IdCargo"].ToString());


            return (co);
        }

        public void alteraCargoOcupado(SQLiteConnection con, CargoMembro co)
        {
            string strSql;

            if(co.id == 0)
            {
                strSql = @"INSERT INTO TbCargoMembro (IdCargo, IdMembro, DtInicio, DtFim)
                                VALUES (@IDCARGO, @IDMEMBRO, @DTINICIO, @DTFIM)";
            }
            else
            {
                strSql = @"UPDATE TbCargoMembro
                            SET IdCargo = @IDCARGO,
                                IdMembro = @IDMEMBRO,
                                DtInicio = @DTINICIO,
                                DtFim = @DTFIM
                            WHERE ID = @ID";
            }


            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", co.id);
            cmd.Parameters.AddWithValue("@IDMEMBRO", co.idMembro);
            cmd.Parameters.AddWithValue("@IDCARGO", co.idCargo);
            cmd.Parameters.AddWithValue("@DTINICIO", co.dtInicio);
            cmd.Parameters.AddWithValue("@DTFIM", co.dtFim);


            cmd.ExecuteNonQuery();
        }

        public void removeCargo(SQLiteConnection con, int id)
        {

            string strSql = @"DELETE FROM TbCargoMembro 		
                                WHERE IdCargo = @ID;  	
                                DELETE FROM TbCargo 		
                                WHERE ID = @ID ";

            SQLiteCommand cmd = new SQLiteCommand(strSql, con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.ExecuteNonQuery();
        }

        public DataTable listaCargos(SQLiteConnection con)
        {


            string strSql = " SELECT Id, [Desc] as 'Descricao'" +
                            " from TbCargo";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        public void alteraCargo(SQLiteConnection con, Cargo ca)
        {
            string strSql;

            if(ca.id ==0 )
            {
                strSql = @"INSERT INTO TbCargo ([Desc])
                                VALUES (@DESC)";
            }
            else
            {
                strSql = @" UPDATE TbCargo
                            SET [Desc] = @DESC
                            WHERE ID = @ID";
            }


            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", ca.id);
            cmd.Parameters.AddWithValue("@DESC", ca.desc);

            cmd.ExecuteNonQuery();
        }

        public void removeCargoOcupado(SQLiteConnection con, int id)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM TBCargoMembro WHERE ID = " + id, con);
            cmd.CommandType = CommandType.Text;


            cmd.ExecuteNonQuery();
        }


    }
}
