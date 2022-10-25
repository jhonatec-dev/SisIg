using System;
using System.Data;
using System.Data.SQLite;

namespace ControleFinanceiroIgreja.DAO
{
    public class CrudIgreja
    {



        public TAD.Igreja lerIgreja(SQLiteConnection con)
        {

            TAD.Igreja ig = new TAD.Igreja();

            string strSql = " SELECT Nome, Endereco, Bairro, Cidade, " +
                            " Tel1, Tel2, UF, Email, CEP, CNPJ, Sede, SaldoInicial, " +
                            " Tit1, Assinatura1, Tit2, Assinatura2 " +
                            " FROM TbIgreja";
            SQLiteCommand cmd = new SQLiteCommand(strSql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();



            cmd.CommandTimeout = 12000000;

            da.SelectCommand = cmd;

            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return (null);
            }


            ig.nome = dt.Rows[0]["Nome"].ToString();
            ig.tel1 = dt.Rows[0]["Tel1"].ToString();
            ig.tel2 = dt.Rows[0]["Tel2"].ToString();
            ig.endereco = dt.Rows[0]["Endereco"].ToString();
            ig.bairro = dt.Rows[0]["Bairro"].ToString();
            ig.cidade = dt.Rows[0]["Cidade"].ToString();
            ig.uf = dt.Rows[0]["UF"].ToString();
            ig.email = dt.Rows[0]["Email"].ToString();
            ig.cep = dt.Rows[0]["CEP"].ToString();
            ig.cnpj = dt.Rows[0]["CNPJ"].ToString();
            ig.sede = dt.Rows[0]["Sede"].ToString();
            string saldo = dt.Rows[0]["SaldoInicial"].ToString();
            ig.tit1 = dt.Rows[0]["Tit1"].ToString();
            ig.tit2 = dt.Rows[0]["Tit2"].ToString();
            ig.assinatura1 = dt.Rows[0]["Assinatura1"].ToString();
            ig.assinatura2 = dt.Rows[0]["Assinatura2"].ToString();

            if (saldo.Trim().Length == 0)
            {
                ig.saldoInicial = 0;
            }
            else
            {
                ig.saldoInicial = Decimal.Parse(saldo);
            }

            return ig;

        }

        public void altIgreja(SQLiteConnection con, TAD.Igreja ig)
        {


            SQLiteCommand cmd = new SQLiteCommand("UPDATE TbIgreja SET" +
                                                    " NOME = @NOME," +
                                                    " CNPJ = @CNPJ," +
                                                    " ENDERECO = @ENDERECO," +
                                                    " BAIRRO = @BAIRRO," +
                                                    " CIDADE = @CIDADE," +
                                                    " UF = @UF," +
                                                    " CEP = @CEP," +
                                                    " EMAIL = @EMAIL," +
                                                    " TEL1 = @TEL1," +
                                                    " TEL2 = @TEL2," +
                                                    " SEDE = @SEDE," +
                                                    " SALDOINICIAL = @SALDO," +
                                                    " TIT1 = @TIT1," +
                                                    " TIT2 = @TIT2," +
                                                    " ASSINATURA1 = @ASSINATURA1," +
                                                    " ASSINATURA2 = @ASSINATURA2", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Nome", ig.nome);
            cmd.Parameters.AddWithValue("@CNPJ", ig.cnpj);
            cmd.Parameters.AddWithValue("@Endereco", ig.endereco);
            cmd.Parameters.AddWithValue("@bairro", ig.bairro);
            cmd.Parameters.AddWithValue("@cidade", ig.cidade);
            cmd.Parameters.AddWithValue("@uf", ig.uf);
            cmd.Parameters.AddWithValue("@cep", ig.cep);
            cmd.Parameters.AddWithValue("@email", ig.email);
            cmd.Parameters.AddWithValue("@tel1", ig.tel1);
            cmd.Parameters.AddWithValue("@tel2", ig.tel2);
            cmd.Parameters.AddWithValue("@sede", ig.sede);
            cmd.Parameters.AddWithValue("@Saldo", ig.saldoInicial);
            cmd.Parameters.AddWithValue("@Tit1", ig.tit1);
            cmd.Parameters.AddWithValue("@Tit2", ig.tit2);
            cmd.Parameters.AddWithValue("@Assinatura1", ig.assinatura1);
            cmd.Parameters.AddWithValue("@Assinatura2", ig.assinatura2);
            cmd.ExecuteNonQuery();


        }

    }
}
