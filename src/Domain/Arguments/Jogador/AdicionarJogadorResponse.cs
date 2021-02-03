﻿using Domain.Interface.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Arguments.Jogador
{
    public class AdicionarJogadorResponse: IResponse
    {
        public Guid Id { get; set; }

        public string Message { get; set; }
    }
}
