using System;

namespace backendcflopes.Models
{
    public class Contrato
    {
        public int id { get; set; }
        public string numero_contrato { get; set; }
        public bool baixado { get; set; }
        public double valor_contrato_cheio { get; set; }
        public double valor_contrato_desconto { get; set; }
        public int id_cliente { get; set; }
        public int id_parcela { get; set; }
        public int qtd_parcela { get; set; }
        public DateTime data_vencimento { get; set; }
        public DateTime data_inserido { get; set; } = DateTime.Now;
    }
}
