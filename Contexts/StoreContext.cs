﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using HW1WEB.Models;
using Npgsql;


namespace HW1WEB.Contexts
{
    public class StoreContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Store> Stores { get; set; }

        public virtual DbSet<Category> Categories { get; set; }
        private string _connectionString;

        public StoreContext() { }
        public StoreContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder builder) =>
            //builder.UseSqlite("Data Source=DB\\chat.db");
            builder.UseLazyLoadingProxies()
                //builder.LogTo(Console.WriteLine)
                //.UseLazyLoadingProxies()
                .UseNpgsql();//("Host=localhost;Port=5432;Username=postgres;Password=example;Database=store_market");*/
        protected override void OnConfiguring(DbContextOptionsBuilder builder) =>
            builder.UseLazyLoadingProxies()
                .UseNpgsql(_connectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id).HasName("product_pkey");
                entity.ToTable("Products");
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.HasIndex(e => e.Name).IsUnique();
                entity.Property(d => d.Description).HasMaxLength(250);
                entity.HasMany(e => e.Stores).WithMany(e => e.Products);
                entity.HasOne(e=>e.Category).WithMany(e=>e.Products).HasForeignKey(e=>e.CategoryId);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(p => p.Id).HasName("cotegory_pkey");
                entity.ToTable("Cotegories");
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.HasIndex(e => e.Name).IsUnique();
                entity.Property(d => d.Description).HasMaxLength(250);
                
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(p => p.Id).HasName("store_pkey");
                entity.ToTable("Stores");
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
