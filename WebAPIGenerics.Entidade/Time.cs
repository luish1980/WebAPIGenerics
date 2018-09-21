using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace WebAPIGenerics.Entidade
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