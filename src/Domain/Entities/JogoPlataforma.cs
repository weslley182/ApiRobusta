﻿using System;

namespace Domain.Entities
{
    public class JogoPlataforma
    {
        public Guid Id { get; set; }
        public Jogo Jogo { get; set; }
        public Plataforma Plataforma { get; set; }
        public DateTime DataLancamento{ get; set; }
    }
}
