using C44_G03_EF02_Musician.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Musician.Data
{
    internal class MusicianDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MusicDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .HasOne(a => a.Musician)
                .WithMany(m => m.Albums)
                .HasForeignKey(a => a.MusicianId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Song>()
                .HasOne(s => s.Album)
                .WithMany(a => a.Songs)
                .HasForeignKey(s => s.AlbumId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Musician>()
                .HasMany(m => m.Songs)
                .WithMany(s => s.Musicians)
                .UsingEntity(j => j.ToTable("MusicianSongs"));

            modelBuilder.Entity<Musician>()
                .HasMany(m => m.Instruments)
                .WithMany(i => i.Musicians)
                .UsingEntity(j => j.ToTable("MusicianInstruments"));
        }

        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
    }
}
