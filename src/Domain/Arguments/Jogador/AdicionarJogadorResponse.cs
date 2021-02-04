﻿using Domain.Interface.Arguments;
using Domain.Resources;
using System;

namespace Domain.Arguments.Jogador
{
    public class AdicionarJogadorResponse: IResponse
    {
        public Guid Id { get; set; }
        public string Mensagem { get; set; }

        public static explicit operator AdicionarJogadorResponse(Entities.Jogador jogador)
        {
            return new AdicionarJogadorResponse
            {
                Id = jogador.Id,
                Mensagem = Message.X_SUCESSO
            };
        }
    }
}
