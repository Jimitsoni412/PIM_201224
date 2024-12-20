using Microsoft.EntityFrameworkCore;
using PIM.Api.Models;
using System.Data;

namespace PIM.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ProductCategoryMapping> ProductCategoryMappings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategoryMapping>()
                .HasKey(pcm => pcm.Id);

            modelBuilder.Entity<ProductCategoryMapping>()
                .HasOne(pcm => pcm.Product)
                .WithMany()
                .HasForeignKey(pcm => pcm.ProductId);

            modelBuilder.Entity<ProductCategoryMapping>()
                .HasOne(pcm => pcm.Category)
                .WithMany()
                .HasForeignKey(pcm => pcm.CategoryId);
        }
    }
}
