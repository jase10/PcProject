using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectGui
{
    public partial class PartDatabaseContext : DbContext
    {
        public PartDatabaseContext()
        {
        }

        public PartDatabaseContext(DbContextOptions<PartDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cpu> Cpu { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog= PartDatabase; Persist Security Info = True; User ID = SA; Password = Passw0rd2018");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cpu>(entity =>
            {
                entity.ToTable("CPU");

                entity.Property(e => e.CpuId).HasColumnName("CPU_ID");

                entity.Property(e => e.CpuName)
                    .HasColumnName("CPU_Name")
                    .HasColumnType("text");
                entity.Property(e => e.CoreCount)
                   .HasColumnName("CoreCount")
                   .HasColumnType("int");
                entity.Property(e => e.CoreClock)
                   .HasColumnName("CoreClock")
                   .HasColumnType("float");
                entity.Property(e => e.BoostClock)
                   .HasColumnName("BoostClock")
                   .HasColumnType("float");
                entity.Property(e => e.Tdp).HasColumnName("TDP")
                .HasColumnName("TDP")
                   .HasColumnType("int");

                entity.Property(e => e.Price)
                    .HasColumnName("Price")
                    .HasColumnType("float");
                 

                
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
