using System;

namespace ControleFinanceiroIgreja.TAD
{
    public class Entrada
    {

        public int id { get; set; }
        public int idcat { get; set; }
        public int idmembro { get; set; }
        public string nomeMembro { get; set; }
        public string obs { get; set; }
        public DateTime data { get; set; }
        public decimal valor { get; set; }

    }
}
