using ProvaH1.Validations;
using System.ComponentModel.DataAnnotations;


namespace ProvaH1.Models
{
    public class NovaPessoa
    {
        [Required(ErrorMessage = "Obrigatório")]
        [MinLength(3, ErrorMessage = "Minimo 3 letras")]
        [MaxLength(255, ErrorMessage = "Maximo 255 letras ")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Obrigatório")]
        [MaxLength(500, ErrorMessage = "Maximo 500 letras ")]
        public string Texto { get; set; }


        [Required(ErrorMessage = "Obrigatório")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string NumeroCasa { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [IdadeValidation(ErrorMessage = "Erro idade")]
        public int Idade { get; set; }

    }
}
