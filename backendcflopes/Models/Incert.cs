using System;

namespace backendcflopes.Models
{
    public class Incert
    {
        public int id { get; set; }
        public DateTime data_vencimento { get; set; }
        public string valor_original { get; set; }
        public string valor_juros { get; set; }
        public string quantidade_parcela { get; set; }
        public string numero_contrato { get; set; }
        public DateTime data_inserido { get; set; } = DateTime.Now;
    }
}
