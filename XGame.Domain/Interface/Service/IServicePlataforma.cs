using XGame.Domain.Arguments.Plataforma;

namespace XGame.Domain.Interface.Service
{
    public interface IServicePlataforma
    {
        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarPlataformaRequest plataforma);
    }
}
