using System;

namespace ControleFinanceiroIgreja.TAD
{
    public class Visitas
    {
        public int id { get; set; }

        public DateTime data { get; set; }

        public string obs { get; set; }

        public int idVisitante { get; set; }

        public string tipo { get; set; }

        public string nomeVisitante { get; set; }

    }
}
