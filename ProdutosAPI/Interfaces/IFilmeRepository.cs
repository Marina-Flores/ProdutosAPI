using ProdutosAPI.Entities;

namespace ProdutosAPI.Interfaces
{
    public interface IFilmeRepository
    {
        Task<IEnumerable<Filme>> GetAllFilmes();
        Task AddFilme(Filme filme);
    }
}
