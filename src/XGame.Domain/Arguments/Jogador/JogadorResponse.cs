using System;

namespace XGame.Domain.Arguments.Jogador
{
    public class JogadorResponse
    {
        public Guid Id { get; private set; }
        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public string Email { get; private set; }        
        public string Status { get; private set; }

        public static explicit operator JogadorResponse(Entities.Jogador jogador)
        {
            return new JogadorResponse()
            {
                Id = jogador.Id,
                PrimeiroNome = jogador.Nome.PrimeiroNome,
                UltimoNome = jogador.Nome.UltimoNome,
                Email = jogador.Email.Endereco
                //,Status = jogador.Status.ToString()
            };
        }
    }
}
