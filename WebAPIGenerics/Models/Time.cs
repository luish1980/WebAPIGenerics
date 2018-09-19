using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIGenerics.Models
{
    [Table("Time")]
    public class Time
    {
        
        public int TimeID { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
        //public DateTime DataCriacao { get; set; }
        
        public ICollection<Jogador> lstJogadores { get; set; }
        
    }
}