using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using storebook.Models;

namespace storebook.Data
{
    public class storebookContext : DbContext
    {
        public storebookContext (DbContextOptions<storebookContext> options)
            : base(options)
        {
        }

        public DbSet<storebook.Models.book> book { get; set; } = default!;

        public DbSet<storebook.Models.usersaccounts>? usersaccounts { get; set; }

        public DbSet<storebook.Models.orders>? orders { get; set; }
        public DbSet<storebook.Models.report>? report { get; set; }

    }
}
