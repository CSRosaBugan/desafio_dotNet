using System.ComponentModel.DataAnnotations;
namespace desafio.Models
{
    public class Telefone
    {
        [Required(ErrorMessage = "este campo eh obrigatorio")]
        [MaxLength(9, ErrorMessage = "Este campo deve conter no maximo 9 caracters")]
        [MinLength(8, ErrorMessage = "Este campo deve conter no minimo 8 caracters")]
        public string numero { get; set; }
        [Required(ErrorMessage = "este campo eh obrigatorio")]
        [MaxLength(2, ErrorMessage = "Este campo deve conter 2 caracters")]
        [MinLength(2, ErrorMessage = "Este campo deve conter 2 caracters")]
        public string ddd { get; set; }
    }
}