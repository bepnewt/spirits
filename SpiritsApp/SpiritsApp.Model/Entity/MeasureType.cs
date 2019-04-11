using SpiritsApp.Model.Interface;

namespace SpiritsApp.Model.Entity
{
    public class MeasureType: EntityBase, IBaseEntity
    {
        public override long Id { get; set; }

        public string Name { get; set; }

        public string Abbreviation { get; set; }
    }
}
