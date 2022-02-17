using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Interface.Repository;
using XGame.Domain.Interface.Service;

namespace XGame.Domain.Service
{
    public class ServiceJogador : IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(RepositoryAdicionarJogador request)
        {
            Guid id  = _repositoryJogador.AdicionarJogador(request);

            return new AdicionarJogadorResponse() { Id = id, Message = "Operação realizada com sucesso" }; 
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                throw new Exception("Autenticar jogador Request é obrigatorio");
            }

            if (string.IsNullOrEmpty(request.Email))
            {
                throw new Exception("Informe o email");
            }

            if (string.IsNullOrEmpty(request.Senha))
            {
                throw new Exception("Informe a senha");
            }

            if (request.Senha.Length < 6)
            {
                throw new Exception("Senha invalida");
            }

            var response = _repositoryJogador.AutenticarJogador(request);

            return response;
        }
    }
}
