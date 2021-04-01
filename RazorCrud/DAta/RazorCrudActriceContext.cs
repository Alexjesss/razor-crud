using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

    public class RazorCrudActriceContext : DbContext
    {
        public RazorCrudActriceContext (DbContextOptions<RazorCrudActriceContext> options)
            : base(options)
        {
        }

        public DbSet<RazorCrud.Models.Actrice> Actrice { get; set; }
    }
