using LostFocus.Models;
using System.Collections.Generic;

namespace LostFocus.Infrastructures
{
    // Interfejs generyczny (szablon)
    public interface IEntityRepository<TEntity>
        where TEntity : BaseEntity
    {
        ICollection<TEntity> Get();
    }
}
