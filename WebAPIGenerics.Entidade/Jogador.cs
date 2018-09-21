using System;
using System.Collections.Generic;

namespace WebAPIGenerics.Entidade
{
    public class Jogador
    {
        public int JogadorId { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Posicao { get; set; }
        public Time Time { get; set; }
        public ICollection<Competicao> lstCompeticoes { get; set; }

    }
}