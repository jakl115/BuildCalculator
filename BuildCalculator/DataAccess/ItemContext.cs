using Microsoft.EntityFrameworkCore;
using BuildCalculator.Data;
using BuildCalculator.Infrastructure;

namespace BuildCalculator.DataAccess
{
    public class ItemContext : DbContext
    {
        public DbSet<Item> items { get; set; }
        public DbSet<ItemClass> itemClasses { get; set; }

        public string dbPath { get; }

        public ItemContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            dbPath = System.IO.Path.Join(path, "items.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Item>()
                .HasOne<ItemClass>(i => i.itemClass)
                .WithMany(ic => ic.items)
                .HasForeignKey(items => items.itemClassId);

            builder.Entity<ItemClass>()
                .HasData(DataSeeder.getItemClasses());
        }
    }
}
