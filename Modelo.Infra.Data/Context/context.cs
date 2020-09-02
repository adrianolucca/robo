using Microsoft.EntityFrameworkCore;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Context
{
   public class context : DbContext
    {
        public context(DbContextOptions<context> options) : base(options)
        {
        }

        public context() : base()
        {
        }
              
        public DbSet<Robo> Personagem { get; set; }
      
    }
}
