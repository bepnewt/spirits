using Microsoft.EntityFrameworkCore;
using SpiritsApp.Model.Entity;
using SpiritsApp.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpiritsApp.Data
{
    public class SpiritsContext: DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<MeasureType> MeasureType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=Spirits;User ID=postgres;Password=docker");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SetupAllAuditFields(modelBuilder);

            // Many-2-Many relationships
            modelBuilder.Entity<RecipeIngredient>().HasKey(ri => new { ri.RecipeId, ri.IngredientId });
            modelBuilder.Entity<RecipeIngredient>().HasOne(ri => ri.Recipe).WithMany(r => r.RecipeIngredients).HasForeignKey(ri => ri.RecipeId);
            modelBuilder.Entity<RecipeIngredient>().HasOne(ri => ri.Ingredient).WithMany(i => i.RecipeIngredients).HasForeignKey(ri => ri.IngredientId);
        }

        private void SetupAllAuditFields(ModelBuilder modelBuilder)
        {
            // Shadow Fields - Audit for all entities
            modelBuilder.Entity<Cocktail>().Property<DateTime?>("Updated");
            modelBuilder.Entity<Cocktail>().Property<string>("UpdatedBy");
            modelBuilder.Entity<Cocktail>().Property<DateTime>("Created");
            modelBuilder.Entity<Cocktail>().Property<string>("CreatedBy");

            modelBuilder.Entity<Ingredient>().Property<DateTime?>("Updated");
            modelBuilder.Entity<Ingredient>().Property<string>("UpdatedBy");
            modelBuilder.Entity<Ingredient>().Property<DateTime>("Created");
            modelBuilder.Entity<Ingredient>().Property<string>("CreatedBy");

            modelBuilder.Entity<MeasureType>().Property<DateTime?>("Updated");
            modelBuilder.Entity<MeasureType>().Property<string>("UpdatedBy");
            modelBuilder.Entity<MeasureType>().Property<DateTime>("Created");
            modelBuilder.Entity<MeasureType>().Property<string>("CreatedBy");

            modelBuilder.Entity<Recipe>().Property<DateTime?>("Updated");
            modelBuilder.Entity<Recipe>().Property<string>("UpdatedBy");
            modelBuilder.Entity<Recipe>().Property<DateTime>("Created");
            modelBuilder.Entity<Recipe>().Property<string>("CreatedBy");

            modelBuilder.Entity<RecipeIngredient>().Property<DateTime?>("Updated");
            modelBuilder.Entity<RecipeIngredient>().Property<string>("UpdatedBy");
            modelBuilder.Entity<RecipeIngredient>().Property<DateTime>("Created");
            modelBuilder.Entity<RecipeIngredient>().Property<string>("CreatedBy");
        }

    }
}
