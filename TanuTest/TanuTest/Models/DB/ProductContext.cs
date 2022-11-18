using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TanuTest.Models.DB
{
    public partial class ProductContext : DbContext
    {
        public ProductContext()
        {
        }

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        public virtual DbSet<ProductInfo> ProductInfo { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=LAPN212241\\MSSQL2019;Database=Product;Trusted_Connection=True; \nEncrypt=false");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<ProductInfo>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("ProductInfo");

//                entity.Property(e => e.Description)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).ValueGeneratedOnAdd();

//                entity.Property(e => e.Title)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
