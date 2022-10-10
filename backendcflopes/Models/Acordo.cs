using System;

namespace backendcflopes.Models
{
    public class Acordo
    {
        public int id { get; set; }
        public int id_contrato { get; set; }
        public int id_cliente { get; set; }
        public int id_calculo { get; set; }
        public bool ativo { get; set; }
        public double valor_acordo { get; set; }
        public double valor_juros_acordo { get; set; }
        public double valor_desconto_acordo { get; set; }
        public DateTime data_criado { get; set; } = DateTime.Now;
        public DateTime data_fechado { get; set; }
    }
}
