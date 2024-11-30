using ProdutosAPI.Entities;
using ProdutosAPI.Interfaces;

namespace ProdutosAPI.Services
{
    public class FilmeService(IFilmeRepository filmeRepository)
    {
        public async Task<IEnumerable<Filme>> GetAllFilmes()
            => await filmeRepository.GetAllFilmes();

        public async Task AddFilme(Filme filme)
          => await filmeRepository.AddFilme(filme);
        
        public virtual async Task<Filme?> GetFilmeById(int id) 
            => await filmeRepository.GetFilmeById(id);

        public async Task RemoveFilme(int id)
            => await filmeRepository.RemoveFilme(id);
        
    }
}
