using System;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Repositories.Base;

namespace XGame.Domain.Interface.Repositories
{
    public interface IRepositoryJogo : IRepositoryBase<Jogo, Guid>
    {
    }

}
