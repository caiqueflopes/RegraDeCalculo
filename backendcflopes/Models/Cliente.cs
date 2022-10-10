using System;

namespace backendcflopes.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string cep { get; set; }
        public string uf { get; set; }
        public string cidade { get; set; }
        public DateTime data_inserido { get; set; } = DateTime.Now;
    }
}
