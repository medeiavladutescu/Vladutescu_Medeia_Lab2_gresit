using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vladutescu_Medeia_Lab2.Models;

namespace Vladutescu_Medeia_Lab2.Data
{
    public class Vladutescu_Medeia_Lab2Context : DbContext
    {
        public Vladutescu_Medeia_Lab2Context (DbContextOptions<Vladutescu_Medeia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Vladutescu_Medeia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Vladutescu_Medeia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Vladutescu_Medeia_Lab2.Models.Author> Author { get; set; } = default!;

        
    }
}
