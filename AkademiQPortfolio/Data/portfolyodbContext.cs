using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AkademiQPortfolio.Data;

namespace PortfolyoDbContext
{
    public partial class portfolyodbContext : DbContext
    {
        public portfolyodbContext()
        {
        }

        public portfolyodbContext(DbContextOptions<portfolyodbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoriesTable> CategoriesTables { get; set; } = null!;
        public virtual DbSet<HomePage> HomePages { get; set; } = null!;
        public virtual DbSet<ProjectsTable> ProjectsTables { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<SkillTable> SkillTables { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ABDULLAH;Database=portfolyodb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriesTable>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("CategoriesTable");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(100);
            });

            modelBuilder.Entity<HomePage>(entity =>
            {
                entity.HasKey(e => e.HomeId);

                entity.ToTable("HomePage");

                entity.Property(e => e.HomeId).HasColumnName("HomeID");

                entity.Property(e => e.ImagePath).HasMaxLength(500);

                entity.Property(e => e.NameSurname).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<ProjectsTable>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("ProjectsTable");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.ProjectName).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProjectsTables)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_ProjectsTable_CategoriesTable");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.ExperinceId)
                    .HasName("PK_ExperincesTable");

                entity.Property(e => e.ExperinceId).HasColumnName("ExperinceID");

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.Icon).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<SkillTable>(entity =>
            {
                entity.HasKey(e => e.SkillId);

                entity.ToTable("SkillTable");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.Test).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
