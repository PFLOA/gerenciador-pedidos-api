using Coladel.Application.Handlers.Login.Handler;
using Coladel.Application.Handlers.Login.Request;
using Coladel.Application.Handlers.Login.Response;
using Coladel.Core.Interfaces;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Moq;
using System;
using Xunit;

namespace Test.Handlers.Login
{
    public class RealizarLoginHandlerTests
    {
        [Fact]
        public void RealizarLogin_RetornaUsuarioEToken()
        {
            var realizarLoginUsuario = new Usuario("Potira", "7696", "potira21", "potiracaruana@gmail.com", Guid.NewGuid());
            var response = LoginHandler(realizarLoginUsuario);

            Assert.NotNull(response.Data);
            Assert.NotNull(response.Data.Token);
        }

        [Fact]
        public void RealizarLogin_RetornarNotFound()
        {
            var response = LoginHandler();
            Assert.True(response.ResultType == Coladel.Core.Enum.EnumTypeResult.NotFound);
            Assert.Equal("Usuário não Encontrado !", response.Messages[0]);
        }

        [Fact]
        public void RealizarLogin_RetornarInvalidInput_SenhaEmpty()
        {
            var response = LoginHandler(usuario: "potira21", senha: "");
            Assert.True(response.ResultType == Coladel.Core.Enum.EnumTypeResult.InvalidInput);
            Assert.Equal("Valor do usuário ou senha inválidos, verifique as credenciais", response.Messages[0]);
        }

        [Fact]
        public void RealizarLogin_RetornarInvalidInput_UsuarioEmpty()
        {
            var response = LoginHandler(usuario: "", senha: "1234");
            Assert.True(response.ResultType == Coladel.Core.Enum.EnumTypeResult.InvalidInput);
            Assert.Equal("Valor do usuário ou senha inválidos, verifique as credenciais", response.Messages[0]);
        }

        [Fact]
        public void RealizarLogin_RetornarInvalidInput_UsuarioSenhaEmpty()
        {
            var response = LoginHandler(usuario: "", senha: "");
            Assert.True(response.ResultType == Coladel.Core.Enum.EnumTypeResult.InvalidInput);
            Assert.Equal("Valor do usuário ou senha inválidos, verifique as credenciais", response.Messages[0]);
        }

        [Fact]
        public void RealizarLogin_RetornarNotFoundSenhaErrado()
        {
            var response = LoginHandler(senha: "1234");
            Assert.True(response.ResultType == Coladel.Core.Enum.EnumTypeResult.NotFound);
            Assert.Equal("Usuário não Encontrado !", response.Messages[0]);
        }

        [Fact]
        public void RealizarLogin_RetornarNotFoundUsuarioErrado()
        {
            var response = LoginHandler(usuario: "miguel");
            Assert.True(response.ResultType == Coladel.Core.Enum.EnumTypeResult.NotFound);
            Assert.Equal("Usuário não Encontrado !", response.Messages[0]);
        }

        [Fact]
        public void RealizarLogin_RetornarNotFoundUsuarioSenhaErrados()
        {
            var response = LoginHandler(usuario: "miguel", senha: "1234");
            Assert.True(response.ResultType == Coladel.Core.Enum.EnumTypeResult.NotFound);
            Assert.Equal("Usuário não Encontrado !", response.Messages[0]);
        }

        private static IOperationResult<RealizarLoginResponse> LoginHandler(Usuario realizarLoginUsuario = null, string usuario = "potira21", string senha = "7696")
        {
            var request = new RealizarLoginRequest(usuario, senha);

            var loginRepositoryMock = new Mock<ILoginRepository>();
            loginRepositoryMock.Setup(x => x.LoginUser("potira21", "7696")).Returns(realizarLoginUsuario);

            return new RealizarLoginHandler(loginRepositoryMock.Object).Handle(request, new()).Result;
        }
    }
}
