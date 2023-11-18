using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vlad_Malina_Lab2.Models;

namespace Vlad_Malina_Lab2.Data
{
    public class Vlad_Malina_Lab2Context : DbContext
    {
        public Vlad_Malina_Lab2Context (DbContextOptions<Vlad_Malina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Vlad_Malina_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Vlad_Malina_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Vlad_Malina_Lab2.Models.Authors> Authors { get; set; } = default!;
    }
}
