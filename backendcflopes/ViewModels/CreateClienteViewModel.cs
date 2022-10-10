using System.ComponentModel.DataAnnotations;

namespace backendcflopes.ViewModels
{
    public class CreateClienteViewModel
    {
        [Required]
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string cep { get; set; }
        public string uf { get; set; }
        public string cidade { get; set; }
    }
}
