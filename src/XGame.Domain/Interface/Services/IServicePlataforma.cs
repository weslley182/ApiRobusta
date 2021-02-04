using Domain.Arguments.Plataforma;

namespace XGame.Domain.Interface.Services
{
    public interface IServicePlataforma
    {
        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarPlataformaRequest request);
    }
}
