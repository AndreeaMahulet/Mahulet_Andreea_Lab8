using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mahulet_Andreea_Lab8.Models;

namespace Mahulet_Andreea_Lab8.Data
{
    public class Mahulet_Andreea_Lab8Context : DbContext
    {
        public Mahulet_Andreea_Lab8Context (DbContextOptions<Mahulet_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Mahulet_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Mahulet_Andreea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Mahulet_Andreea_Lab8.Models.Category> Category { get; set; }
    }
}
