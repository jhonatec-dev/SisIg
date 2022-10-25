using System.Data.SqlClient;
using System.Data.SQLite;

namespace ControleFinanceiroIgreja.DAO
{
    public class Conexao
    {

        //public static SQLiteConnection con;
        public static SQLiteConnection con;


        public static void conectar()
        {

            if (con != null)
                con.Close();

            //Data Source=(LocalDB)\v11.0;AttachDbFilename="C:\Users\Jhon\documents\visual studio 2013\Projects\Papelaria\Papelaria\SRControleSimples.mdf";Integrated Security=True;Connect Timeout=30

            //con = new SQLiteConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""|DataDirectory|\Data\ControleIgreja.mdf"";Integrated Security=True;");
            // NO MEU NOTEBOOK A LINHA ABAIXO DEVE SER HABILITADA X..X
            //con = new SQLiteConnection(@"Data Source=(LocalDB)\MSSqlLocalDB;AttachDbFilename=""|DataDirectory|\Data\SisIg.mdf"";Integrated Security=True;");
            con = new SQLiteConnection(@"Data Source=""|DataDirectory|\Data\database.db"";Version=3;");

            con.Open();

            con.State.ToString();

        }


    }
}
