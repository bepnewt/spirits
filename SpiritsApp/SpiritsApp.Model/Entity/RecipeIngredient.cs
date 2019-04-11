using SpiritsApp.Model.Interface;

namespace SpiritsApp.Model.Entity
{
    public class RecipeIngredient: EntityBase, IBaseEntity
    {
        public override long Id { get; set; }

        public long RecipeId { get; set; }

        public Recipe Recipe { get; set; }

        public long IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }

    }
}
