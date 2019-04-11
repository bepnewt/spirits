using SpiritsApp.Model.Interface;
using System.Collections.Generic;

namespace SpiritsApp.Model.Entity
{
    public class Recipe: EntityBase, IBaseEntity
    {
        public override long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public long CocktailId { get; set; }

        public Cocktail Cocktail { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
