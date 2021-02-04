using System;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Repositories.Base;

namespace XGame.Domain.Interface.Repositories
{
    public interface IRepositoryJogador : IRepositoryBase<Jogador, Guid>
    { 
    }       
}
