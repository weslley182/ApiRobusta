using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Resources;

namespace XGame.Domain.ValueObjects
{
    public class Nome: Notifiable
    {
        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }

        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            new AddNotifications<Nome>(this)
                .IfNullOrInvalidLength(n => n.PrimeiroNome, 3, 30, Message.X_INVALIDO.ToFormat("Nome"))
                .IfNullOrInvalidLength(n => n.UltimoNome, 3, 30, Message.X_INVALIDO.ToFormat("SobreNome"));
        }
    }
}
