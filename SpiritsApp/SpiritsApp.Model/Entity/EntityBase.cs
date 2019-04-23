using SpiritsApp.Model.Interface;

namespace SpiritsApp.Model.Entity
{
    public class EntityBase: IBaseEntity
    {
        public virtual long Id { get; set; }
    }
}
