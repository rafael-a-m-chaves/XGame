using XGame.Domain.Interface.Arguments;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse : IResponse
    {
        public string PrimeiroNome { get; set; }
        public Email Email { get; set; }

    }
}
