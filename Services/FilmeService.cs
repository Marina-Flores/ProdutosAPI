using ProdutosAPI.Entities;
using ProdutosAPI.Interfaces;

namespace ProdutosAPI.Services
{
    public class FilmeService(IFilmeRepository filmeRepository)
    {
        private readonly IFilmeRepository _filmeRepository = filmeRepository;

        public async Task<IEnumerable<Filme>> GetAllFilmes()
            => await _filmeRepository.GetAllFilmes();
    }
}
