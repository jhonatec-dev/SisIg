using System;
using System.Text;
using System.Data.SQLite;
using System.Data;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.DAO
{
    class CrudUsuario
    {

        public DataTable listaUsuarios(SQLiteConnection con)
        {


            string strSql = "SELECT [ID] " +
                    "      ,[user] as 'Usuário' " +
                    "     ,[senha]" +
                    " ,[membros] as 'Membros' " +
                    "    ,[lanc] as 'Lançamentos'" +
                    "    ,[cargos] as 'Cargos'" +
                     " ,[ebd]as 'EBD' " +
                    "   ,[vis] as 'Visitantes'" +
                    " ,[dadosIgreja]as 'Dados_Igreja'" +
                    "  ,[usuarios] as 'Usuários'" +
                    " FROM TbUsuarios";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return (dt);
        }

        internal Usuario existeUsuario(SQLiteConnection con, string user)
        {

            string strSql = " SELECT * " +
                                            " FROM TbUsuarioS WHERE [user] = @user ";
            SQLiteCommand cmd = new SQLiteCommand(strSql);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Connection = con;
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            Usuario us = new Usuario();

            if (dt.Rows.Count == 0)
            {
                us.id = 0;
            }
            else
            {

                byte[] byteSenhas = Convert.FromBase64String(dt.Rows[0]["Senha"].ToString());

                string strSenha = Encoding.ASCII.GetString(byteSenhas);

                us.senha = strSenha;
                us.id = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
            }

            return (us);


        }

        internal Usuario getUsuario(SQLiteConnection con, int id)
        {
            Usuario u = new Usuario();

            string strSql = " SELECT * " +
                                " FROM TbUsuarioS WHERE ID = @ID ";
            SQLiteCommand cmd = new SQLiteCommand(strSql);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Connection = con;
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            u.id = Convert.ToInt32(dt.Rows[0]["ID"].ToString());

            byte[] bySenha = Convert.FromBase64String(dt.Rows[0]["Senha"].ToString());
            string senha = Encoding.ASCII.GetString(bySenha);

            u.senha = senha;
            u.cargos = Convert.ToBoolean(dt.Rows[0]["Cargos"].ToString());
            u.dadosIgreja = Convert.ToBoolean(dt.Rows[0]["DadosIgreja"].ToString());
            u.ebd = Convert.ToBoolean(dt.Rows[0]["ebd"].ToString());
            u.lanc = Convert.ToBoolean(dt.Rows[0]["lanc"].ToString());
            u.membros = Convert.ToBoolean(dt.Rows[0]["membros"].ToString());
            u.usuarios = Convert.ToBoolean(dt.Rows[0]["usuarios"].ToString());
            u.vis = Convert.ToBoolean(dt.Rows[0]["vis"].ToString());
            u.user = dt.Rows[0]["user"].ToString();


            return (u);
        }

        public void alteraUsuario(SQLiteConnection con, Usuario us)
        {
            string strSql;


            if(us.id == 0)
            {
                strSql = "INSERT INTO TbUsuarios ([USER], senha, usuarios, membros, " +
                    " lanc, vis, cargos, dadosIgreja, ebd)" +
                    " VALUES(@USER, @SENHA, @USUARIOS, @MEMBROS, @LANC, @VIS, @CARGOS, @DADOSIGREJA, @EBD)";
            }
            else
            {
                strSql = "UPDATE TbUsuarios" +
                    " SET[user] = @USER, senha = @SENHA," +
                    " usuarios = @USUARIOS," +
                    " membros = @MEMBROS,  lanc = @LANC," +
                    " vis = @VIS, cargos = @CARGOS," +
                    " dadosIgreja = @DADOSIGREJA," +
                    " ebd = @EBD WHERE ID = @ID";
            }

            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@ID", us.id);
            cmd.Parameters.AddWithValue("@USER", us.user);

            byte[] bSenha = Encoding.ASCII.GetBytes(us.senha);
            string strSenha = Convert.ToBase64String(bSenha, Base64FormattingOptions.None);

            cmd.Parameters.AddWithValue("@SENHA", strSenha);
            cmd.Parameters.AddWithValue("@MEMBROS", us.membros);
            cmd.Parameters.AddWithValue("@LANC", us.lanc);
            cmd.Parameters.AddWithValue("@CARGOS", us.cargos);
            cmd.Parameters.AddWithValue("@EBD", us.ebd);
            cmd.Parameters.AddWithValue("@VIS", us.vis);
            cmd.Parameters.AddWithValue("@DADOSIGREJA", us.dadosIgreja);
            cmd.Parameters.AddWithValue("@USUARIOS", us.usuarios);

            cmd.ExecuteNonQuery();
        }

        public void removeUsuario(SQLiteConnection con, int id)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM TBUSUARIOS WHERE ID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.ExecuteNonQuery();
        }

    }
}
