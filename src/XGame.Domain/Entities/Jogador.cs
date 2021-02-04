using prmToolkit.NotificationPattern;
using System;
using XGame.Domain.Enum;
using XGame.Domain.Extensions;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
    public class Jogador: Notifiable
    {
        public Guid Id { get; private set; }
        public Nome Nome { get; private set; }        
        public Email Email { get; private set; }
        public string Senha { get; private set; }
        public EnumSituacaoJogador Status { get; private set; }

        public Jogador(Nome nome, Email email, string senha)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Senha = senha;
            Status = EnumSituacaoJogador.EmAndamento;

            new AddNotifications<Jogador>(this)                
                .IfNullOrInvalidLength(j => j.Senha, 6, 32, "Senha inválida");

            if (IsInvalid())
            {
                Senha = Senha.ConvertToMD5();
            }
            
            AddNotifications(nome, email);
        }

        public void AlterarJogador(Nome nome, Email email)
        {
            Nome = nome;
            Email = email;

            AddNotifications(Nome, Email);
        }
    }
}
