using System;

namespace ControleFinanceiroIgreja.TAD
{
    public class Membro
    {

        public int id { get; set; }

        public string nome { get; set; }

        public DateTime dtnasc { get; set; }

        public string cpf { get; set; }

        public string rg { get; set; }

        public string sexo { get; set; }

        public string endereco { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string tel1 { get; set; }

        public string tel2 { get; set; }

        public string email { get; set; }

        public string dtmembro { get; set; }
        
        public string dtCasamento { get; set; }

        public string cep { get; set; }

        public string uf { get; set; }

        public bool inativo { get; set; }

        public int idAdmissao { get; set; }

        public int idStatus { get; set; }

        public string admissao { get; set; }

        public string status { get; set; }

        public string nomePai { get; set; }

        public string nomeMae { get; set; }

        public string estadoCivil { get; set; }

        public string titEleitor { get; set; }

        public string obs { get; set; }

        public string profissao { get; set; }

        public string localNascimento { get; set; }

        public string procedencia { get; set; }

    }
}
