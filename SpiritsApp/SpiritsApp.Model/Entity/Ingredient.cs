using SpiritsApp.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpiritsApp.Model.Entity
{
    public class Ingredient: EntityBase, IBaseEntity
    {
        public override long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
