using Domain.Interface.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse: IResponse
    {
        public string PrimeiroNome { get; set; }

        public string Email { get; set; }
    }
}
