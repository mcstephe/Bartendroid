using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bartendroid.Models;

namespace Bartendroid.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CocktailIngredient>().HasKey(ci => new { ci.CocktailId, ci.IngredientId});
        }

        public DbSet<Cocktail> Cocktail { get; set; } = default!;
        public DbSet<Ingredient> Ingredients { get; set; } = default!;
        public DbSet<CocktailIngredient> CocktailIngredients { get; set; } = default!;

        public DbSet<Container> Containers { get; set; } = default!;

        public DbSet<Batch> Batches { get; set; } = default!;

        public DbSet<Pump> Pumps { get; set; } = default!; 

    }
}
