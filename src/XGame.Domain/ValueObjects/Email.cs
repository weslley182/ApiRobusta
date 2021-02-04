using prmToolkit.NotificationPattern;

namespace XGame.Domain.ValueObjects
{
    public class Email: Notifiable
    {
        public string Endereco { get; private set; }

        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this)
                .IfNotEmail(e => e.Endereco, "Email inválido");
        }
    }
}
