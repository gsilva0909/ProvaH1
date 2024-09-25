using ProvaH1.Models;

namespace ProvaH1.Services
{
    public class CartasRepository : ICartasRepository
    {
        private static List<DadosPessoa> dadosCartasList = new List<DadosPessoa>();
        public CartasRepository() { }
        public List<DadosPessoa> obterTodasAsCartas()
        {
            return dadosCartasList;
        }
        public void Inserir(DadosPessoa novaPessoa)
        {
            dadosCartasList.Add(novaPessoa);
        }
    }
}
