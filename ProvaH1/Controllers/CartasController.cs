using Microsoft.AspNetCore.Mvc;
using ProvaH1.Models;
using ProvaH1.Services;

namespace ProvaH1.Controllers
{
    [ApiController]
    [Route("api/cartas")]
    public class CartasController : Controller
    {
        private readonly ICartasRepository _cartasRepository;
        public CartasController(ICartasRepository cartasRepository)
        {
            _cartasRepository = cartasRepository;
        }

        [HttpGet]
        [Route("ObterTodos")]
        public IActionResult ObterTodos()
        {
            return Ok(_cartasRepository.obterTodasAsCartas());
        }

        [HttpPost]
        [Route("Inserir")]
        public IActionResult Inserir(NovaPessoa dados)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _cartasRepository.Inserir(new DadosPessoa()
            {
                Nome = dados.Nome,
                Cidade = dados.Cidade,
                Estado = dados.Estado,
                Bairro = dados.Bairro,
                Rua = dados.Rua,
                NumeroCasa = dados.NumeroCasa,
                Texto = dados.Texto,
            });


            return Ok("Carta Cadastrada");
        }
    }
}
