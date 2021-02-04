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
using System.Collections.Generic;
using System.Linq;

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

            if (IsInvalid())
            {
                return null;
            }

            return (AdicionarJogadorResponse)_repo.AdicionarJogador(jogador);            
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

            return (AutenticarJogadorResponse)_repo.AutenticarJogador(jogador);
        }
        public AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request)
        {
            var jogador = _repo.ObterJogadorPorId(request.Id);

            if(jogador == null)
            {
                AddNotification("Id", Message.X_NAOENCONTRADO.ToFormat("jogador"));
                return null;
            }

            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);
            
            jogador.AlterarJogador(nome, email);

            AddNotifications(jogador);

            if (IsInvalid())
            {
                return null;
            }
            _repo.AlterarJogador(jogador);

            return (AlterarJogadorResponse)jogador;
        }
        public IEnumerable<JogadorResponse> ListarJogador()
        {
            return _repo.ListarJogador().ToList().Select(jogador => (JogadorResponse)jogador).ToList();
        }
    }
}
