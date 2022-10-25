namespace ControleFinanceiroIgreja.DAO
{
    public static class Funcoes
    {

        public static string nomeMes(int mes)
        {
            string strMes = "";

            switch (mes)
            {
                case 1:
                    strMes = "JAN";
                    break;
                case 2:
                    strMes = "FEV";
                    break;
                case 3:
                    strMes = "MAR";
                    break;
                case 4:
                    strMes = "ABR";
                    break;
                case 5:
                    strMes = "MAI";
                    break;
                case 6:
                    strMes = "JUN";
                    break;
                case 7:
                    strMes = "JUL";
                    break;
                case 8:
                    strMes = "AGO";
                    break;
                case 9:
                    strMes = "SET";
                    break;
                case 10:
                    strMes = "OUT";
                    break;
                case 11:
                    strMes = "NOV";
                    break;
                case 12:
                    strMes = "DEZ";
                    break;

                default:
                    break;
            }

            return strMes;

        }

    }
}
