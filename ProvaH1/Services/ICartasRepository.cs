using ProvaH1.Models;

namespace ProvaH1.Services
{
    public interface ICartasRepository
    {
        public List<DadosPessoa> obterTodasAsCartas();

        public void Inserir(DadosPessoa novoAluno);
    }
}
