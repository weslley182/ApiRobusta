using Domain.Arguments.Jogador;
using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Interface.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador AutenticarJogador(Jogador jogador);
        Jogador AdicionarJogador(Jogador jogador);
        void AlterarJogador(Jogador jogador);
        IEnumerable<Jogador> ListarJogador();
        Jogador ObterJogadorPorId(Guid id);
    }
}
