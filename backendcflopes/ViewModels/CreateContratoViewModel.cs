using System.ComponentModel.DataAnnotations;

namespace backendcflopes.ViewModels
{
    public class CreateContratoViewModel
    {
        [Required]
        public string numero_contrato { get; set; }
    }
}
