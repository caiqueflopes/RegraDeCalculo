using System;

namespace backendcflopes.Models
{
    public class Parcela
    {
        public int id { get; set; }
        public int id_contrato { get; set; }
        public int id_cliente { get; set; }
        public string numero_parcela { get; set; }
        public bool baixado { get; set; }
        public double valor_parcela_original { get; set; }
        public double valor_parcela_cheio { get; set; }
        public double valor_parcela_desconto { get; set;}
        public int qtd_parcela { get; set; }
        public DateTime data_vencimento_parcela { get; set; }
        public DateTime data_inserido { get; set; } = DateTime.Now;
    }
}
