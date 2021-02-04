using Domain.Arguments.Jogador;
using System.Collections.Generic;
using XGame.Domain.Arguments.Jogador;

namespace XGame.Domain.Interface.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);
        AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request);
        IEnumerable<JogadorResponse> ListarJogador();
    }
}
