using XGame.Domain.Arguments.Jogador;

namespace XGame.Domain.Interface.Service
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        AdicionarJogadorResponse AdicionarJogador(RepositoryAdicionarJogador request);
    }
}
