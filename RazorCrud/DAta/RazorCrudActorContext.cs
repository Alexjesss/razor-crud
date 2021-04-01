using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

    public class RazorCrudActorContext : DbContext
    {
        public RazorCrudActorContext (DbContextOptions<RazorCrudActorContext> options)
            : base(options)
        {
        }

        public DbSet<RazorCrud.Models.Actor> Actor { get; set; }
    public object Movie { get; internal set; }
}
