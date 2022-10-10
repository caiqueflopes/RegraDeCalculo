using System.ComponentModel.DataAnnotations;

namespace backendcflopes.ViewModels
{
    public class CreateParcelaViewModel
    {
        [Required]
        public double valor_parcela_original { get; set; }
    }
}
