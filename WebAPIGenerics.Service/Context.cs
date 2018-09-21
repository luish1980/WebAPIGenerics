using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using WebAPIGenerics.Entidade;
//using System.Data.e

namespace WebAPIGenerics.Service
{
    public class Context : DbContext
    {
        public Context() { }

        public DbSet<Time> Times { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Competicao> Competicoes { get; set; }
    }
}
