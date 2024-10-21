using Microsoft.AspNetCore.Mvc;
using ProdutosAPI.Services;

namespace ProdutosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController(FilmeService filmeService) : ControllerBase
    {
        private readonly FilmeService _filmeService = filmeService;

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var filmes = await _filmeService.GetAllFilmes();

            if (filmes == null || !filmes.Any())
                return NoContent();

            return Ok(filmes);
        }
    }
}
