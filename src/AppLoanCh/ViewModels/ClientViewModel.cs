using System.ComponentModel.DataAnnotations;

namespace LoanApp.ViewModels
{
    public class ClientViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public int Age {  get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Cpf { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public double Income { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Location { get; set; }
    }
}
