using System;
using System.Collections.Generic;

namespace WebAPIGenerics.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Posicao { get; set; }
        private Time Time { get; set; }
        private ICollection<Competicao> lstCompeticoes { get; set; }

    }
}