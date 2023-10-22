using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sinca_Teodora_Lab2.Models;

namespace Sinca_Teodora_Lab2.Data
{
    public class Sinca_Teodora_Lab2Context : DbContext
    {
        public Sinca_Teodora_Lab2Context (DbContextOptions<Sinca_Teodora_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Sinca_Teodora_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Sinca_Teodora_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
