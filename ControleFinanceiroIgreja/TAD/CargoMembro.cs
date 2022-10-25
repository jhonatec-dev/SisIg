using System;

namespace ControleFinanceiroIgreja.TAD
{
    public class CargoMembro
    {

        public int id { get; set; }

        public int idMembro { get; set; }

        public int idCargo { get; set; }

        public DateTime dtInicio { get; set; }

        public DateTime dtFim { get; set; }

        public string descCargo { get; set; }

    }
}
