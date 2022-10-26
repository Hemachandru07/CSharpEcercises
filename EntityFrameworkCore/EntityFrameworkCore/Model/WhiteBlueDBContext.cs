using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EntityFrameworkCore.Model
{
    public partial class WhiteBlueDBContext : DbContext
    {
        public WhiteBlueDBContext()
        {
        }

        public WhiteBlueDBContext(DbContextOptions<WhiteBlueDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supllier> Suplliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=WhiteBlueDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__product__DD37D91AAD02F457");

                entity.ToTable("product");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("pid");

                entity.Property(e => e.Dom)
                    .HasColumnType("date")
                    .HasColumnName("dom");

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.HasOne(d => d.SidNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Sid)
                    .HasConstraintName("FK__product__sid__286302EC");
            });

            modelBuilder.Entity<Supllier>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__supllier__DDDFDD36B064423A");

                entity.ToTable("supllier");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Location)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("location")
                    .HasDefaultValueSql("('mumbai')");

                entity.Property(e => e.Sname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("sname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
