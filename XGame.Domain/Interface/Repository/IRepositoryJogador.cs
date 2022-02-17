using System;
using XGame.Domain.Arguments.Jogador;

namespace XGame.Domain.Interface.Repository
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        Guid AdicionarJogador(RepositoryAdicionarJogador request);
    }
}
