using System;

namespace WebAPIGenerics.Models
{
    public class Competicao
    {
        public int CompeticaoId { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
    }
}