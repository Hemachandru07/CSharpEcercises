using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BankEF.Model
{
    public partial class BankDBContext : DbContext
    {
        public BankDBContext()
        {
        }

        public BankDBContext(DbContextOptions<BankDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sbaccount> Sbaccounts { get; set; }
        public virtual DbSet<Sbtransaction> Sbtransactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=BankDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Sbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber)
                    .HasName("PK__sbaccoun__BE2ACD6EFD4DAC9E");

                entity.ToTable("sbaccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CurrentBalance).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sbtransaction>(entity =>
            {
                entity.HasKey(e => e.Transactionid)
                    .HasName("PK__sbtransa__9B52C2FAB2A66D3F");

                entity.ToTable("sbtransaction");

                entity.Property(e => e.Transactionid).HasColumnName("transactionid");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Transactiondate)
                    .HasColumnType("datetime")
                    .HasColumnName("transactiondate");

                entity.Property(e => e.Transactiontype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("transactiontype");

                entity.HasOne(d => d.AccountNumberNavigation)
                    .WithMany(p => p.Sbtransactions)
                    .HasForeignKey(d => d.AccountNumber)
                    .HasConstraintName("FK__sbtransac__Accou__276EDEB3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
