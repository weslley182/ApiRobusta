using System;
using XGame.Domain.Interface.Arguments;
using XGame.Domain.Resources;

namespace XGame.Domain.Arguments.Jogador
{
    public class AlterarJogadorResponse: IResponse
    {
        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }


        public static explicit operator AlterarJogadorResponse(Entities.Jogador jogador)
        {
            return new AlterarJogadorResponse()
            {
                Id = jogador.Id,
                PrimeiroNome = jogador.Nome.PrimeiroNome,
                UltimoNome = jogador.Nome.UltimoNome,
                Email = jogador.Email.Endereco,
                Mensagem = Message.X_SUCESSO
            };
        }
    }
}
