using System;

namespace ControleFinanceiroIgreja.TAD
{
    public class Reuniao
    {

        public int id { get; set; }

        public int idClasse { get; set; }

        public DateTime data { get; set; }

        public int biblias { get; set; }

        public int revistas { get; set; }

        public int visitantes { get; set; }

        public decimal oferta { get; set; }

        public string obs { get; set; }

    }
}
