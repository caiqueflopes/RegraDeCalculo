using System.ComponentModel.DataAnnotations;

namespace backendcflopes.ViewModels
{
    public class CreateCalculoViewModel
    {
        [Required]
        public string nome_campanha { get; set; }
    }
}
