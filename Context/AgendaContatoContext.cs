using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GenContatos.Models;

namespace GenContatos.Context
{
    public class AgendaContatoContext : DbContext
    {
        public AgendaContatoContext(DbContextOptions<AgendaContatoContext> options) : base (options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}