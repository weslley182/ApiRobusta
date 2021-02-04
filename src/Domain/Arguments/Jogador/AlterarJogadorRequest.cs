using Domain.Interface.Arguments;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Arguments.Jogador
{
    public class AlterarJogadorRequest : IRequest
    {
        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }        
    }
}
