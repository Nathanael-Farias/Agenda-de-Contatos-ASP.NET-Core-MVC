using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.Net.Http.Headers;
using ProjetoMVC_DIO.Models;

namespace ProjetoMVC_DIO.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext( DbContextOptions <AgendaContext>options) : base(options)
        {


        }

        public DbSet<Contato> Contatos { get; set;}
        


        
    }
}