using prmToolkit.NotificationPattern;
using XGame.Domain.Interface.Repositories;
using XGame.Domain.Interface.Services;

namespace XGame.Domain.Services
{
    public class ServiceJogo : Notifiable, IServiceJogo
    {
        private readonly IRepositoryJogo _repositoryJogo;
        public ServiceJogo()
        {

        }
        public ServiceJogo(IRepositoryJogo repositoryJogo)
        {
            _repositoryJogo = repositoryJogo;
        }
    }
}
