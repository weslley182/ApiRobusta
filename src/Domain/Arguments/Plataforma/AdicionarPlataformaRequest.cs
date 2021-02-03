using Domain.Interface.Arguments;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Arguments.Plataforma
{
    public class AdicionarPlataformaRequest: IRequest
    {
        public string Nome { get; set; }
    }
}
