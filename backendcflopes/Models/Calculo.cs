using System;

namespace backendcflopes.Models
{
    public class Calculo
    {
        public int id { get; set; }
        public string nome_campanha { get; set; }
        public bool ativo { get; set; }
        public double juros_total { get; set; }
        public double juros_simples { get; set; }
        public double porcentagem_desconto_permitido { get; set; }
        public int comissao_pasch { get; set; }
        public DateTime data_inserido { get; set; } = DateTime.Now;
    }
}
