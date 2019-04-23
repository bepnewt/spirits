using SpiritsApp.Model.Interface;

namespace SpiritsApp.Model.Entity
{
    public class Cocktail: EntityBase, IBaseEntity
    {
        public override long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
