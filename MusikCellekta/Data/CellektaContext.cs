using Microsoft.EntityFrameworkCore;
using MusikCellekta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusikCellekta.Data
{
    public class CellektaContext : DbContext
    {
        public CellektaContext(DbContextOptions<CellektaContext> options) : base(options)
        {
        }

        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().ToTable("Song");
        }
    }
}
