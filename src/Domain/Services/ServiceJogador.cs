using Domain.Arguments.Jogador;
using Domain.Entities;
using Domain.Enum;
using Domain.Interface.Repositories;
using Domain.Interface.Services;
using Domain.Resources;
using Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;

namespace Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repo;

        public ServiceJogador(IRepositoryJogador repo)
        {
            _repo = repo;
        }
        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);
            var jogador = new Jogador(nome, email, request.Senha);
            
            AddNotifications(jogador);

            if (this.IsInvalid())
            {
                return null;
            }

            Guid id = _repo.AdicionarJogador(jogador);

            return new AdicionarJogadorResponse { Id = id, Message = "Operação realizada com cucesso." };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if(request == null)
            {
                AddNotification("AutenticadorJogadorRequest", Message.X_OBRIGATORIO.ToFormat("AutenticadorJogadorRequest"));
            }

            
            var nomeCompleto = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);
            var jogador = new Jogador(nomeCompleto, email, request.Senha);

            AddNotifications(jogador, email);

            if (jogador.IsInvalid())
            {
                return null;
            }

            return _repo.AutenticarJogador(request);
        }
        
    }
}
