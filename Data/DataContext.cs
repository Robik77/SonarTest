using Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;

namespace Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext() : base()
        {}
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            builder.Build().GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(builder.Build().GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Element>().HasOne(e => e.Attribute);
            modelBuilder.Entity<Element>().HasOne(e => e.Block).WithMany(b => b.Elements);
            modelBuilder.Entity<Block>().HasOne(b => b.Page).WithMany(p => p.Blocks);
            modelBuilder.Entity<Page>().HasOne(p => p.Form).WithMany(f => f.Pages);
            modelBuilder.Entity<Form>().Property<string>("CreatorForeignKey");
            modelBuilder.Entity<Form>().HasOne(f => f.Creator).WithMany(u => u.FormsCreated).HasForeignKey("CreatorForeignKey").OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Form>().HasMany(f => f.Users).WithMany(u => u.FormsPassed);
        }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
    }
}
