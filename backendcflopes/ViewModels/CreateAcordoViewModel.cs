using System;
using System.ComponentModel.DataAnnotations;

namespace backendcflopes.ViewModels
{
    public class CreateAcordoViewModel
    {
        [Required]
        public int id_contrato { get; set; }
        public int id_cliente { get; set; }
        public int id_calculo { get; set; }
        public bool ativo { get; set; }
        public double valor_acordo { get; set; }
        public double valor_juros_acordo { get; set; }
        public double valor_desconto_acordo { get; set; }
        public DateTime data_criado { get; set; } = DateTime.Now;
    }
}
