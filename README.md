# ProdutosAPI

Uma API simples em .NET Core para gerenciar uma coleção de filmes. Desenvolvido com o GitHub Flow.

## Sumário

- [Instalação](#instalação)
- [Utilização da API](#utilização-da-api)
- [Documentação da API](#documentação-da-api)
- [GitFlow](#gitflow)

## Instalação

Instruções para instalar o projeto localmente.

1. Certifique-se de ter o **SDK do .NET Core** instalado. Você pode baixá-lo em [dotnet.microsoft.com](https://dotnet.microsoft.com/download).
2. Clone este repositório para o seu ambiente local usando o seguinte comando:

git clone https://github.com/Marina-Flores/ProdutosAPI.git

3. Navegue até o diretório do projeto
4. Execute o projeto:

dotnet run 

Isso iniciará o servidor da API localmente.

## Utilização da API

A API pode ser acessada através de URLs como `http://localhost:<port>/api/filmes`. Você pode usar ferramentas como [Postman](https://www.postman.com/downloads/) para interagir com os endpoints.

### Exemplos de Endpoints:

- **GET /api/filmes**: Retorna todos os filmes.
- **POST /api/filmes**: Adiciona um novo filme.

## Documentação da API

Este projeto inclui a documentação da API usando Swagger. Para acessá-la, execute o projeto e navegue até `http://localhost:<port>/swagger` em seu navegador.

## GitFlow

Escolhi trabalhar com o GitFlow para o desenvolvimento da API porque ele oferece uma estrutura clara e organizada para gerenciar o código. Com branches específicas para desenvolvimento (como develop), novas funcionalidades (feature), lançamentos (release) e correções rápidas (hotfix), fica mais fácil colaborar com a equipe. Isso garante que novas funcionalidades possam ser integradas sem interromper o trabalho em andamento, o que é muito importante em um projeto. Além disso, essa abordagem ajuda a manter o código mais organizado e a controlar melhor as versões.


