using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokesLibrary.Models;

    public class JokesContext : DbContext
    {
        public JokesContext (DbContextOptions<JokesContext> options)
            : base(options)
        {
        }

        public DbSet<JokesLibrary.Models.Joke> Joke { get; set; } = default!;
    }
