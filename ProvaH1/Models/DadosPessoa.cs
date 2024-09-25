using System.ComponentModel.DataAnnotations;

namespace ProvaH1.Models
{
    public class DadosPessoa
    {
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string NumeroCasa { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Texto { get; set; }
    }
}
