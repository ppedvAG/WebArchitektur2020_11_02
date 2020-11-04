using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebAPI_With_Scaffold.Models;

namespace WebAPI_With_Scaffold.Data
{
    public partial class CarDBV2Context : DbContext
    {
        public CarDBV2Context()
        {
        }

        public CarDBV2Context(DbContextOptions<CarDBV2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Train> Train { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsCaprio)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.MitRadio)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");
            });

            modelBuilder.Entity<Train>(entity =>
            {
                entity.Property(e => e.Kmh).HasColumnName("KMH");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
