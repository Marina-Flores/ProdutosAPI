using Microsoft.AspNetCore.Mvc;
using Moq;
using ProdutosAPI.Controllers;
using ProdutosAPI.Entities;
using ProdutosAPI.Interfaces;
using ProdutosAPI.Services;

namespace ProdutosAPI.Teste;

public class FilmesControllerTest
{
    private readonly Mock<IFilmeRepository> _filmeRepositoryMock;
    private readonly Mock<FilmeService> _filmeServiceMock;
    private readonly FilmesController _controller;

    public FilmesControllerTest()
    {
        _filmeRepositoryMock = new Mock<IFilmeRepository>();
        _filmeServiceMock = new Mock<FilmeService>(_filmeRepositoryMock.Object);
        _controller = new FilmesController(_filmeServiceMock.Object);
    }

    [Fact]
    public async Task GetAll_ReturnsNoContent_WhenListIsEmpty()
    {
        var filmes = new List<Filme>();
        _filmeRepositoryMock.Setup(x => x.GetAllFilmes()).ReturnsAsync(filmes);

        var resultado = await _controller.GetAll();

        Assert.IsType<NoContentResult>(resultado);
    }

    [Fact]
    public async Task GetAll_ReturnsFilmList_WhenListIsNotEmpty()
    {
        var filmes = new List<Filme>()
            {
                new(1, "Harry Potter e a Pedra Filosofal", "Chris Columbus", 2001, "Fantasia", 59.99m),
                new(2, "Harry Potter e a Câmara Secreta", "Chris Columbus", 2002, "Fantasia", 49.99m),
                new(3, "Harry Potter e o Prisioneiro de Azkaban", "Alfonso Cuarón", 2004, "Fantasia", 69.99m)
            };
        _filmeRepositoryMock.Setup(x => x.GetAllFilmes()).ReturnsAsync(filmes);

        var resultado = await _controller.GetAll();

        Assert.IsType<OkObjectResult>(resultado);

        var okObjectResult = resultado as OkObjectResult;
        Assert.IsType<List<Filme>>(okObjectResult?.Value);

        var listaFilmes = okObjectResult?.Value as List<Filme>;
        Assert.NotNull(listaFilmes);
        Assert.NotEmpty(listaFilmes);
    }

    [Fact]
    public async Task AddFilme_ReturnsCreated_WhenFilmeIsValid()
    {
        var filme = new Filme(1, "Harry Potter e a Pedra Filosofal", "Chris Columbus", 2001, "Fantasia", 59.99m);

        var resultado = await _controller.AddFilme(filme);

        Assert.IsType<CreatedResult>(resultado.Result);
    }

    [Fact]
    public async Task AddFilme_ReturnsBadRequest_WhenFilmeIsNull()
    {
        Filme? filme = null;

        var resultado = await _controller.AddFilme(filme);

        Assert.IsType<BadRequestResult>(resultado.Result);
    }
}