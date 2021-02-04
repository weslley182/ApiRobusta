using XGame.Domain.Entities;
using XGame.Domain.Resources;

namespace XGame.Domain.Arguments.Base
{
    public class ResponseBase
    {
        public string Mensagem { get; set; }
        public ResponseBase()
        {
            Mensagem = Message.X_SUCESSO;
        }
        

        public static explicit operator ResponseBase(Jogo entidade)
        {
            return new ResponseBase() {
                Mensagem = Message.X_SUCESSO
            };
        }
    }
}
