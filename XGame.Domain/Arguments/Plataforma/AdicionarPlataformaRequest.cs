using XGame.Domain.Interface.Arguments;

namespace XGame.Domain.Arguments.Plataforma
{
    public class AdicionarPlataformaRequest: IRequest
    {
        public string Nome { get; set; }
    }
}
