using System;

namespace ControleFinanceiroIgreja.TAD
{
    public class Historico
    {

        public int id { get; set; }

        public int idMembro { get; set; }

        public string nomeMembro { get; set; }

        public DateTime data { get; set; }

        public string desc { get; set; }

    }
}
