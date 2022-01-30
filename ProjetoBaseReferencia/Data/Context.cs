using Microsoft.EntityFrameworkCore;
using ProjetoBaseReferencia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBaseReferencia.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
